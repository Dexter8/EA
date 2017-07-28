using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EA.Data;
using EA.Data.Enums;
using EA.Form.CardForm;
using EA.Form.FileForm;
using EA.Model;
using EA.Models;
using EA.Models.SqlModels;

namespace EA.Form
{
    public partial class EditForm : XtraForm
    {
        private CardEditModeEnum _mode;
        private int _cardId;
        private int? _folderId;
        private Card _card;
        private List<FileData> _files; 

        public EditForm(CardEditModeEnum mode ,int cardId, int? folderId)
        {
            _mode = mode;
            _cardId = cardId;
            _folderId = folderId;
            InitializeComponent();
        }

        private void CardEditForm_Load(object sender, EventArgs e)
        {
            repItemLookUpEditStatus.DataSource = new FileModel().GetStatusList();
            

            //Редактирование
            if (_mode == CardEditModeEnum.Edit && _cardId != 0)
            {
                _card = new CardModel().GetCardData(_cardId);
                
                FillEditors();
                RefreshFiles();
            }

            //Новая карточка
            if (_mode == CardEditModeEnum.New)
            {
                _cardId = 0;


            }
        }

        private void RefreshFiles()
        {
            _files = new FileModel().GetCardFiles(_cardId);
            gridControlFiles.DataSource = _files;
            gridControlFileViewLog.DataSource = new FileViewSqlModel().GetFileViewLog(_cardId);
        }


        

        private void FillEditors()
        {
            _folderId = _card.FolderId;
            textEditCode.EditValue = _card.Code;
            textEditName.EditValue = _card.Name;
            memoEditDescription.EditValue = _card.Description;
            dateEditStartDevDate.EditValue = _card.StartDevelopDate;
            dateEditEndDevDate.EditValue = _card.EndDevelopDate;
            barStaticItemCreateDate.Caption = _card.CreateDate.ToString();
            barStaticItemCreateUserLogin.Caption = _card.CreateUserLogin;
        }
        

        private Card GetData()
        #region
        {
            Card card = new Card();
            card.FolderId = _folderId;
            card.Description = memoEditDescription.EditValue as string;
            card.Code = textEditCode.EditValue as string;
            card.Name = textEditName.EditValue as string;
            //card.DraftTypeId = lookUpEditDraftTypes.EditValue as int?;
            card.StartDevelopDate = dateEditStartDevDate.EditValue as DateTime?;
            card.EndDevelopDate = dateEditEndDevDate.EditValue as DateTime?;

            card.CardId = _cardId;
            return card;
        }
        #endregion


        /// <summary>
        /// Сохранить новую карточку
        /// </summary>
        /// <returns></returns>
        private bool SaveCard()
        #region
        {
            try
            {
                if (_mode == CardEditModeEnum.Edit)
                {
                    new CardModel().UpdateCard(GetData());
                }

                if (_mode == CardEditModeEnum.New)
                {
                    _cardId = new CardModel().CreateNewCard(GetData());
                    _mode = CardEditModeEnum.Edit;
                }

                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);   
                return false;
            }
        }
        #endregion


        /// <summary>
        /// Обновить данные карточки чертежа
        /// </summary>
        /// <returns></returns>
        private bool UpdateCard()
        #region
        {
            try
            {
                if (_cardId > 0)
                {
                    new CardModel().UpdateCard(GetData());
                }
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
        
        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveCard();
            Close();
        }

        
        private void sButtonOpenPdf_Click(object sender, EventArgs e)
        {
            if (!IsFileEnable()) return;

            int fileId = Convert.ToInt32(gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Id").ToString());
            //запись просмотра в журнал
            new FileViewSqlModel().SaveFileViewLog(_cardId, fileId, 1);

            new PdfViewer(fileId).ShowDialog();
            RefreshFiles();
        }

        private void sButtonLoadFile_Click(object sender, EventArgs e)
        {
            SaveCard();
            new FileLoadForm(_cardId, null, FileMode.New).ShowDialog();
            RefreshFiles();
        }


        private void buttonDeleteFile_Click(object sender, EventArgs e)
        #region
        {
            if (!IsFileEnable()) return;

            string fileName = gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Name") as string;
            if (new DialogModel().ShowYesNoMessageBox("Удалить документ " + fileName, "Удаление документа"))
            {
                int fileId = Convert.ToInt32(gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Id").ToString());
                new FileModel().DeleteFile(fileId);
                RefreshFiles();
            }
        }
        #endregion


        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            if (!IsFileEnable()) return;
            new FileEditForm().ShowDialog();
        }


        private bool IsFileEnable(string message = "Отсуствует документ")
        {
            if (gridViewFiles.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Нет");
                return false;
            }
            return true;
        }




        private void buttonUpdateFileVersion_Click(object sender, EventArgs e)
        {
            if (!IsFileEnable()) return;
            if (_cardId == 0) SaveCard();

            int fileId = Convert.ToInt32(gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Id").ToString());
            new FileLoadForm(_cardId, fileId, FileMode.UpdateVersion).ShowDialog();
            RefreshFiles();
        }

        private void gridViewFiles_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Если у док-та только одна версия, то делаем кнопку недоступной
            int? version = gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Version") as int?;
            if (version > 1) buttonShowPrevFileVersion.Enabled = true;
            else buttonShowPrevFileVersion.Enabled = false;

        }

        private void sButtonOpenFromAcrobatReader_Click(object sender, EventArgs e)
        {
            if (!IsFileEnable()) return;
        }

        private void sButtonSaveOnComputer_Click(object sender, EventArgs e)
        {
            if (!IsFileEnable()) return;
            int fileId = Convert.ToInt32(gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Id").ToString());
            new FileViewSqlModel().SaveFileViewLog(_cardId, fileId, 2);
            RefreshFiles();
        }

        private void sButtonLoadHistory_Click(object sender, EventArgs e)
        {
            if (!IsFileEnable()) return;
            new FileViewLogForm(_cardId).ShowDialog();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAttachCard_Click(object sender, EventArgs e)
        {
            new AttachCardForm().ShowDialog();
        }
    }
}
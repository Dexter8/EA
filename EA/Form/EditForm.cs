using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using DevExpress.XtraEditors;
using EA.Data;
using EA.Data.Enums;
using EA.Model;

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
            lookUpEditDraftTypes.Properties.DataSource = new DrawingModel().GetDraftTypes();
            repItemLookUpEditStatus.DataSource = new FileModel().GetStatusList();


            //Редактирование
            if (_mode == CardEditModeEnum.Edit && _cardId != 0)
            {
                _card = new CardModel().GetCardData(_cardId);
                _files = new FileModel().GetCardFiles(_cardId);
                FillEditors();
                gridControlFiles.DataSource = _files;
            }

            //Новая карточка
            if (_mode == CardEditModeEnum.New)
            {
                _cardId = 0;


            }
        }
        

        private void FillEditors()
        {
            _folderId = _card.FolderId;
            lookUpEditDraftTypes.EditValue = _card.DraftTypeId;
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
            card.DraftTypeId = lookUpEditDraftTypes.EditValue as int?;
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
        private bool SaveNewCard()
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
            if (_mode == CardEditModeEnum.New) SaveNewCard();
            else if (_mode == CardEditModeEnum.Edit) UpdateCard();
            Close();
        }

        private void sButtonOpenPdf_Click(object sender, EventArgs e)
        {
            //ошибка если нет файлов
            int fileId = Convert.ToInt32(gridViewFiles.GetRowCellValue(gridViewFiles.FocusedRowHandle, "Id").ToString());
            new PdfViewer(fileId).ShowDialog();
        }

        private void sButtonLoadFile_Click(object sender, EventArgs e)
        {
            new FileLoadForm().ShowDialog();
        }

       
    }
}
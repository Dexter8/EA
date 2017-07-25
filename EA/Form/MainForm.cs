using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;
using EA.Data;
using EA.Data.Enums;
using EA.Model;

namespace EA.Form
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<Folder> _folders = new List<Folder>();
        private List<Card> _cards = new List<Card>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            RefreshFolders();
        }

        //Обновить список папок
        private void RefreshFolders()
        {
            _folders = new FolderModel().GetFolders(_folders);
            treeListFolders.DataSource = _folders;
        }

        private void RefreshCards(int id)
        {
            gridViewCards.ShowLoadingPanel();
            _cards = new CardModel().GetCards(_cards, id);
            gridControlCards.DataSource = _cards;
            gridControlCards.RefreshDataSource();
            gridViewCards.HideLoadingPanel();
        }


        private void barButtonRefrashData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshFolders();
        }


        //Устанавливаем иконки для раскрытия/закрытия дерева
        //обратно меняются если убрать фокус!!!!
        #region
        private void treeListFolders_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            e.Node.StateImageIndex = 1;
        }

        private void treeListFolders_AfterCollapse(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            e.Node.StateImageIndex = 0;
        }

        private void treeListFolders_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            e.Node.StateImageIndex = 0;
        }

        #endregion

       
        private void treeListFolders_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int id = Convert.ToInt32(treeListFolders.FocusedNode.GetDisplayText(tcolId));
            RefreshCards(id);
        }

        private void barButtonCreateCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int folderId = Convert.ToInt32(treeListFolders.FocusedNode.GetDisplayText(tcolId));
            if (folderId == 0) return;
            new EditForm(CardEditModeEnum.New, 0, folderId).ShowDialog();
            RefreshCards(Convert.ToInt32(treeListFolders.FocusedNode.GetDisplayText(tcolId)));
        }

        private void barEditItem1_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string code = repositoryItemSearchControl1.GetDisplayText(barEditItem1.EditValue);
            if (string.IsNullOrEmpty(code)) return;
            if (code.Length < 2) return;

            _cards = new CardModel().GetCardsByCode(_cards, code);
            gridControlCards.DataSource = _cards;
            gridControlCards.RefreshDataSource();
        }

        private void gridViewCards_DoubleClick(object sender, EventArgs e)
        { try
            {
                int cardId = Convert.ToInt32(gridViewCards.GetRowCellValue(gridViewCards.FocusedRowHandle, "CardId").ToString());
                new EditForm(CardEditModeEnum.Edit, cardId, null).ShowDialog();
                RefreshCards(Convert.ToInt32(treeListFolders.FocusedNode.GetDisplayText(tcolId)));
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
            }
            
            /*int? folederId = Convert.ToInt32(treeListFolders.Get   //.GetRowCellValue(gridViewCards.FocusedRowHandle, "CardId").ToString());
            new EditForm(CardEditModeEnum.Edit, cardId).ShowDialog();*/
        }

        private void barButtonOpenSearchForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new SearchForm().ShowDialog();
        }

        private void barButtonCreateNewFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FolderEditForm().ShowDialog();
        }



        /// <summary>
        /// Вызов контекстного меню
        /// </summary>
        private void treeListFolders_MouseDown(object sender, MouseEventArgs e)
        {
            TreeListHitInfo hitInfo = treeListFolders.CalcHitInfo(e.Location);
            TreeListNode node = null;
            if (hitInfo.HitInfoType == HitInfoType.Cell)
            {
                node = hitInfo.Node;
            }
            if (node == null) return;
            //popupMenu1.ShowPopup(Cursor.Position);
        }

        private void barButtonDeleteCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using EA.Data;
using EA.Data.Enums;
using EA.Form.FileForm;
using EA.Model;
using EA.Models.SqlModels;
using Sqllib.AdoNetSqlService;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            repItemLookUpEditStatus.DataSource = new FileModel().GetStatusList();

            RefreshFolders();

        }

        private void GetData(int folderId)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(
                    "Provider=SQLNCLI10; Data Source=SQLSERVER; Initial Catalog=EA2015; Trusted_Connection=yes;");



                OleDbDataAdapter AdapterCards =
                    new OleDbDataAdapter(
                        $@"SELECT [id] as 'CardId',[folder_id],[card_type_id],[code] as 'Code',[name] as 'Name'
                                                                        ,[description],[create_user_id],[create_date] as 'CreateDate'
                                                                        ,[start_develop_date],[end_develop_date],[card_type_name] ,[status_name],[status_short_name]
                                                                        ,[exist_scan] as 'ExistScan', [exist_2d] as 'Exist2D', [exist_3d] as 'Exist3D'
                                                                        FROM [EA2015].[dbo].[View_Cards] where folder_id = {
                            folderId}", connection);

                OleDbDataAdapter AdapterFiles =
                    new OleDbDataAdapter(
                        $@"SELECT fc.[id] as 'Id' ,f.[id] as 'FolederId'
                                ,fc.[parent_id], fc.[card_id] as 'CardId'
                                , fc.[status_id] as 'StatusId'
                              , fc.[name] as 'Name'
                              , fc.[description] as 'Description'
                              , fc.[extention] as 'ExtentionName'
                              , fc.[size] as 'Size'
                              , fc.[upload_login] as 'UploadLogin'
                              , fc.[version] as 'FileVersion'
                              , fc.[last_edit_date]
                              , fc.[upload_date] as 'UploadDate'
                              , fc.[upload_reason]
                              , fc.[expire_date] as 'ExpireDate'
							  , fc.[file_content_id] as 'FileContentId'
							  , ft.[name] as 'FileTypeName'
							  , ft.[id] as 'FileTypeId'
                          FROM [EA2015].[dbo].[RFile] fc
                          LEFT JOIN [EA2015].[dbo].[CFileType] ft on ft.id = fc.file_type_id
						  LEFT JOIN [EA2015].[dbo].[Card] c on c.id = fc.card_id
						  LEFT JOIN [EA2015].[dbo].[RFolder] f on f.id = c.folder_id
						  AND NOT EXISTS(SELECT fc1.id FROM[EA2015].[dbo].[FileContent] fc1 WHERE fc1.parent_id = fc.id)
                            WHERE f.id = {folderId}", connection);


                DataSet dataSet11 = new DataSet();

                AdapterCards.Fill(dataSet11, "Cards");
                AdapterFiles.Fill(dataSet11, "Files");

                //Set up a master-detail relationship between the DataTables
                DataColumn keyColumn = dataSet11.Tables["Cards"].Columns["CardId"];
                DataColumn foreignKeyColumn = dataSet11.Tables["Files"].Columns["CardId"];
                dataSet11.Relations.Add("CardsFiles", keyColumn, foreignKeyColumn);

                //Bind the grid control to the data source
                gridControlCards.DataSource = dataSet11.Tables["Cards"];
                gridControlCards.ForceInitialize();

                //Assign a CardView to the relationship
                //GridView cardView1 = new GridView(gridControlCards);
                gridControlCards.LevelTree.Nodes.Add("CardsFiles", gridViewFiles);
                //Specify text to be displayed within detail tabs.
                gridViewFiles.ViewCaption = "Документы";

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                throw;
            }

        }



        //Обновить список папок
        private void RefreshFolders()
        {
            _folders = new FolderModel().GetFolders(_folders);
            treeListFolders.DataSource = _folders;
        }

        private void RefreshCards(int id)
        {
            /*gridViewCards.ShowLoadingPanel();
            _cards = new CardModel().GetCards(_cards, id);
            gridControlCards.DataSource = _cards;
            gridControlCards.RefreshDataSource();
            gridViewCards.HideLoadingPanel();*/

            GetData(id);
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
        {
            try
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

        private void gridControlCards_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridViewFiles_DoubleClick(object sender, EventArgs e)
        {

            //object masterValue = (gridViewFiles.SourceRow as DataRowView)["Id"];


            GridView view = (gridControlCards.FocusedView as GridView);
            object t = view.GetRowCellValue(0, view.Columns[0]);

            int fileId = Convert.ToInt32(view.GetFocusedRowCellValue("FileContentId"));



            //запись просмотра в журнал
            new FileViewSqlModel().SaveFileViewLog(0, fileId, 1);

            new PdfViewer(fileId).ShowDialog();
        }

        private void gridViewFiles_CustomDrawCell(object sender,
            DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {


        }

        private void gridViewFiles_CellValueChanged(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (gridControlCards.FocusedView as GridView);
            int fileId = Convert.ToInt32(view.GetFocusedRowCellValue("Id"));
            int? statusId = view.GetRowCellValue(0, view.Columns["StatusId"]) as int?;
        }

        private void barButtonExpandAllRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridViewFiles_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (gridControlCards.FocusedView as GridView);
            int fileId = Convert.ToInt32(view.GetFocusedRowCellValue("Id"));
            int? statusId = view.GetRowCellValue(0, view.Columns["StatusId"]) as int? ;
        }



        private void gridViewFiles_MouseDown(object sender, MouseEventArgs e)
        #region
        {

        }
        #endregion



        /// <summary>
        /// Вызов контекстного меню для файлов
        /// </summary>
        private void gridViewFiles_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                e.Allow = false;
                popupMenuFile.ShowPopup(gridControlCards.PointToScreen(e.Point));
            }
        }




        private void popupButtonSetStatusEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView view = (gridControlCards.FocusedView as GridView);
            int fileId = Convert.ToInt32(view.GetFocusedRowCellValue("Id"));
            new FileModel().ChangeFileStatus(fileId, FileStatus.Edit);
        }

        private void popupButtonSetStatusNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView view = (gridControlCards.FocusedView as GridView);
            int fileId = Convert.ToInt32(view.GetFocusedRowCellValue("Id"));
            new FileModel().ChangeFileStatus(fileId, FileStatus.New);
        }

        private void popupButtonSetStatusAproved_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView view = (gridControlCards.FocusedView as GridView);
            int fileId = Convert.ToInt32(view.GetFocusedRowCellValue("Id"));
            new FileModel().ChangeFileStatus(fileId, FileStatus.Approved);
        }

        private void barButtonShowFileStatusEditForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FileStatusEditForm().ShowDialog();
        }
    }
}
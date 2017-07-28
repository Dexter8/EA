namespace EA.Form
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonRefrashData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCreateCard = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEditCard = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDeleteCard = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCreateNewFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEditFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDeleteFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOpenSearchForm = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barButFolderProperty = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repItemButtonEditLiveSearch = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeListFolders = new DevExpress.XtraTreeList.TreeList();
            this.tcolId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcolParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcolName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.gridControlCards = new DevExpress.XtraGrid.GridControl();
            this.gridViewCards = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistScan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExist3D = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExist2D = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemButtonEditLiveSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMdiChildButtons = false;
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonRefrashData,
            this.barButtonCreateCard,
            this.barButtonEditCard,
            this.barButtonDeleteCard,
            this.barButtonCreateNewFolder,
            this.barButtonEditFolder,
            this.barButtonDeleteFolder,
            this.barButtonOpenSearchForm,
            this.barEditItem1,
            this.barButFolderProperty,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemButtonEditLiveSearch,
            this.repositoryItemSearchControl1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.Size = new System.Drawing.Size(1362, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonRefrashData
            // 
            this.barButtonRefrashData.Caption = "Обновить";
            this.barButtonRefrashData.Id = 1;
            this.barButtonRefrashData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonRefrashData.ImageOptions.Image")));
            this.barButtonRefrashData.ImageOptions.LargeImage = global::EA.Properties.Resources.refresh_update;
            this.barButtonRefrashData.Name = "barButtonRefrashData";
            this.barButtonRefrashData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRefrashData_ItemClick);
            // 
            // barButtonCreateCard
            // 
            this.barButtonCreateCard.Caption = "Создать";
            this.barButtonCreateCard.Id = 2;
            this.barButtonCreateCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonCreateCard.ImageOptions.Image")));
            this.barButtonCreateCard.ImageOptions.LargeImage = global::EA.Properties.Resources.order_add;
            this.barButtonCreateCard.Name = "barButtonCreateCard";
            this.barButtonCreateCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCreateCard_ItemClick);
            // 
            // barButtonEditCard
            // 
            this.barButtonEditCard.Caption = "Изменить";
            this.barButtonEditCard.Id = 3;
            this.barButtonEditCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonEditCard.ImageOptions.Image")));
            this.barButtonEditCard.ImageOptions.LargeImage = global::EA.Properties.Resources.order_edit;
            this.barButtonEditCard.Name = "barButtonEditCard";
            // 
            // barButtonDeleteCard
            // 
            this.barButtonDeleteCard.Caption = "Удалить";
            this.barButtonDeleteCard.Id = 4;
            this.barButtonDeleteCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDeleteCard.ImageOptions.Image")));
            this.barButtonDeleteCard.ImageOptions.LargeImage = global::EA.Properties.Resources.order_delete;
            this.barButtonDeleteCard.Name = "barButtonDeleteCard";
            this.barButtonDeleteCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDeleteCard_ItemClick);
            // 
            // barButtonCreateNewFolder
            // 
            this.barButtonCreateNewFolder.Caption = "Новая папка";
            this.barButtonCreateNewFolder.Id = 5;
            this.barButtonCreateNewFolder.ImageOptions.LargeImage = global::EA.Properties.Resources.folder_add;
            this.barButtonCreateNewFolder.Name = "barButtonCreateNewFolder";
            this.barButtonCreateNewFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCreateNewFolder_ItemClick);
            // 
            // barButtonEditFolder
            // 
            this.barButtonEditFolder.Caption = "Изменить папку";
            this.barButtonEditFolder.Id = 6;
            this.barButtonEditFolder.ImageOptions.LargeImage = global::EA.Properties.Resources.folder_edit;
            this.barButtonEditFolder.Name = "barButtonEditFolder";
            // 
            // barButtonDeleteFolder
            // 
            this.barButtonDeleteFolder.Caption = "Удалить папку";
            this.barButtonDeleteFolder.Id = 7;
            this.barButtonDeleteFolder.ImageOptions.LargeImage = global::EA.Properties.Resources.folder_delete;
            this.barButtonDeleteFolder.Name = "barButtonDeleteFolder";
            // 
            // barButtonOpenSearchForm
            // 
            this.barButtonOpenSearchForm.Caption = "Поиск";
            this.barButtonOpenSearchForm.Id = 8;
            this.barButtonOpenSearchForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOpenSearchForm.ImageOptions.Image")));
            this.barButtonOpenSearchForm.ImageOptions.LargeImage = global::EA.Properties.Resources.search;
            this.barButtonOpenSearchForm.Name = "barButtonOpenSearchForm";
            this.barButtonOpenSearchForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonOpenSearchForm_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemSearchControl1;
            this.barEditItem1.EditWidth = 120;
            this.barEditItem1.Id = 11;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem1_ItemPress);
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // barButFolderProperty
            // 
            this.barButFolderProperty.Caption = "Свойства";
            this.barButFolderProperty.Id = 12;
            this.barButFolderProperty.ImageOptions.Image = global::EA.Properties.Resources.folder_info;
            this.barButFolderProperty.Name = "barButFolderProperty";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Настройка доступа";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.ImageOptions.Image = global::EA.Properties.Resources.list_key;
            this.barButtonItem1.ImageOptions.LargeImage = global::EA.Properties.Resources.list_key;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Журнал просмотров";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.ImageOptions.LargeImage = global::EA.Properties.Resources.list_user;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Главная";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonRefrashData);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonCreateCard);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonEditCard);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonDeleteCard);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonCreateNewFolder);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonEditFolder);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonDeleteFolder);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonOpenSearchForm);
            this.ribbonPageGroup4.ItemLinks.Add(this.barEditItem1, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Администрирование";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // repItemButtonEditLiveSearch
            // 
            this.repItemButtonEditLiveSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repItemButtonEditLiveSearch.Appearance.Options.UseFont = true;
            this.repItemButtonEditLiveSearch.AutoHeight = false;
            this.repItemButtonEditLiveSearch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.repItemButtonEditLiveSearch.Name = "repItemButtonEditLiveSearch";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 544);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1362, 31);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 143);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListFolders);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlCards);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1362, 401);
            this.splitContainerControl1.SplitterPosition = 330;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeListFolders
            // 
            this.treeListFolders.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tcolId,
            this.tcolParentId,
            this.tcolName});
            this.treeListFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListFolders.KeyFieldName = "Id";
            this.treeListFolders.Location = new System.Drawing.Point(0, 0);
            this.treeListFolders.Name = "treeListFolders";
            this.treeListFolders.OptionsBehavior.Editable = false;
            this.treeListFolders.OptionsBehavior.ReadOnly = true;
            this.treeListFolders.OptionsView.ShowColumns = false;
            this.treeListFolders.ParentFieldName = "ParentId";
            this.treeListFolders.Size = new System.Drawing.Size(330, 401);
            this.treeListFolders.StateImageList = this.imageCollection1;
            this.treeListFolders.TabIndex = 0;
            this.treeListFolders.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeListFolders_GetStateImage);
            this.treeListFolders.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListFolders_AfterExpand);
            this.treeListFolders.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListFolders_AfterCollapse);
            this.treeListFolders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeListFolders_MouseClick);
            this.treeListFolders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListFolders_MouseDown);
            // 
            // tcolId
            // 
            this.tcolId.Caption = "Id";
            this.tcolId.FieldName = "Id";
            this.tcolId.Name = "tcolId";
            // 
            // tcolParentId
            // 
            this.tcolParentId.Caption = "ParentId";
            this.tcolParentId.FieldName = "ParentId";
            this.tcolParentId.Name = "tcolParentId";
            this.tcolParentId.OptionsColumn.AllowEdit = false;
            this.tcolParentId.OptionsColumn.AllowFocus = false;
            this.tcolParentId.OptionsColumn.AllowMove = false;
            this.tcolParentId.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.tcolParentId.OptionsColumn.ReadOnly = true;
            // 
            // tcolName
            // 
            this.tcolName.Caption = "Название";
            this.tcolName.FieldName = "Name";
            this.tcolName.MinWidth = 34;
            this.tcolName.Name = "tcolName";
            this.tcolName.OptionsColumn.AllowEdit = false;
            this.tcolName.OptionsColumn.AllowFocus = false;
            this.tcolName.OptionsColumn.AllowMove = false;
            this.tcolName.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.tcolName.OptionsColumn.ReadOnly = true;
            this.tcolName.Visible = true;
            this.tcolName.VisibleIndex = 0;
            this.tcolName.Width = 156;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "folder.png");
            this.imageCollection1.Images.SetKeyName(1, "folder_open.png");
            // 
            // gridControlCards
            // 
            this.gridControlCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCards.Location = new System.Drawing.Point(0, 0);
            this.gridControlCards.MainView = this.gridViewCards;
            this.gridControlCards.MenuManager = this.ribbon;
            this.gridControlCards.Name = "gridControlCards";
            this.gridControlCards.Size = new System.Drawing.Size(1027, 401);
            this.gridControlCards.TabIndex = 0;
            this.gridControlCards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCards});
            // 
            // gridViewCards
            // 
            this.gridViewCards.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTypeName,
            this.colCode,
            this.colName,
            this.colCreateDate,
            this.colExistScan,
            this.colExist3D,
            this.colExist2D});
            this.gridViewCards.GridControl = this.gridControlCards;
            this.gridViewCards.Name = "gridViewCards";
            this.gridViewCards.OptionsView.ShowGroupPanel = false;
            this.gridViewCards.DoubleClick += new System.EventHandler(this.gridViewCards_DoubleClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "CardId";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colTypeName
            // 
            this.colTypeName.Caption = "Тип";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.MaxWidth = 120;
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.OptionsColumn.AllowEdit = false;
            this.colTypeName.OptionsColumn.AllowFocus = false;
            this.colTypeName.OptionsColumn.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.Caption = "Обозначение";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.OptionsColumn.AllowFocus = false;
            this.colCode.OptionsColumn.ReadOnly = true;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Название";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Дата создания";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.MaxWidth = 90;
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.OptionsColumn.AllowFocus = false;
            this.colCreateDate.OptionsColumn.ReadOnly = true;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 2;
            // 
            // colExistScan
            // 
            this.colExistScan.Caption = "Скан";
            this.colExistScan.FieldName = "ExistScan";
            this.colExistScan.MaxWidth = 35;
            this.colExistScan.Name = "colExistScan";
            this.colExistScan.OptionsColumn.AllowEdit = false;
            this.colExistScan.OptionsColumn.AllowFocus = false;
            this.colExistScan.OptionsColumn.ReadOnly = true;
            this.colExistScan.Visible = true;
            this.colExistScan.VisibleIndex = 3;
            this.colExistScan.Width = 25;
            // 
            // colExist3D
            // 
            this.colExist3D.Caption = "3D";
            this.colExist3D.FieldName = "Exist3D";
            this.colExist3D.MaxWidth = 35;
            this.colExist3D.Name = "colExist3D";
            this.colExist3D.OptionsColumn.AllowEdit = false;
            this.colExist3D.OptionsColumn.AllowFocus = false;
            this.colExist3D.OptionsColumn.ReadOnly = true;
            this.colExist3D.Visible = true;
            this.colExist3D.VisibleIndex = 4;
            this.colExist3D.Width = 25;
            // 
            // colExist2D
            // 
            this.colExist2D.Caption = "2D";
            this.colExist2D.FieldName = "Exist2D";
            this.colExist2D.MaxWidth = 35;
            this.colExist2D.Name = "colExist2D";
            this.colExist2D.OptionsColumn.AllowEdit = false;
            this.colExist2D.OptionsColumn.AllowFocus = false;
            this.colExist2D.OptionsColumn.ReadOnly = true;
            this.colExist2D.Visible = true;
            this.colExist2D.VisibleIndex = 5;
            this.colExist2D.Width = 20;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButFolderProperty);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 575);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Электронный архив чертежей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemButtonEditLiveSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonRefrashData;
        private DevExpress.XtraBars.BarButtonItem barButtonCreateCard;
        private DevExpress.XtraBars.BarButtonItem barButtonEditCard;
        private DevExpress.XtraBars.BarButtonItem barButtonDeleteCard;
        private DevExpress.XtraBars.BarButtonItem barButtonCreateNewFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonEditFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonDeleteFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonOpenSearchForm;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeListFolders;
        private DevExpress.XtraGrid.GridControl gridControlCards;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCards;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcolId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcolParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcolName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repItemButtonEditLiveSearch;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colExistScan;
        private DevExpress.XtraGrid.Columns.GridColumn colExist3D;
        private DevExpress.XtraGrid.Columns.GridColumn colExist2D;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraBars.BarButtonItem barButFolderProperty;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}
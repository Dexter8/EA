namespace EA.Form.CardForm
{
    partial class AttachCardForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonSearchCard = new DevExpress.XtraEditors.SimpleButton();
            this.textEditCardCode = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
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
            this.buttonAttachCard = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.buttonSearchCard);
            this.groupControl1.Controls.Add(this.textEditCardCode);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 54);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Поиск";
            // 
            // buttonSearchCard
            // 
            this.buttonSearchCard.Location = new System.Drawing.Point(194, 23);
            this.buttonSearchCard.Name = "buttonSearchCard";
            this.buttonSearchCard.Size = new System.Drawing.Size(75, 25);
            this.buttonSearchCard.TabIndex = 1;
            this.buttonSearchCard.Text = "Поиск";
            this.buttonSearchCard.Click += new System.EventHandler(this.buttonSearchCard_Click);
            // 
            // textEditCardCode
            // 
            this.textEditCardCode.Location = new System.Drawing.Point(6, 24);
            this.textEditCardCode.Name = "textEditCardCode";
            this.textEditCardCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditCardCode.Properties.Appearance.Options.UseFont = true;
            this.textEditCardCode.Size = new System.Drawing.Size(182, 24);
            this.textEditCardCode.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlCards);
            this.groupControl2.Location = new System.Drawing.Point(12, 72);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(760, 300);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Результаты поиска";
            // 
            // gridControlCards
            // 
            this.gridControlCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCards.Location = new System.Drawing.Point(2, 20);
            this.gridControlCards.MainView = this.gridViewCards;
            this.gridControlCards.Name = "gridControlCards";
            this.gridControlCards.Size = new System.Drawing.Size(756, 278);
            this.gridControlCards.TabIndex = 1;
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
            this.colId.Visible = true;
            this.colId.VisibleIndex = 6;
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
            // buttonAttachCard
            // 
            this.buttonAttachCard.Location = new System.Drawing.Point(12, 378);
            this.buttonAttachCard.Name = "buttonAttachCard";
            this.buttonAttachCard.Size = new System.Drawing.Size(95, 25);
            this.buttonAttachCard.TabIndex = 1;
            this.buttonAttachCard.Text = "Присоединить";
            this.buttonAttachCard.Click += new System.EventHandler(this.buttonAttachCard_Click);
            // 
            // AttachCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.buttonAttachCard);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachCardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Присоединить документ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton buttonSearchCard;
        private DevExpress.XtraEditors.TextEdit textEditCardCode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton buttonAttachCard;
        private DevExpress.XtraGrid.GridControl gridControlCards;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCards;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExistScan;
        private DevExpress.XtraGrid.Columns.GridColumn colExist3D;
        private DevExpress.XtraGrid.Columns.GridColumn colExist2D;
    }
}
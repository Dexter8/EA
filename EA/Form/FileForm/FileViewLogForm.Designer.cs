namespace EA.Form.FileForm
{
    partial class FileViewLogForm
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
            this.gridControlFileViewLog = new DevExpress.XtraGrid.GridControl();
            this.fileViewLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewFileViewLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCardId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFileViewLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileViewLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFileViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlFileViewLog
            // 
            this.gridControlFileViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFileViewLog.Location = new System.Drawing.Point(0, 0);
            this.gridControlFileViewLog.MainView = this.gridViewFileViewLog;
            this.gridControlFileViewLog.Name = "gridControlFileViewLog";
            this.gridControlFileViewLog.Size = new System.Drawing.Size(630, 548);
            this.gridControlFileViewLog.TabIndex = 0;
            this.gridControlFileViewLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFileViewLog});
            // 
            // fileViewLogBindingSource
            // 
            this.fileViewLogBindingSource.DataSource = typeof(EA.Data.FileViewLog);
            // 
            // gridViewFileViewLog
            // 
            this.gridViewFileViewLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCardId,
            this.colFileId,
            this.colFileName,
            this.colUserLogin,
            this.colMachineName,
            this.colDate});
            this.gridViewFileViewLog.GridControl = this.gridControlFileViewLog;
            this.gridViewFileViewLog.Name = "gridViewFileViewLog";
            this.gridViewFileViewLog.OptionsView.ShowGroupPanel = false;
            // 
            // colCardId
            // 
            this.colCardId.FieldName = "CardId";
            this.colCardId.Name = "colCardId";
            // 
            // colFileId
            // 
            this.colFileId.FieldName = "FileId";
            this.colFileId.Name = "colFileId";
            // 
            // colFileName
            // 
            this.colFileName.Caption = "Название документа";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 200;
            // 
            // colUserLogin
            // 
            this.colUserLogin.Caption = "Логин";
            this.colUserLogin.FieldName = "UserLogin";
            this.colUserLogin.Name = "colUserLogin";
            this.colUserLogin.Visible = true;
            this.colUserLogin.VisibleIndex = 1;
            this.colUserLogin.Width = 136;
            // 
            // colMachineName
            // 
            this.colMachineName.Caption = "Имя компьютера";
            this.colMachineName.FieldName = "MachineName";
            this.colMachineName.Name = "colMachineName";
            this.colMachineName.Visible = true;
            this.colMachineName.VisibleIndex = 2;
            this.colMachineName.Width = 136;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 140;
            // 
            // FileViewLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 548);
            this.Controls.Add(this.gridControlFileViewLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileViewLogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал просмотра документов";
            this.Load += new System.EventHandler(this.FileViewLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFileViewLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileViewLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFileViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFileViewLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFileViewLog;
        private System.Windows.Forms.BindingSource fileViewLogBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCardId;
        private DevExpress.XtraGrid.Columns.GridColumn colFileId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colMachineName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
    }
}
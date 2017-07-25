namespace EA.Form
{
    partial class FileLoadForm
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
            this.buttonEditFilePath = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditFileName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditFileDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditFileType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUploadDate = new DevExpress.XtraEditors.TextEdit();
            this.textEditUploadUserLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.buttonUploadFile = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFileExtension = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEditFileSize = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditExpireDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDraftTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEditVersion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditStatus = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditFileDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFileType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUploadDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUploadUserLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFileExtension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFileSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpireDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpireDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDraftTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditFilePath
            // 
            this.buttonEditFilePath.Location = new System.Drawing.Point(134, 16);
            this.buttonEditFilePath.Name = "buttonEditFilePath";
            this.buttonEditFilePath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditFilePath.Properties.Appearance.Options.UseFont = true;
            this.buttonEditFilePath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditFilePath.Properties.ReadOnly = true;
            this.buttonEditFilePath.Size = new System.Drawing.Size(588, 22);
            this.buttonEditFilePath.TabIndex = 0;
            this.buttonEditFilePath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditFilePath_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Путь к файлу";
            // 
            // textEditFileName
            // 
            this.textEditFileName.Location = new System.Drawing.Point(134, 44);
            this.textEditFileName.Name = "textEditFileName";
            this.textEditFileName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditFileName.Properties.Appearance.Options.UseFont = true;
            this.textEditFileName.Size = new System.Drawing.Size(588, 22);
            this.textEditFileName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Название";
            // 
            // memoEditFileDescription
            // 
            this.memoEditFileDescription.Location = new System.Drawing.Point(134, 72);
            this.memoEditFileDescription.Name = "memoEditFileDescription";
            this.memoEditFileDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoEditFileDescription.Properties.Appearance.Options.UseFont = true;
            this.memoEditFileDescription.Size = new System.Drawing.Size(588, 76);
            this.memoEditFileDescription.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Описание";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 269);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(116, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Формат чертежа";
            // 
            // lookUpEditFileType
            // 
            this.lookUpEditFileType.Location = new System.Drawing.Point(134, 154);
            this.lookUpEditFileType.Name = "lookUpEditFileType";
            this.lookUpEditFileType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookUpEditFileType.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditFileType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFileType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpEditFileType.Properties.DisplayMember = "Name";
            this.lookUpEditFileType.Properties.NullText = "";
            this.lookUpEditFileType.Properties.ShowFooter = false;
            this.lookUpEditFileType.Properties.ShowHeader = false;
            this.lookUpEditFileType.Properties.ValueMember = "Id";
            this.lookUpEditFileType.Size = new System.Drawing.Size(124, 22);
            this.lookUpEditFileType.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 16);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Тип документа";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(461, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 16);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Дата загрузки";
            // 
            // textEditUploadDate
            // 
            this.textEditUploadDate.Location = new System.Drawing.Point(563, 154);
            this.textEditUploadDate.Name = "textEditUploadDate";
            this.textEditUploadDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditUploadDate.Properties.Appearance.Options.UseFont = true;
            this.textEditUploadDate.Properties.ReadOnly = true;
            this.textEditUploadDate.Size = new System.Drawing.Size(159, 22);
            this.textEditUploadDate.TabIndex = 8;
            // 
            // textEditUploadUserLogin
            // 
            this.textEditUploadUserLogin.Location = new System.Drawing.Point(563, 181);
            this.textEditUploadUserLogin.Name = "textEditUploadUserLogin";
            this.textEditUploadUserLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditUploadUserLogin.Properties.Appearance.Options.UseFont = true;
            this.textEditUploadUserLogin.Properties.ReadOnly = true;
            this.textEditUploadUserLogin.Size = new System.Drawing.Size(159, 22);
            this.textEditUploadUserLogin.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(496, 184);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 16);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Загрузил";
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUploadFile.Appearance.Options.UseFont = true;
            this.buttonUploadFile.Location = new System.Drawing.Point(9, 319);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(116, 30);
            this.buttonUploadFile.TabIndex = 9;
            this.buttonUploadFile.Text = "Загрузить";
            this.buttonUploadFile.Click += new System.EventHandler(this.buttonUploadFile_Click_1);
            // 
            // textEditFileExtension
            // 
            this.textEditFileExtension.Location = new System.Drawing.Point(134, 266);
            this.textEditFileExtension.Name = "textEditFileExtension";
            this.textEditFileExtension.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditFileExtension.Properties.Appearance.Options.UseFont = true;
            this.textEditFileExtension.Properties.ReadOnly = true;
            this.textEditFileExtension.Size = new System.Drawing.Size(124, 22);
            this.textEditFileExtension.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 297);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 16);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Размер";
            // 
            // textEditFileSize
            // 
            this.textEditFileSize.Location = new System.Drawing.Point(134, 294);
            this.textEditFileSize.Name = "textEditFileSize";
            this.textEditFileSize.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditFileSize.Properties.Appearance.Options.UseFont = true;
            this.textEditFileSize.Properties.ReadOnly = true;
            this.textEditFileSize.Size = new System.Drawing.Size(124, 22);
            this.textEditFileSize.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(12, 213);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(113, 16);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Действитетен до";
            // 
            // dateEditExpireDate
            // 
            this.dateEditExpireDate.EditValue = null;
            this.dateEditExpireDate.Location = new System.Drawing.Point(134, 210);
            this.dateEditExpireDate.Name = "dateEditExpireDate";
            this.dateEditExpireDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditExpireDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditExpireDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditExpireDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditExpireDate.Size = new System.Drawing.Size(124, 22);
            this.dateEditExpireDate.TabIndex = 11;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(12, 184);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(86, 16);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "Тип чертежа";
            // 
            // lookUpEditDraftTypes
            // 
            this.lookUpEditDraftTypes.Location = new System.Drawing.Point(134, 182);
            this.lookUpEditDraftTypes.Name = "lookUpEditDraftTypes";
            this.lookUpEditDraftTypes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookUpEditDraftTypes.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditDraftTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDraftTypes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpEditDraftTypes.Properties.DisplayMember = "Name";
            this.lookUpEditDraftTypes.Properties.NullText = "";
            this.lookUpEditDraftTypes.Properties.ShowFooter = false;
            this.lookUpEditDraftTypes.Properties.ShowHeader = false;
            this.lookUpEditDraftTypes.Properties.ValueMember = "Id";
            this.lookUpEditDraftTypes.Size = new System.Drawing.Size(124, 22);
            this.lookUpEditDraftTypes.TabIndex = 12;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(511, 212);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 16);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "Версия";
            // 
            // textEditVersion
            // 
            this.textEditVersion.Location = new System.Drawing.Point(563, 209);
            this.textEditVersion.Name = "textEditVersion";
            this.textEditVersion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditVersion.Properties.Appearance.Options.UseFont = true;
            this.textEditVersion.Properties.ReadOnly = true;
            this.textEditVersion.Size = new System.Drawing.Size(27, 22);
            this.textEditVersion.TabIndex = 8;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(12, 241);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 16);
            this.labelControl12.TabIndex = 3;
            this.labelControl12.Text = "Статус";
            // 
            // lookUpEditStatus
            // 
            this.lookUpEditStatus.Location = new System.Drawing.Point(134, 238);
            this.lookUpEditStatus.Name = "lookUpEditStatus";
            this.lookUpEditStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookUpEditStatus.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpEditStatus.Properties.DisplayMember = "Name";
            this.lookUpEditStatus.Properties.NullText = "";
            this.lookUpEditStatus.Properties.ShowFooter = false;
            this.lookUpEditStatus.Properties.ShowHeader = false;
            this.lookUpEditStatus.Properties.ValueMember = "Id";
            this.lookUpEditStatus.Size = new System.Drawing.Size(124, 22);
            this.lookUpEditStatus.TabIndex = 12;
            // 
            // FileLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 358);
            this.Controls.Add(this.lookUpEditStatus);
            this.Controls.Add(this.lookUpEditDraftTypes);
            this.Controls.Add(this.dateEditExpireDate);
            this.Controls.Add(this.textEditFileSize);
            this.Controls.Add(this.textEditFileExtension);
            this.Controls.Add(this.buttonUploadFile);
            this.Controls.Add(this.textEditVersion);
            this.Controls.Add(this.textEditUploadUserLogin);
            this.Controls.Add(this.textEditUploadDate);
            this.Controls.Add(this.lookUpEditFileType);
            this.Controls.Add(this.memoEditFileDescription);
            this.Controls.Add(this.textEditFileName);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.buttonEditFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileLoadForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка нового документа";
            this.Load += new System.EventHandler(this.FileLoadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditFileDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFileType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUploadDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUploadUserLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFileExtension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFileSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpireDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExpireDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDraftTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ButtonEdit buttonEditFilePath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditFileName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEditFileDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFileType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditUploadDate;
        private DevExpress.XtraEditors.TextEdit textEditUploadUserLogin;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton buttonUploadFile;
        private DevExpress.XtraEditors.TextEdit textEditFileExtension;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEditFileSize;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dateEditExpireDate;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDraftTypes;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEditVersion;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStatus;
    }
}
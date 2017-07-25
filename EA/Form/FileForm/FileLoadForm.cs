using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EA.Data;
using EA.Model;

namespace EA.Form
{
    public partial class FileLoadForm : XtraForm
    {
        private readonly int _cardId;
        private readonly int? _fileId;
        private readonly Data.Enums.FileMode _mode;
        private int? _version;

        public FileLoadForm(int cardId, int? fileId, Data.Enums.FileMode mode)
        {
            _cardId = cardId;
            _fileId = fileId;
            _mode = mode;
            InitializeComponent();
        }

        private void FileLoadForm_Load(object sender, EventArgs e)
        {
            lookUpEditFileType.Properties.DataSource = new FileModel().GetFileTypes();
            lookUpEditDraftTypes.Properties.DataSource = new DrawingModel().GetDraftTypes();
            lookUpEditStatus.Properties.DataSource = new FileModel().GetStatusList();

            if (_mode == Data.Enums.FileMode.New)
            {
                this.Text = @"Загрузка нового документа";
            }
            else if (_mode == Data.Enums.FileMode.UpdateVersion)
            {
                this.Text = @"Обновление документа";
                if (_fileId == null) return;

                FileData data = new FileModel().GetFileData(_fileId.Value);
                if (data.Version == null) _version = 2;
                else _version = data.Version + 1;
            }
        }

        private void buttonEditFilePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        #region
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    buttonEditFilePath.Text = dlg.FileName;
                    textEditFileExtension.Text = Path.GetExtension(dlg.FileName);
                    textEditFileSize.Text = (new FileInfo(dlg.FileName).Length / 1024) + @" Кб";
                    textEditFileName.Text = Path.GetFileNameWithoutExtension(dlg.FileName);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        #endregion


        #region ReadFile()
        public byte[] ReadFile(string filePatch)
        {
            byte[] buffer;
            FileStream fileStream = new FileStream(filePatch, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;
                buffer = new byte[length];
                int count;
                int sum = 0;

                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;

                return buffer;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }


        #endregion

        private void buttonUploadFile_Click_1(object sender, EventArgs e)
        {
            FileData fileData = new FileData();
            fileData.UId = Guid.NewGuid();
            fileData.Name = textEditFileName.Text;
            fileData.Description = memoEditFileDescription.Text;
            fileData.StatusId = lookUpEditStatus.EditValue as int?;
            fileData.Content = ReadFile(buttonEditFilePath.Text);
            fileData.Size = new FileInfo(buttonEditFilePath.Text).Length.ToString();
            fileData.ExtensionName = textEditFileExtension.Text;
            fileData.CardId = _cardId;
            fileData.Owner = Environment.UserName;
            fileData.ExpireDate = dateEditExpireDate.EditValue as DateTime?;
            fileData.FileTypeId = lookUpEditFileType.EditValue as int?;
            fileData.DraftTypeId = lookUpEditDraftTypes.EditValue as int?;
            fileData.ParentId = _fileId;

            if (_mode == Data.Enums.FileMode.New) fileData.Version = 1;
            else fileData.Version = _version;

            RefreshEditros(new FileModel().GetFileData(new FileModel().UploadFileToSql(fileData)));
        }



        private void RefreshEditros(FileData data)
        {
            textEditFileName.Text = data.Name;
            memoEditFileDescription.Text = data.Description;
            lookUpEditFileType.EditValue = data.FileTypeId;
            textEditFileExtension.Text = data.ExtensionName;
            dateEditExpireDate.EditValue = data.ExpireDate;
            lookUpEditDraftTypes.EditValue = data.DraftTypeId;
            textEditVersion.EditValue = data.Version;
            textEditUploadUserLogin.Text = data.Owner;
            textEditUploadDate.Text = data.UploadDate + "";
            


        }
        
    }
}
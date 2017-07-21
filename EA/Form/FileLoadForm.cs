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

        public FileLoadForm(int cardId)
        {
            _cardId = cardId;
            InitializeComponent();
        }

        private void FileLoadForm_Load(object sender, EventArgs e)
        {
            lookUpEditDocumentType.Properties.DataSource = new FileModel().GetFileTypes();
            lookUpEditDraftTypes.Properties.DataSource = new DrawingModel().GetDraftTypes();
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
            fileData.ExtensionId = lookUpEditDocumentType.EditValue as int?;
            fileData.FileType = lookUpEditDocumentType.EditValue as int?;
            fileData.Content = ReadFile(buttonEditFilePath.Text);
            fileData.Size = new FileInfo(buttonEditFilePath.Text).Length.ToString();
            fileData.ExtensionName = textEditFileExtension.Text;
            fileData.CardId = _cardId;
            fileData.Owner = Environment.UserName;
            fileData.ExpireDate = dateEditExpireDate.EditValue as DateTime?;
            fileData.DraftTypeId = lookUpEditDraftTypes.EditValue as int?;
            if (_cardId == 0) return;
            new FileModel().UploadFileToSql(fileData);
        }

        
    }
}
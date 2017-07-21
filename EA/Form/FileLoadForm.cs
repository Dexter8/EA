using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EA.Data;

namespace EA.Form
{
    public partial class FileLoadForm : XtraForm
    {
        public FileLoadForm()
        {
            InitializeComponent();
        }


        private void buttonEditFilePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        #region
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    buttonEditFilePath.Text = dlg.FileName;
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
            fileData.ExtensionId = lookUpEditFileExtention.EditValue as int?;
            fileData.Content = ReadFile(buttonEditFilePath.Text);
            fileData.Size = new FileInfo(buttonEditFilePath.Text).Length.ToString();
        }
    }
}
using System;
using EA.Models.SqlModels;

namespace EA.Form.FileForm
{
    public partial class FileViewLogForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly int _cardId;

        public FileViewLogForm(int cardId)
        {
            _cardId = cardId;
            InitializeComponent();
        }

        private void FileViewLogForm_Load(object sender, EventArgs e)
        {
            gridControlFileViewLog.DataSource = new FileViewSqlModel().GetFileViewLog(_cardId);
        }
    }
}
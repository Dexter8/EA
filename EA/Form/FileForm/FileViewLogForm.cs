using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EA.Form.FileForm
{
    public partial class FileStatusEditForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly int _folderId;

        public FileStatusEditForm(int folderId)
        {
            _folderId = folderId;
            InitializeComponent();
        }
    }
}
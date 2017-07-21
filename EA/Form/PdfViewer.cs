using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EA.Model;

namespace EA.Form
{
    public partial class PdfViewer : DevExpress.XtraEditors.XtraForm
    {
        private readonly int _fileId;

        public PdfViewer(int fileId)
        {
            _fileId = fileId;
            InitializeComponent();
        }

        private void PdfViewer_Load(object sender, EventArgs e)
        {
            this.pdfViewer1.LoadDocument(new FileModel().GetFileStream(_fileId));
        }

        private void PdfViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //GC.WaitForPendingFinalizers();
            //GC.Collect();
        }
    }
}
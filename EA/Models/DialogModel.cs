using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EA.Model;

namespace EA.Models
{
    public class DialogModel
    {
        public bool ShowYesNoMessageBox(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = XtraMessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            return false;
            ;
        }
    }
}

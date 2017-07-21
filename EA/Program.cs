using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EA.Form;
using EA.Model.SqlModels;

namespace EA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*if ()

            if (new RegisterUserSqlModel().RegisterUserInSql())*/

            DevExpress.Skins.SkinManager.EnableFormSkins();
            /*System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");*/
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

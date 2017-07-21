using System;
using System.Data;
using DevExpress.XtraEditors;
using EA.Data.StaticData;
using Sqllib.AdoNetSqlService;

namespace EA.Models.SqlModels
{
    public class UserSqlModel
    {
        public bool GetUserData()
        #region

        {
            string query = $@"SELECT [id], [login], [registration_date], [computer_name] FROM [EA2015].[dbo].[RUser] where login = {Environment.UserName.ToLower()}";
            DataTable table = new DataTable();

            try
            {
                table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());

                if (table.Rows.Count == 0) return false;

                if (table.Rows.Count > 1)
                {
                    XtraMessageBox.Show("Ошибка регистрации пользователя");
                    return false;
                }

                DataRow row = table.Rows[0];

                UserStaticData.UserId = Convert.ToInt32(row[""]);
                UserStaticData.UserLogin = row["login"] as string;

                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
    }
}

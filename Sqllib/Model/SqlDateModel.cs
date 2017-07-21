using System;
using System.Windows.Forms;
using Sqllib.AdoNetSqlService;

namespace Sqllib.Model
{
    public class SqlDateModel
    {
        /// <summary>
        /// Получить текущую дату от SQL сервера
        /// </summary>
        /// <returns></returns>
        public DateTime? GetCurrentDate()
        {
            try
            {
                string query = "SELECT (GETDATE())";
                var date = new SqlHealper().ExecuteScalar(query, new SqlConnectionString().GetWinAuthConnectionString());
                return Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}

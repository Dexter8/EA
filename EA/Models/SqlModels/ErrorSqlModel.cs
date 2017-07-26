using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using Sqllib.AdoNetSqlService;

namespace EA.Model
{
    public class ErrorSqlModel
    {
        /// <summary>
        /// Записать ошибку в базе данных
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool WriteErrorOnSql(Exception exeption)
        #region

        {
            XtraMessageBox.Show(exeption.Message);

            try
            {
                using (var connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    connection.Open();

                    var cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText =
                        "INSERT INTO[EA2015].[dbo].[JUserError] (error_content, error_description, user_login, version) VALUES(@errorContent, @errorDescription, @user_login, @version)";

                    cmd.Parameters.AddWithValue("@user_login", Environment.UserName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@version", Environment.Version ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@errorDescription", exeption.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@errorContent", exeption.Message ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();

                    return true;
                }
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

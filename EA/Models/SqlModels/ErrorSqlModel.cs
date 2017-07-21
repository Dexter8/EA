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
                        "INSERT INTO[EA2015].[dbo].[JUserError] (error_content, error_description, user_id) VALUES(@errorContent, @errorDescription, 1)";

                    var param = new SqlParameter();
                    param.ParameterName = "@user_id";
                    param.Value = 1;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@errorContent";
                    param.Value = exeption.Message;
                    param.SqlDbType = SqlDbType.NVarChar;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@errorDescription";
                    param.Value = exeption.ToString();
                    param.SqlDbType = SqlDbType.NVarChar;
                    cmd.Parameters.Add(param);

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

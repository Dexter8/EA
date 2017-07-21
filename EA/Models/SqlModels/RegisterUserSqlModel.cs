using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using Sqllib.AdoNetSqlService;

namespace EA.Model.SqlModels
{
    public class RegisterUserSqlModel
    {
        /// <summary>
        /// Регистрация пользователя в программе
        /// </summary>
        /// <returns></returns>
        public int RegisterUserInSql()
        #region
        {
            try
            {
                using (var connection = new SqlConnection(new SqlConnectionString().GetConnectionString()))
                {
                    connection.Open();

                    var cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "[dbo].[SP_RegisterUser]";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var param = new SqlParameter();
                    param.ParameterName = "@login";
                    param.Value = Environment.UserName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@domen";
                    param.Value = Environment.UserDomainName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@computer_name";
                    param.Value = Environment.MachineName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    cmd.Parameters.Add(param);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return 0;
            }   
        }
        #endregion
    }
}

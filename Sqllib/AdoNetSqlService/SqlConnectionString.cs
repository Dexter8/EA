using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sqllib.AdoNetSqlService
{
    public class SqlConnectionString
    {
        private readonly string DataSource = @"SQLSERVER";
        private const string InitialCatalog = "EA2015";
        private const int ConnectTimeout = 30;

        /// <summary>
        /// Строка подключения к БД OPTPP
        /// </summary>
        public string GetConnectionString()
        #region
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = DataSource;
            stringBuilder.InitialCatalog = InitialCatalog;
            stringBuilder.IntegratedSecurity = false;
            stringBuilder.ConnectTimeout = ConnectTimeout;
            stringBuilder.UserID = "eauser";
            //stringBuilder.Password = "5798643";
            return stringBuilder.ConnectionString;
        }
        #endregion


        /// <summary>
        /// Строка подключения к БД OPTPP с win-авторизацией
        /// </summary>
        public string GetWinAuthConnectionString()
        #region
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = DataSource;
            stringBuilder.InitialCatalog = InitialCatalog;
            stringBuilder.IntegratedSecurity = true;
            stringBuilder.ConnectTimeout = ConnectTimeout;
            return stringBuilder.ConnectionString;
        }
        #endregion
    }
}

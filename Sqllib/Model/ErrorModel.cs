using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sqllib.AdoNetSqlService;

namespace Sqllib.Model
{
    public class ErrorModel
    {
        public void WriteErrorToSql(string erorContent, string errorDescription)
        {

            string query =
                $@"INSERT INTO [EA2015].[dbo].[JUserError] (error_content, error_description, user_id) VALUES ({
                    erorContent}, {errorDescription}, 1)";

            new SqlHealper().ExecuteScalar(query, new SqlConnectionString().GetWinAuthConnectionString());
        }
    }
}

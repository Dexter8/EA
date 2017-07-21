using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sqllib.AdoNetSqlService
{
    public class SqlHealper
    {
        /// <summary>
        /// Метод для выполнения запросов к SQL без возвращения параметров.
        /// </summary>
        /// <param name="sqlCommand"></param>
        public void ExecuteNonQuery(string sqlCommand, string connectionString)
        #region
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        #endregion


        /// <summary>
        /// Метод для выполнения запросов к SQL с возвращением 1 параметра
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public string ExecuteScalar(string sqlCommand, string connectionString)
        #region
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    connection.Open();
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        #endregion


        public DataTable ExecuteTable(string sqlCommand, string connectionString)
        #region
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var masterDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                    masterDataAdapter.Fill(table);
                    return table;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }

            }
        }
        #endregion

        public DataTable ExecuteInitTable(DataTable table, string sqlCommand, string connectionString)
        #region
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var masterDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                    masterDataAdapter.Fill(table);
                    return table;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }

            }
        }
        #endregion
    }
}

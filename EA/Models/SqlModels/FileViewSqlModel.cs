using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EA.Data;
using EA.Model;
using Sqllib.AdoNetSqlService;

namespace EA.Models.SqlModels
{
    public class FileViewSqlModel
    {
        /// <summary>
        /// Получить лог по просмотру файлов
        /// </summary>
        /// <returns></returns>
        public List<FileViewLog> GetFileViewLog(int cardId)
        #region
        {
            try
            {
                List<FileViewLog> fileViewLog = new List<FileViewLog>();

                string query =
                    $@"SELECT fv.[id], fv.[card_id], fv.[file_id], fv.[user_login], fv.[machine_name], fv.[date]
                            , f.name as 'file_name', fvt.name as 'file_view_type_name', f.[extention] as 'file_extention'
                        FROM [EA2015].[dbo].[JFileView] fv
                        LEFT JOIN [EA2015].[dbo].[RFile] f on f.id = fv.[file_id]
						LEFT JOIN [EA2015].[dbo].[CFileViewType] fvt on fvt.id = fv.file_view_type_id
                        WHERE fv.card_id = {cardId}";

                DataTable table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());

                if (table.Rows.Count == 0) return null;

                foreach (DataRow row in table.Rows)
                {
                    fileViewLog.Add(new FileViewLog()
                    {
                        CardId = Convert.ToInt32(row["card_id"]),
                        Date = row["date"] as DateTime?,
                        FileId = Convert.ToInt32(row["file_id"]),
                        FileName = row["file_name"] as string,
                        MachineName = row["machine_name"] as string,
                        UserLogin = row["user_login"] as string,
                        ViewTypeName = row["file_view_type_name"] as string,
                        FileExtention = row["file_extention"] as string
                    });
                }
                return fileViewLog;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return null;
            }
        }
        #endregion



        /// <summary>
        /// Запись лого в БД
        /// @file_view_type_id = 1 - просмотр
        /// @file_view_type_id 2 - сохранение на диск
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="fileId"></param>
        /// <param name="viewTypeId"></param>
        /// <returns></returns>
        public bool SaveFileViewLog(int cardId, int fileId, int viewTypeId)
        #region
        {
            try
            {
                if (cardId == 0) return false;


                string query = @" INSERT INTO [EA2015].[dbo].[JFileView] ([card_id], [file_id], [user_login], [machine_name], [file_view_type_id]) 
                                    VALUES(@card_id, @file_id, @user_login, @machine_name, @file_view_type_id)";


                using (SqlConnection connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@card_id", cardId);
                        cmd.Parameters.AddWithValue("@file_id", fileId);
                        cmd.Parameters.AddWithValue("@user_login", Environment.UserName);
                        cmd.Parameters.AddWithValue("@machine_name", Environment.MachineName);
                        cmd.Parameters.AddWithValue("@file_view_type_id", viewTypeId);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }


                return false;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return false;
            }
        }
        #endregion

    }
}

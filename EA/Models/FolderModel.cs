using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using EA.Data;
using Sqllib.AdoNetSqlService;

namespace EA.Model
{
    public class FolderModel
    {
        /// <summary>
        /// Получить список папок с сервера
        /// </summary>
        /// <returns></returns>
        public List<Folder> GetFolders(List<Folder> folders)
        #region
        {
            DataTable table = new DataTable();
            #region query
            string query = @"SELECT [id]
                                ,[parent_id]
                                ,[folder_type_id]
                                ,[name]
                                ,[description]
                                ,[creation_date]
                                ,[last_edit_date]
                                ,[owner_login]
                                ,[dep_temp]
                            FROM [EA2015].[dbo].[Folder]";
            #endregion

            try
            {
                using (SqlConnection connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        table.Load(command.ExecuteReader());

                        foreach (DataRow row in table.Rows)
                        {
                            folders.Add(new Folder()
                            {
                                Id = Convert.ToInt32(row["id"]),
                                ParentId = row["parent_id"] as int?,
                                Name = row["name"].ToString(),
                                Description = row["description"].ToString(),
                                OwnerLogin = row["owner_login"].ToString(),
                                CreateDate = row["creation_date"] as DateTime?
                            });
                        }
                    }
                }

                return folders;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion


    }
}

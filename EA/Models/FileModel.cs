using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using DevExpress.XtraEditors;
using EA.Data;
using Sqllib.AdoNetSqlService;

namespace EA.Model
{
    public class FileModel
    {
        public List<Status> GetStatusList()
        #region
        {
            List<Status> status = new List<Status>();
            string query = "SELECT [id],[name],[short_name] FROM [EA2015].[dbo].[CStatus]";
            DataTable table = new DataTable();

            try
            {
                table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());
                foreach (DataRow row in table.Rows)
                {
                    status.Add(new Status()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["name"] as string,
                        ShortName = row["short_name"] as string
                    });
                }
                return status;
                
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return null;
            }
        }
        #endregion



        public List<FileData> GetCardFiles(int cardId)
        #region
        {
            List <FileData> files = new List<FileData>();
            DataTable table = new DataTable();
            string query = $@"SELECT fc.[uid]
                              ,fc.[id]
                              ,fc.[parent_id]
                              ,fc.[card_id]
                              ,fc.[folder_id]
                              ,fc.[document_type_id]
                              ,fc.[name]
                              ,fc.[description]
                              ,fc.[extention]
                              ,fc.[size]
                              ,fc.[owner]
                              ,fc.[version]
                              ,fc.[last_edit_date]
                              ,fc.[upload_date]
                              ,fc.[upload_reason]
	                          ,ctl.name as 'type_name'
                                ,fc.expire_date
                          FROM [EA2015].[dbo].[FileContent] fc
                          LEFT JOIN [EA2015].[dbo].[CardTypeList] ctl on ctl.id = fc.document_type_id
                          WHERE fc.card_id = {cardId}
                          AND NOT EXISTS (SELECT fc1.id FROM [EA2015].[dbo].[FileContent] fc1 WHERE fc1.parent_id = fc.id)";
            try
            {
                table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());
                if (table.Rows.Count == 0) return null;
                foreach (DataRow row in table.Rows)
                {
                    files.Add(new FileData()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Description = row["description"] as string,
                        ExtensionName = row["extention"] as string,
                        Size = row["size"] as string,
                        FileTypeId = row["document_type_id"] as int?,
                        TypeName = row["type_name"] as string,
                        Name = row["name"] as string,
                        UploadDate = row["upload_date"] as DateTime?,
                        ExpireDate = row["expire_date"] as DateTime?,
                        Version = row["version"] as int?


                    });
                }
                return files;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                throw;
            }
        }
        #endregion


        public Stream GetFileStream(int fileId)
        #region
        {
            try
            {
                var connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString());
                connection.Open();
                var transaction = connection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                using (var command = new SqlCommand(@"SELECT Content.PathName() FROM dbo.[FileContent] WHERE id = @id", connection, transaction))
                {
                    command.Parameters.AddWithValue("@id", fileId);
                    string filePath = (string)command.ExecuteScalar();

                    command.CommandText = "SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var transactionContext = reader.GetSqlBytes(0).Buffer;
                            Stream sqlFileStream = new SqlFileStream(filePath, transactionContext, FileAccess.Read);
                            return sqlFileStream;
                        }
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                throw;
            }
            return Stream.Null;
        }
        #endregion


        /// <summary>
        /// Загрузка нового файла на сервер
        /// </summary>
        /// <param name="fdata"></param>
        /// <returns></returns>
        public int UploadFileToSql(FileData fdata )
        #region
        {
            //проверка на название
            //проверка по хешу/ сохранять хеш
           
            try
            {

                using (var conn = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.SP_UploadFile";

                    cmd.Parameters.AddWithValue("@card_id", fdata.CardId ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@content", fdata.Content ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@name", fdata.Name ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@description", fdata.Description ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@extention", fdata.ExtensionName ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@size", fdata.Content.Length.ToString() ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@owner", Environment.UserName ?? (object) DBNull.Value);
                    cmd.Parameters.AddWithValue("@version", fdata.Version ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@parent_id", fdata.ParentId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@expire_date", fdata.ExpireDate ?? (object)DBNull.Value);

                    cmd.Parameters.AddWithValue("@draft_type_id", fdata.DraftTypeId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@status_id", fdata.StatusId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@file_type_id", fdata.FileTypeId ?? (object)DBNull.Value);


                    cmd.Parameters.Add("@new_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(cmd.Parameters["@new_id"].Value);
                }

            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return 0;
            }
        }
        #endregion


        /// <summary>
        /// Получить данный о загруженном файле
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        public FileData GetFileData(int fileId)
        #region
        {
            FileData fileData = new FileData();
            try
            {
                string query =
                    $@"SELECT [id],[parent_id], [card_id]
                                  ,[file_type_id], draft_type_id, status_id, [name], [description], [extention], [size]
                                  ,[owner], [version], [upload_date], [upload_reason], [expire_date], [version]
                                    FROM [EA2015].[dbo].[FileContent] WHERE id = {fileId}";

                DataTable table = new SqlHealper().ExecuteTable(query,
                    new SqlConnectionString().GetWinAuthConnectionString());
                if (table.Rows.Count == 0) return null;
                foreach (DataRow row in table.Rows)
                {
                    fileData.CardId = Convert.ToInt32(row["card_id"]);
                    fileData.FileTypeId = row["file_type_id"] as int?;
                    fileData.Name = row["name"] as string;
                    fileData.Description = row["description"] as string;
                    fileData.ExtensionName = row["extention"] as string;
                    fileData.Size = row["size"] as string;
                    fileData.Owner = row["owner"] as string;
                    fileData.Version = row["version"] as int?;
                    fileData.UploadDate = row["upload_date"] as DateTime?;
                    fileData.UpdateReason = row["upload_reason"] as string;
                    fileData.ExpireDate = row["expire_date"] as DateTime?;
                    fileData.Version = row["version"] as int?;
                    fileData.DraftTypeId = row["draft_type_id"] as int?;
                    fileData.StatusId = row["status_id"] as int?;
                }
                return fileData;

            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return null;
            }
        }
        #endregion




        /// <summary>
        /// Получить список типов документа
        /// </summary>
        /// <returns></returns>
        public List<FileType> GetFileTypes()
        #region
        {
            List<FileType> types = new List<FileType>();
            string query = "SELECT [id], [name], [short_name] FROM [EA2015].[dbo].[CFileType]";
            try
            {
                DataTable table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());
                foreach (DataRow row in table.Rows)
                {
                    types.Add(new FileType()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["name"] as string,
                        ShortName = row["short_name"] as string
                    });
                }
                return types;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return null;
            }
        } 
        #endregion


        public bool DeleteFile(int fileId)
        #region
        {
            try
            {
                string query = $@"DELETE FROM [EA2015].[dbo].[FileContent] WHERE [id] = {fileId}";
                new SqlHealper().ExecuteNonQuery(query, new SqlConnectionString().GetWinAuthConnectionString());
                return true;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return false;
            }
        }
        #endregion



        public void SaveZipFile(Stream file)
        #region
        {
           /* using (ZipFile zip = new ZipFile())
            {
                zip.AddFile("dfdf.pdf", )
                zip.AddFile("7440-N49th.png");
                zip.AddFile("2008_Annual_Report.pdf");
                zip.Save("Archive.zip");
            }*/


            /*using (ZipFile archive = new ZipFile(@"c:\path\to\your\password\protected\archive.zip"))
            {
                archive.Password = "your-pass-word-here";
                archive.Encryption = EncryptionAlgorithm.PkzipWeak; // the default: you might need to select the proper value here
                archive.StatusMessageTextWriter = Console.Out;

                archive.ExtractAll(@"c:\path\to\unzip\directory\", ExtractExistingFileAction.Throw);
            }*/
        }
        #endregion
    }
}

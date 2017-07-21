using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using DevExpress.XtraEditors;
using EA.Data;
using Ionic.Zip;
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
                              ,fc.[file_type_id]
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
                          FROM [EA2015].[dbo].[FileContent] fc
                          LEFT JOIN [EA2015].[dbo].[CardTypeList] ctl on ctl.id = fc.file_type_id
                          WHERE fc.card_id = {cardId}";
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
                        TypeId = row["file_type_id"] as int?,
                        TypeName = row["type_name"] as string,
                        Name = row["name"] as string
                        
                    });
                }
                return files;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
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
                XtraMessageBox.Show(ex.Message);
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
        public bool UploadFileToSql(FileData fdata )
        #region
        {
            byte[] file;
            string query =
                @"INSERT INTO [EA2015].[dbo].[FileContent] ([uid], [card_id], [content], [name], [description], [extention], [size], [owner]) 
                    VALUES (@uid, @card_id, @content, @name, @description, @extention, @size, @owner)";
            try
            {
                using (var stream = new FileStream(fdata.Path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                        
                    }
                }

                using (SqlConnection connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        var iIdParam = new SqlParameter("@uid", SqlDbType.UniqueIdentifier);
                        iIdParam.Value = fdata.UId;
                        command.Parameters.Add(iIdParam);

                        var cardIdParam = new SqlParameter("@card_id", SqlDbType.Int);
                        cardIdParam.Value = fdata.CardId;
                        command.Parameters.Add(cardIdParam);

                        var contentParam = new SqlParameter("@content", SqlDbType.VarBinary);
                        contentParam.Value = file;
                        command.Parameters.Add(contentParam);

                        var nameParam = new SqlParameter("@name", SqlDbType.Int);
                        nameParam.Value = fdata.Name;
                        command.Parameters.Add(nameParam);

                        var descriptionParam = new SqlParameter("@description", SqlDbType.Int);
                        descriptionParam.Value = fdata.Description;
                        command.Parameters.Add(descriptionParam);

                        var extentionParam = new SqlParameter("@extention", SqlDbType.Int);
                        extentionParam.Value = fdata.ExtensionName;
                        command.Parameters.Add(extentionParam);

                        var sizeParam = new SqlParameter("@size", SqlDbType.Int);
                        sizeParam.Value = fdata.Size;
                        command.Parameters.Add(sizeParam);

                        var ownerParam = new SqlParameter("@owner", SqlDbType.Int);
                        ownerParam.Value = fdata.Owner;
                        command.Parameters.Add(ownerParam);

                        connection.Open();
                        command.ExecuteScalar();
                        return true;
                    }
                }


                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
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

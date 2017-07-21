using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using EA.Data;
using Sqllib.AdoNetSqlService;

namespace EA.Model
{
    public class CardModel
    {
        /// <summary>
        /// Получить список карточек в выбранной папке
        /// </summary>
        public List<Card> GetCards(List<Card> cards, int folderId)
        #region

        {
            try
            {
                cards.Clear();
                string query = @"SELECT [id]
      ,[folder_id]
      ,[card_type_id]
      ,[code]
      ,[name]
      ,[description]
      ,[create_user_id]
      ,[create_date]
      ,[last_edit_date]
      ,[start_develop_date]
      ,[end_develop_date]
      ,[card_type_name]
      ,[status_name]
      ,[status_short_name]
      ,[exist_scan]
      ,[exist_2d]
      ,[exist_3d]
  FROM [EA2015].[dbo].[View_Cards] where folder_id = @folderIdParam order by code";

                DataTable cardsTable = new DataTable();


                using (SqlConnection connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        var Param = new SqlParameter("@folderIdParam", SqlDbType.Int);
                        Param.Value = folderId;
                        command.Parameters.Add(Param);

                        connection.Open();
                        cardsTable.Load(command.ExecuteReader());

                        foreach (DataRow row in cardsTable.Rows)
                        {
                            cards.Add(new Card()
                            {
                                CardId = Convert.ToInt32(row["id"]),
                                FolderId = row["folder_id"] as int?,
                                DraftTypeId = row["card_type_id"] as int?,
                                TypeName = row["card_type_name"] as string,
                                Description = row["description"] as string,
                                Code = row["code"] as string,
                                Name = row["name"] as string,
                               // Owner = row["create_login"] as string,
                                CreateDate = row["create_date"] as DateTime?,
                                CreateUserId = row["create_user_id"] as int?,
                                LastEditDate = row["last_edit_date"] as DateTime?,
                                StartDevelopDate = row["start_develop_date"] as DateTime?,
                                EndDevelopDate = row["end_develop_date"] as DateTime?,
                                ExistScan = row["exist_scan"] as bool?,
                                Exist2D = row["exist_2d"] as bool?,
                                Exist3D = row["exist_3d"] as bool?,
                                StatusName =  row["status_name"] as string,
                                StatusShortName = row["status_short_name"] as string

                            });
                        }
                    }
                }
                return cards;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return null;
            }

        }

        #endregion

        /// <summary>
        /// Получить список карточек по обозначению
        /// </summary>
        public List<Card> GetCardsByCode(List<Card> cards, string code)

            #region

        {
            try
            {
                cards.Clear();
                string query = @"SELECT [id]
                                              ,[folder_id]
                                              ,[card_type_id]
                                              ,[card_type_name]
                                              ,[code]
                                              ,[name]
                                              ,[description]
                                              ,[owner_login]
                                              ,[creation_date]
                                              ,[last_edit_date]
                                              ,[start_develop_date]
                                              ,[end_develop_date]
                                              ,[exist_scan]
                                              ,[exist_2d]
                                              ,[exist_3d]
                                             FROM [EA2015].[dbo].[card_view] where [code] like '%@codeParam%' order by code";

                DataTable cardsTable = new DataTable();


                using (
                    SqlConnection connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString())
                    )
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        var Param = new SqlParameter("@codeParam", SqlDbType.NVarChar);
                        Param.Value = code;
                        command.Parameters.Add(Param);

                        connection.Open();
                        cardsTable.Load(command.ExecuteReader());

                        foreach (DataRow row in cardsTable.Rows)
                        {
                            cards.Add(new Card()
                            {
                                CardId = Convert.ToInt32(row["id"]),
                                FolderId = row["folder_id"] as int?,
                                DraftTypeId = row["card_type_id"] as int?,
                                TypeName = row["card_type_name"] as string,
                                Description = row["description"] as string,
                                Code = row["code"] as string,
                                Name = row["name"] as string,
                                Owner = row["owner_login"] as string,
                                CreateDate = row["create_date"] as DateTime?,
                                LastEditDate = row["last_edit_date"] as DateTime?,
                                StartDevelopDate = row["start_develop_date"] as DateTime?,
                                EndDevelopDate = row["end_develop_date"] as DateTime?,
                                ExistScan = row["exist_scan"] as bool?,
                                Exist2D = row["exist_2d"] as bool?,
                                Exist3D = row["exist_3d"] as bool?
                            });
                        }
                    }
                }
                return cards;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return null;
            }

        }

        #endregion

        public Card GetCardData(int cardId)

            #region

        {
            try
            {
                string query =
                    $@"
                                SELECT [id]
                                  ,[folder_id]
                                  ,[card_type_id]
                                  ,[code]
                                  ,[name]
                                  ,[description]
                                  ,[owner_login]
                                  ,[create_date]
                                  ,[last_edit_date]
                                  ,[start_develop_date]
                                  ,[end_develop_date]
                                  ,[dep_temp]
                                FROM [EA2015].[dbo].[Card]
                                WHERE id = {
                        cardId}";

                DataTable cardTable = new DataTable();
                Card cardData = new Card();

                cardTable = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());
                if (cardTable.Rows.Count == 1)
                {
                    foreach (DataRow row in cardTable.Rows)
                    {
                        cardData.DraftTypeId = row["card_type_id"] as int?;
                        cardData.FolderId = row["folder_id"] as int?;
                        cardData.Name = row["name"] as string;
                        cardData.Code = row["code"] as string;
                        cardData.CreateDate = row["create_date"] as DateTime?;
                        cardData.Description = row["description"] as string;
                        cardData.StartDevelopDate = row["start_develop_date"] as DateTime?;
                        cardData.EndDevelopDate = row["end_develop_date"] as DateTime?;
                        cardData.CreateUserLogin = row["owner_login"] as string;

                    }
                }
                return cardData;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                throw;
            }
        }

        #endregion


        public int CreateNewCard(Card card)
        #region
        {
            try
            {
                //Проверка на дубликаты
                DataTable table =
                    new SqlHealper().ExecuteTable($"SELECT *  FROM [EA2015].[dbo].[Card] WHERE code = '{card.Code}'",
                        new SqlConnectionString().GetWinAuthConnectionString());
                if (table.Rows.Count > 0)
                {
                    XtraMessageBox.Show($"Карточка с кодом {card.Code} уже существует");
                    return 0;
                }


                using (var conn = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].SP_CreateNewCard";

                    cmd.Parameters.AddWithValue("@folder_id", card.FolderId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@card_type_id", card.DraftTypeId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@code", card.Code ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@name", card.Name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@description", card.Description ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@owner_login", Environment.UserName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@start_develop_date", card.StartDevelopDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@end_develop_date", card.EndDevelopDate ?? (object)DBNull.Value);
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


        public bool UpdateCard(Card card)
        #region
        {
            try
            {
                using (var conn = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[SP_UpdateCard]";

                    cmd.Parameters.AddWithValue("@id", card.CardId);
                    cmd.Parameters.AddWithValue("@folder_id", card.FolderId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@card_type_id", card.DraftTypeId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@code", card.Code ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@name", card.Name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@description", card.Description ?? (object)DBNull.Value);
                    //cmd.Parameters.AddWithValue("@owner_login", Environment.UserName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@start_develop_date", card.StartDevelopDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@end_develop_date", card.EndDevelopDate ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();

                    return true;
                }

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

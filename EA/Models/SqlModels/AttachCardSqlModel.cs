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
    public class AttachCardSqlModel
    {

        public bool AttachCard(int cardId, int cardParentId)
        #region
        {
            try
            {
                string query = @"  INSERT INTO [EA2015].[dbo].[RCardLink] ([card_id], [parent_card_id], user_login)
			                        VALUES (@card_id, @parent_card_id, @user_login)";

                using (SqlConnection connection = new SqlConnection(new SqlConnectionString().GetWinAuthConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@card_id", cardId);
                        cmd.Parameters.AddWithValue("@parent_card_id", cardParentId);
                        cmd.Parameters.AddWithValue("@user_login", Environment.UserName);

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


        public List<CardLink> GetAttachCards(int cardParentId)
        #region
        {
            List<CardLink> cards = new List<CardLink>();
            DataTable table = new DataTable();
            string query = $@"SELECT cl.[id], cl.[card_id], cl.[parent_card_id], cl.[date], cl.[user_login], c.code, c.name, c.card_type_name, c.create_date, c.status_name
                              FROM [EA2015].[dbo].[RCardLink] cl
                              LEFT JOIN [EA2015].[dbo].[View_Cards] c on c.id = cl.card_id
                                WHERE cl.parent_card_id = {cardParentId}";
            try
            {
                table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());
                if (table.Rows.Count == 0) return null;
                foreach (DataRow row in table.Rows)
                {
                    cards.Add(new CardLink()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        CardId = Convert.ToInt32(row["card_id"]),
                        CardParentId = Convert.ToInt32(row["parent_card_id"]),
                        TypeName = row["card_type_name"] as string,
                        Code = row["code"] as string,
                        Name = row["name"] as string,
                        StatusName = row["status_name"] as string,
                        CreateDate = row["create_date"] as DateTime?

                    });
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
        /// Удалить ссылку на карту
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteLinkCard(int id)
        {
            string query = $@"DELETE FROM [EA2015].[dbo].[RCardLink] WHERE id = {id}";
            
            try
            {
                new SqlHealper().ExecuteNonQuery(query, new SqlConnectionString().GetWinAuthConnectionString());
                return true;
            }
            catch (Exception ex)
            {
                new ErrorSqlModel().WriteErrorOnSql(ex);
                return false;
            }
        }
    }
}

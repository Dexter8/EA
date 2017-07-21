using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using EA.Data;
using Sqllib.AdoNetSqlService;

namespace EA.Model
{
    public class DrawingModel
    {
        /// <summary>
        /// Получить типы чертежа
        /// </summary>
        /// <returns></returns>
        public List<DraftType> GetDraftTypes()
        #region
        {
            List<DraftType> draftTypes = new List<DraftType>();
            DataTable table = new DataTable();
            string query = @"SELECT [id], [name] FROM [EA2015].[dbo].[CDraftType]";
            try
            {
                table = new SqlHealper().ExecuteTable(query, new SqlConnectionString().GetWinAuthConnectionString());
                foreach (DataRow row in table.Rows)
                {
                    draftTypes.Add(new DraftType() {Id = Convert.ToInt32(row["id"]), Name = row["name"] as string});
                }
                return draftTypes;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion


        /// <summary>
        /// Записасть открытие чертежа в журнал
        /// </summary>
        /// <returns></returns>
        public bool WriteDrawingViewLog()
        #region
        {
            try
            {


                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
    }
}

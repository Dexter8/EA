using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EA.Data
{
    /// <summary>
    /// Карточка чертежа
    /// </summary>
    public class Card
    {
        public int CardId { get; set; }
        public int? FolderId { get; set; }
        public int? DraftTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? StartDevelopDate { get; set; }
        public DateTime? EndDevelopDate { get; set; }
        public bool? ExistScan { get; set; }
        public bool? Exist3D { get; set; }
        public bool? Exist2D { get; set; }
        public string StatusName { get; set; }
        public int? StatusId { get; set; }
        public string StatusShortName { get; set; }


        public DateTime? CreateDate { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserLogin { get; set; }

    }
}

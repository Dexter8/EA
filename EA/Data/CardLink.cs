using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EA.Data
{
    public class CardLink
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int CardParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string StatusName { get; set; }
        public string TypeName { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

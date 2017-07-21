using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EA.Data
{
    public class Folder
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string OwnerLogin { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}

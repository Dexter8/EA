using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EA.Data
{
    public class FileData
    {
        public System.Guid UId { get; set; }
        public int Id { get; set; }

        public int? ParentId { get; set; }
        public int? DraftTypeId { get; set; }
        public string Path { get; set; }
        public int? FileTypeId { get; set; }
        public int? StatusId { get; set; }
        public string TypeName { get; set; }
        public int? CardId { get; set; }


        public string Name { get; set; }
        public DateTime? ExpireDate { get; set; }
        
        public string Description { get; set; }

        private string size { get; set; }
        public string Size
        {
            get { return size; }
            set {
                if (value == null) size = null;
                else size =  Convert.ToInt32(value) / 1024 + " КБ";
            }
        }

        /// <summary> Id расширение файла </summary>
        public int? ExtensionId { get; set; }
        /// <summary>
        /// Название расширение файла
        /// </summary>
        public string ExtensionName { get; set; }
        public DateTime? UploadDate { get; set; }
        public string Developer { get; set; }

        public string UpdateReason { get; set; }
        public byte[] Content { get; set; }
        public int? Version { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string Owner { get; set; }

    }
}

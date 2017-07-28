using System;

namespace EA.Data
{
    /// <summary>
    /// Журнал открытия файлов
    /// </summary>
    public class FileViewLog
    {
        public int CardId { get; set; }
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public string UserLogin { get; set; }
        public string MachineName { get; set; }
        public DateTime? Date { get; set; }
        public string ViewTypeName { get; set; }

    }
}

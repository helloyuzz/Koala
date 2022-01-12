using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public long? FileLength { get; set; }
        public string DiskPath { get; set; }
        public string DiskFile { get; set; }
        public string Hash { get; set; }
        public DateTime? UploadOn { get; set; }
        public int? UploadBy { get; set; }
        public int? ViewCount { get; set; }
        public int? DownloadCount { get; set; }
        public int? ObjId { get; set; }
        public int? AttachmentType { get; set; }
        public int? Position { get; set; }
    }
}

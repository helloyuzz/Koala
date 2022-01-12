using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Pinyin { get; set; }
        public int? ManagerId { get; set; }
        public string LogoUrl { get; set; }
        public string BackgroundUrl { get; set; }
        public string LicenceCode { get; set; }
        public DateTime? LicenceTo { get; set; }
        public int? ParentId { get; set; }
        public string GroupId { get; set; }
        public int? VersionId { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string Status { get; set; }
        public bool? IsRoot { get; set; }
        public bool? IsDelete { get; set; }
        public int? Position { get; set; }
    }
}

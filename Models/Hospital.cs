using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? ManagerId { get; set; }
        public string LogoUrl { get; set; }
        public string LicenceCode { get; set; }
        public int? ParentId { get; set; }
        public string GroupId { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? Position { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? HospitalId { get; set; }
        public string Pinyin { get; set; }
        public bool? Status { get; set; }
        public int? ManagerId { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public bool? IsDelete { get; set; }
        public int? ParentId { get; set; }
    }
}

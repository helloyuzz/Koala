using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}

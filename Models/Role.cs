using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SectionId { get; set; }
        public int? HospitalId { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? Status { get; set; }
        public bool? IsDelete { get; set; }
    }
}

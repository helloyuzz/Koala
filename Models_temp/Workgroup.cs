using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class Workgroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HospitalId { get; set; }
        public int? SectionId { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? CreateBy { get; set; }
        public int? Status { get; set; }
    }
}

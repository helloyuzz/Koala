using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class RequestRecyle
    {
        public int Id { get; set; }
        public string RecyleNo { get; set; }
        public DateTime? RequestOn { get; set; }
        public int? SectionId { get; set; }
        public int? RequestBy { get; set; }
        public DateTime? RecyleOn { get; set; }
        public int? RecyleBy { get; set; }
        public string Status { get; set; }
        public int? PackageCount { get; set; }
        public int? InstrumentCount { get; set; }
    }
}

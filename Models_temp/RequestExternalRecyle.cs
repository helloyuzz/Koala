using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class RequestExternalRecyle
    {
        public int Id { get; set; }
        public int? ManufacturerId { get; set; }
        public int? DespatcherId { get; set; }
        public DateTime? RequestOn { get; set; }
        public string PatientName { get; set; }
        public DateTime? OperationDate { get; set; }
        public int? PackageCount { get; set; }
        public int? InstrumentCount { get; set; }
        public DateTime? RecyleOn { get; set; }
        public int? RecyleBy { get; set; }
        public string Status { get; set; }
    }
}

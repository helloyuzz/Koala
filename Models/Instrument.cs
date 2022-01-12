using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Instrument
    {
        public int Id { get; set; }
        public int? PackageId { get; set; }
        public int? InstrumentId { get; set; }
        public string Name { get; set; }
        public string Graphy { get; set; }
    }
}

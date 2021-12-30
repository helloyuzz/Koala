using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Right
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? ModuleId { get; set; }
    }
}

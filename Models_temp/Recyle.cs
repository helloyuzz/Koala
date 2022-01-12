using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class Recyle
    {
        public int Id { get; set; }
        public string SeqNo { get; set; }
        public int? UserId { get; set; }
        public int? SectionId { get; set; }
        public DateTime? RecyleOn { get; set; }
        public int? RecyleBy { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
    }
}

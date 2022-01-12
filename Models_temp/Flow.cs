using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class Flow
    {
        public int Id { get; set; }
        public int? CustomFlowId { get; set; }
        public int? StatusId { get; set; }
        public int? PrevId { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CloseOn { get; set; }
    }
}

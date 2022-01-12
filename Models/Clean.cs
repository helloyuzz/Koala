using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Clean
    {
        public int Id { get; set; }
        public int? FlowId { get; set; }
        public int? CreateOn { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class UserMapping
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? TargetId { get; set; }
        public string Type { get; set; }
    }
}

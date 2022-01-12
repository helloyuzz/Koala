using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class RoleRight
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? RightId { get; set; }
        public bool? Create { get; set; }
        public bool? View { get; set; }
        public bool? Edit { get; set; }
        public bool? Drop { get; set; }
        public bool? Export { get; set; }
        public bool? Print { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string AspPage { get; set; }
        public string Area { get; set; }
        public int? Position { get; set; }
        public int? Unread { get; set; }
        public sbyte? Hidden { get; set; }
    }
}

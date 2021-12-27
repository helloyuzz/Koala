﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models {
    public partial class Menu {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string AspPage { get; set; }
        public int? Position { get; set; }
        public string Area { get; set; }
    }
}
using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CreateVersion { get; set; }
        public int? Status { get; set; }
    }
}

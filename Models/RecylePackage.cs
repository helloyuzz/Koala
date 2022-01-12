using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class RecylePackage
    {
        public int Id { get; set; }
        public int? RecyleId { get; set; }
        public int? PackageId { get; set; }
        public string Graphy { get; set; }
    }
}

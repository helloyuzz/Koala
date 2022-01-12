using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class Version
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PublishOn { get; set; }
        public string VersionLog { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public string UpdateLog { get; set; }
    }
}

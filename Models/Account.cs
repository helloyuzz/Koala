using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models {
    public partial class Account {
        public int Id { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
        public string Name { get; set; }
        public bool? IsAdmin { get; set; }
        public int? Status { get; set; }
        public DateTime? LastLoginOn { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string Type { get; set; }
        public string Salt { get; set; }
        public sbyte? MustChangePasswd { get; set; }
        public int? HospitalId { get; set; }
    }
}
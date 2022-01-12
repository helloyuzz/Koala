using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Pinyin { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool? IsAdmin { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public DateTime? LastLoginOn { get; set; }
        public string Type { get; set; }
        public bool? MustChangePasswd { get; set; }
        public int? HospitalId { get; set; }
        public int? SectionId { get; set; }
        public sbyte? IsDelete { get; set; }
        public sbyte? IsTemp { get; set; }
        public string Avator { get; set; }
    }
}

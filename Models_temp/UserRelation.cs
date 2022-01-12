using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models_temp
{
    public partial class UserRelation
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ObjId { get; set; }
        public string RelationType { get; set; }
    }
}

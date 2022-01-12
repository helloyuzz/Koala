using System;
using System.Collections.Generic;

#nullable disable

namespace Koala.Models
{
    public partial class CustomFlow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public sbyte? Recyle { get; set; }
        public sbyte? Clean { get; set; }
    }
}

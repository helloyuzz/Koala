using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala {
    public class SysMenu {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Unread { get; set; }
        public List<MenuItem> SubMenus { get; set; }
    }
    public class MenuItem {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string AspPage { get; set; }
        public string Area { get; set; }
        public int Unread { get; set; }

    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala {
    public class _Globals {
        static public List<SysMenu> SysMenus {
            get {
                List<SysMenu> items = new List<SysMenu>();
                var section = AppConfigurtaionServices.Configuration.GetSection("SysMenu");

                IConfigurationSection myArraySection = AppConfigurtaionServices.Configuration.GetSection("SysMenus");
                var temp = myArraySection.Get<List<SysMenu>>();
                foreach (SysMenu item in temp) {                  
                    items.Add(item);
                }
                var itemArray = myArraySection.AsEnumerable();
                return items;
            }
        }
    }
}

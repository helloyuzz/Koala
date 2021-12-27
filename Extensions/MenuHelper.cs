using Koala.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala {
    public class MenuHelper {
    private readonly koalaContext koalaContext;
        public MenuHelper(koalaContext _koalaContext) {
            koalaContext = _koalaContext;
        }
        public List<SysMenu> All() {
            List<SysMenu> _sysMenus = new List<SysMenu>();
            var items = koalaContext.Menus.ToList();
            foreach (var item in items.Where(t => t.ParentId == null).OrderBy(t => t.Position)) {
                SysMenu sysMenu = new SysMenu();
                sysMenu.Id = item.Id;
                sysMenu.Name = item.Name;
                sysMenu.Class = item.Class;
                foreach (var subItem in items.Where(t => t.ParentId == item.Id).OrderBy(t => t.Position)) {
                    if (sysMenu.SubMenus == null) {
                        sysMenu.SubMenus = new List<MenuItem>();
                    }
                    MenuItem subMenu = new MenuItem();
                    subMenu.Id = subItem.Id;
                    subMenu.Name = subItem.Name;
                    subMenu.Class = subItem.Class;
                    subMenu.AspPage = subItem.AspPage;
                    subMenu.Area = subItem.Area;

                    sysMenu.SubMenus.Add(subMenu);
                }
                _sysMenus.Add(sysMenu);
            }
            return _sysMenus;
        }
    }
}

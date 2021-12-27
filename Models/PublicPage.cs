using Koala.Extensions;
using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala {
    public class PublicPage : PageModel {
        private readonly koalaContext _koalaContext;
        public bool ShowMainMenu { get; set; } = false;
        public string id { get; set; }
        public string menuName { get; set; }
        public List<SysMenu> _SysMenus { get; set; } = new List<SysMenu>();
        public PublicPage(koalaContext koalaContext) {
            _koalaContext = koalaContext;
        }
        public virtual IActionResult OnGet() {
            //    if (User.Identity.IsAuthenticated == false) {
            //        return RedirectToPage("/Login");
            //    } else {
            id = Request.Query["id"];
            menuName = Request.Query["menuName"];

            //_SysMenus = Globals.SysMenus;
            var items = _koalaContext.Menus.ToList();
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
                _SysMenus.Add(sysMenu);
            }
            return Page();
            //}
        }
    }
}

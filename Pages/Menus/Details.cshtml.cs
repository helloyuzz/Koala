using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Menus {
    public class DetailsModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public DetailsModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public Menu Menu { get; set; }

        public IList<Menu> SubMenu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Menu = await _context.Menus.FirstOrDefaultAsync(m => m.Id == id);

            if (Menu == null) {
                return NotFound();
            }

            SubMenu = await _context.Menus.Where(t => t.ParentId == Menu.Id).OrderBy(t => t.Position).ToListAsync();
            return Page();
        }
    }
}

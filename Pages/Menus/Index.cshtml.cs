using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Menus {
    public class IndexModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public IndexModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IList<Menu> Menu { get; set; }

        public async Task OnGetAsync() {
            Menu = await _context.Menus.Where(t => t.ParentId == null).OrderBy(t=>t.Area).ThenBy(t => t.Position).ToListAsync();
        }
    }
}
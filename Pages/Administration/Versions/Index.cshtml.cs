using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;
using Version = Koala.Models.Version;

namespace Koala.Pages.Administration.Versions {
    public class IndexModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public IndexModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IList<Version> Version { get; set; }

        public async Task OnGetAsync() {
            Version = await _context.Versions.ToListAsync();
        }
    }
}

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
    public class DeleteModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public DeleteModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        [BindProperty]
        public Version Version { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Version = await _context.Versions.FirstOrDefaultAsync(m => m.Id == id);

            if (Version == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Version = await _context.Versions.FindAsync(id);

            if (Version != null) {
                _context.Versions.Remove(Version);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
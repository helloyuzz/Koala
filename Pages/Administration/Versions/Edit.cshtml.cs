using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Koala.Models;
using Version = Koala.Models.Version;

namespace Koala.Pages.Administration.Versions {
    public class EditModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public EditModel(Koala.Models.koalaContext context) {
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(Version).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!VersionExists(Version.Id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VersionExists(int id) {
            return _context.Versions.Any(e => e.Id == id);
        }
    }
}
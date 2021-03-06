using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Koala.Models;
using Version = Koala.Models.Version;

namespace Koala.Pages.Administration.Versions {
    public class CreateModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public CreateModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public Version Version { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Versions.Add(Version);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
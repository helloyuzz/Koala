using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Koala.Models;

namespace Koala.Pages.Administration.Hospitals {
    public class CreateModel : PageModel {
        private readonly koalaContext _context;

        public IList<Hospital> Hospitals { get; set; }
        public CreateModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            Hospitals = _context.Hospitals.ToList();
            return Page();
        }

        [BindProperty]
        public Hospital Hospital { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Hospitals.Add(Hospital);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
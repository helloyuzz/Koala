using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Menus {
    public class EditModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public EditModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        [BindProperty]
        public Menu Menu { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Referer_url { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }
            Referer_url = Request.Headers["Referer"].ToString();
            if (string.IsNullOrEmpty(Referer_url)) {
                Referer_url = "/Index";
            }

            Menu = await _context.Menus.FirstOrDefaultAsync(m => m.Id == id);

            if (Menu == null) {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(Menu).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!MenuExists(Menu.Id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            if (string.IsNullOrEmpty(Referer_url) == false) {
                return Redirect(Referer_url);
            } else {
                return RedirectToPage("./Index");
            }
        }

        private bool MenuExists(int id) {
            return _context.Menus.Any(e => e.Id == id);
        }
    }
}
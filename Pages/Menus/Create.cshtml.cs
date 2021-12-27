using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Koala.Models;

namespace Koala.Pages.Menus {
    public class CreateModel : PageModel {
        private readonly Koala.Models.koalaContext _context;
        public string Parent_id { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Referer_url { get; set; }

        public CreateModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            Parent_id = Request.Query["parent_id"];
            Referer_url = Request.Headers["Referer"].ToString();
            if (string.IsNullOrEmpty(Referer_url)) {
                Referer_url = "/Index";
            }
            return Page();
        }

        [BindProperty]
        public Menu Menu { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Menus.Add(Menu);
            await _context.SaveChangesAsync();

            if (string.IsNullOrEmpty(Referer_url) == false) {
                return Redirect(Referer_url);
            } else {
                return RedirectToPage("./Index");
            }
        }
    }
}
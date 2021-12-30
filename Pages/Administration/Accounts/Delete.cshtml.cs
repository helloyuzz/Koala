using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Administration.Accounts {
    public class DeleteModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public DeleteModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        [BindProperty]
        public User Account { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Account = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (Account == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            if (id == null) {
                return NotFound();
            }

            Account = await _context.Users.FindAsync(id);

            if (Account != null) {
                _context.Users.Remove(Account);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Client.Recyles
{
    public class DeleteModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public DeleteModel(Koala.Models.koalaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recyle Recyle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recyle = await _context.Recyles.FirstOrDefaultAsync(m => m.Id == id);

            if (Recyle == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recyle = await _context.Recyles.FindAsync(id);

            if (Recyle != null)
            {
                _context.Recyles.Remove(Recyle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

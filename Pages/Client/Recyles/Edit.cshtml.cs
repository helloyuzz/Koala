using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Client.Recyles
{
    public class EditModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public EditModel(Koala.Models.koalaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Recyle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecyleExists(Recyle.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecyleExists(int id)
        {
            return _context.Recyles.Any(e => e.Id == id);
        }
    }
}

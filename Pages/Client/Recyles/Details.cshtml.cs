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
    public class DetailsModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public DetailsModel(Koala.Models.koalaContext context)
        {
            _context = context;
        }

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
    }
}

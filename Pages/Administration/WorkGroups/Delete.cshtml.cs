using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Administration.WorkGroups
{
    public class DeleteModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public DeleteModel(Koala.Models.koalaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Workgroup Workgroup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Workgroup = await _context.Workgroups.FirstOrDefaultAsync(m => m.Id == id);

            if (Workgroup == null)
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

            Workgroup = await _context.Workgroups.FindAsync(id);

            if (Workgroup != null)
            {
                _context.Workgroups.Remove(Workgroup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

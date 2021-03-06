using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Koala.Models;

namespace Koala.Pages.Administration.WorkGroups
{
    public class CreateModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public CreateModel(Koala.Models.koalaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Workgroup Workgroup { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Workgroups.Add(Workgroup);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

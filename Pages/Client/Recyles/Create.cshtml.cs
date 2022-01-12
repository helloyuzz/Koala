﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Koala.Models;

namespace Koala.Pages.Client.Recyles
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
        public Recyle Recyle { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recyles.Add(Recyle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

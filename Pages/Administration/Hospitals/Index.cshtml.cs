using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Administration.Hospitals {
    public class IndexModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public IndexModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IList<Hospital> Hospital { get; set; }

        public IActionResult OnGet() {
            Hospital = _context.Hospitals.ToList();
            //if (Hospital.Count > 0) {
            //    return RedirectToPage("Create");
            //} else {
            //}            
            return Page();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Koala.Pages.Custom {
    public class NewCustomModel : PublicPage {
        private readonly koalaContext _koalaContext;
        public NewCustomModel(koalaContext koalaContext) : base(koalaContext) {
            _koalaContext = koalaContext;
        }
        public override IActionResult OnGet() {
            base.OnGet();
            return Page();
        }
    }
}

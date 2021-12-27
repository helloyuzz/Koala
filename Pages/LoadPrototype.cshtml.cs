using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Koala.Pages {
    public class LoadPrototypeModel : PublicPage {
        private readonly koalaContext _koalaContext;
        public LoadPrototypeModel(koalaContext koalaContext) : base(koalaContext) {
            _koalaContext = koalaContext;
        }
        public override IActionResult OnGet() {
            base.OnGet();
            return Page();
        }
    }
}

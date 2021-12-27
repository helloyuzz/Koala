using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala.Pages {
    public class PrivacyModel : PublicPage {
        private readonly koalaContext _koalaContext;
        public PrivacyModel(koalaContext koalaContext) : base(koalaContext) {
            _koalaContext = koalaContext;
        }
        public override IActionResult OnGet() {
            base.OnGet();
            return Page();
        }
    }
}

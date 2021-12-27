using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala.Pages.Administration {
    public class IndexModel : PublicPage {
        private readonly koalaContext _koalaContext;
        public IndexModel(koalaContext koalaContext) : base(koalaContext) {
            _koalaContext = koalaContext;
        }

        public override IActionResult OnGet() {
            return base.OnGet();
        }
    }
}

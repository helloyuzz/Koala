using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Koala.Pages.Administration.Hospitals {
    public class SectionsModel : PageModel {
        private readonly koalaContext _context;

        public SectionsModel(koalaContext context) {
            _context = context;
        }
        public IList<User> User { get; set; }
        public void OnGet() {
            User = _context.Users.ToList();
        }
    }
}
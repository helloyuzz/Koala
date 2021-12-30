using Koala.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala.Pages.Administration.Accounts {
    public class IndexModel : PageModel {
        private readonly koalaContext _context;

        public IndexModel(koalaContext context) {
            _context = context;
        }

        public IList<User> User { get; set; }

        public void OnGet() {
            User = _context.Users.ToList();
        }
    }
}
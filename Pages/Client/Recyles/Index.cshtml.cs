using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Client.Recyles {
    public class IndexModel : PageModel {
        private readonly Koala.Models.koalaContext _context;

        public IndexModel(Koala.Models.koalaContext context) {
            _context = context;
        }

        public IList<Recyle> Recyle { get; set; }
        public IList<ExternalRecyle> ExternalRecyles { get; set; }

        public async Task OnGetAsync() {
            Recyle = await _context.Recyles.Include(t=>t.User).Include(t=>t.RecyleUser).Include(t=>t.Section).ToListAsync();
            ExternalRecyles = await _context.ExternalRecyles.ToListAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Koala.Pages.Client.Recyles {
    public class RecyleModel : PageModel {
        private readonly koalaContext _context;

        public RecyleModel(koalaContext context) {
            _context = context;
        }

        public IList<RequestRecyle> Recyle { get; set; }
        public async Task OnGetAsync() {
            Recyle = await _context.RequestRecyles.Include(t=>t.RequestByUser).Include(t=>t.RecyleByUser).Include(t=>t.RequestSection).ToListAsync();
        }
    }
}

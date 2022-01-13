using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Koala.Pages.Client.Recyles {
    public class ExRecyleModel : PageModel {
        private readonly koalaContext _context;

        public ExRecyleModel(koalaContext context) {
            _context = context;
        }
    
        public IList<RequestExternalRecyle> ExternalRecyles { get; set; }

        public async Task OnGetAsync() {
            ExternalRecyles = await _context.RequestExternalRecyles.ToListAsync();
        }
    }
}

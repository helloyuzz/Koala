using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Administration.Sections
{
    public class IndexModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public IndexModel(Koala.Models.koalaContext context)
        {
            _context = context;
        }

        public IList<Section> Section { get;set; }

        public async Task OnGetAsync()
        {
            Section = await _context.Sections.ToListAsync();
        }
    }
}

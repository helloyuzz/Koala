using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;

namespace Koala.Pages.Administration.WorkGroups
{
    public class IndexModel : PageModel
    {
        private readonly Koala.Models.koalaContext _context;

        public IndexModel(Koala.Models.koalaContext context)
        {
            _context = context;
        }

        public IList<Workgroup> Workgroup { get;set; }

        public async Task OnGetAsync()
        {
            Workgroup = await _context.Workgroups.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorExample.Models;

namespace RazorExample.Pages.Employs
{
    public class IndexModel : PageModel
    {
        private readonly RazorExample.Models.EFCoreDbContext _context;

        public IndexModel(RazorExample.Models.EFCoreDbContext context)
        {
            _context = context;
        }

        public IList<Employ> Employ { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employ = await _context.Employees.ToListAsync();
        }
    }
}

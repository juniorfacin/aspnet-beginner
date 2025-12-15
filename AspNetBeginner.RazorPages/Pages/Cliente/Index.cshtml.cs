using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetBeginner.RazorPages.Data;
using AspNetBeginner.RazorPages.Models;

namespace AspNetBeginner.RazorPages.Pages.Cliente
{
    public class IndexModel : PageModel
    {
        private readonly AspNetBeginner.RazorPages.Data.ApplicationDbContext _context;

        public IndexModel(AspNetBeginner.RazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cliente = await _context.Cliente.ToListAsync();
        }
    }
}

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
    public class DetailsModel : PageModel
    {
        private readonly AspNetBeginner.RazorPages.Data.ApplicationDbContext _context;

        public DetailsModel(AspNetBeginner.RazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.Id == id);

            if (cliente is not null)
            {
                Cliente = cliente;

                return Page();
            }

            return NotFound();
        }
    }
}

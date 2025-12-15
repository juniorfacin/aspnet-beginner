using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspNetBeginner.RazorPages.Models;

namespace AspNetBeginner.RazorPages.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<AspNetBeginner.RazorPages.Models.Cliente> Cliente { get; set; } = default!;
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspNetBeginner.Mvc.Models;

namespace AspNetBeginner.Mvc.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<AspNetBeginner.Mvc.Models.Aluno> Aluno { get; set; } = default!;
    }
}

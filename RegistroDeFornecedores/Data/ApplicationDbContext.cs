using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RegistroV7.Models;

namespace RegistroV7.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RegistroV7.Models.Pais> Pais { get; set; } = default!;
        public DbSet<RegistroV7.Models.Estado> Estado { get; set; } = default!;
    }
}

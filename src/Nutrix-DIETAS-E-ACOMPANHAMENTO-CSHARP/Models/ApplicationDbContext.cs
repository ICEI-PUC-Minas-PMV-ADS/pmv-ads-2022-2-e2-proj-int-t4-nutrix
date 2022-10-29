using Microsoft.EntityFrameworkCore;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}

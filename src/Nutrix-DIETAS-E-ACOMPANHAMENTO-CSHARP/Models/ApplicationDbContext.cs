using Microsoft.EntityFrameworkCore;

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DadoPessoal> DadoPessoais { get; set; }
        public DbSet<Dieta> Dietas { get; set; }
        public DbSet<Refeicao> Refeicoes { get; set; }
        public DbSet<RefeicaoAlimento> RefeicoesAlimentos { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }

    }
}

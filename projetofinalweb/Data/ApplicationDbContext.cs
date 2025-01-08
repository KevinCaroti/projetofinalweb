using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalWeb.Models;

namespace projetofinalweb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Adicione os DbSet correspondentes às tabelas
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Encomenda> Encomendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais de mapeamento podem ser adicionadas aqui
        }
    }
}

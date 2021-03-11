using CursoMVC.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoMVC.Data.Context
{
    public class MvcDbContext : DbContext
    {
        public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MvcDbContext).Assembly);

            // Desabilitando o Delete Cascade
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}

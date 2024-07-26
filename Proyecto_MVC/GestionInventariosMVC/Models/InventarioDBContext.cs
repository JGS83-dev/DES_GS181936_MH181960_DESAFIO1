using GestionInventariosMVC.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace GestionInventariosMVC.Models
{
    public class InventarioDBContext : DbContext
    {
        public InventarioDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriasSeed());
            modelBuilder.ApplyConfiguration(new ProductosSeed());
        }
    }
}

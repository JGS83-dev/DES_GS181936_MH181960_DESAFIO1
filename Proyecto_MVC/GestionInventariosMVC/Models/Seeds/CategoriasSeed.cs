using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestionInventariosMVC.Models.Seeds
{
    public class CategoriasSeed : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(
                new Categoria { Codigo = "CAT_ELECTRONICA", Nombre = "Electrónica" },
                new Categoria { Codigo = "CAT_ROPA", Nombre = "Ropa" },
                new Categoria { Codigo = "CAT_ALIMENTOS", Nombre = "Alimentos" });
        }
    }
}

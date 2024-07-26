using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionInventariosMVC.Models.Seeds
{
    public class ProductosSeed : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasData(
                new Producto
                {
                    Codigo = "PROD_0000",
                    Nombre = "Smartphone",
                    Descripcion = "Smartphone",
                    CodigoCategoria = "CAT_ELECTRONICA",
                    Precio = 299.99M,
                    Stock = 50
                },
                new Producto
                {
                Codigo = "PROD_0001",
                    Nombre = "Camisa",
                    Descripcion = "Camisa",
                    CodigoCategoria = "CAT_ROPA",
                    Precio = 19.99M,
                    Stock = 200
                },
                new Producto
                {
                Codigo = "PROD_0002",
                    Nombre = "Pan",
                    Descripcion = "Pan",
                    CodigoCategoria = "CAT_ALIMENTOS",
                    Precio = 1.99M,
                    Stock = 100
                },
                new Producto
                {
                Codigo = "PROD_0003",
                    Nombre = "Laptop",
                    Descripcion = "Laptop",
                    CodigoCategoria = "CAT_ELECTRONICA",
                    Precio = 799.99M,
                    Stock = 30
                },
                new Producto
                {
                Codigo = "PROD_0004",
                    Nombre = "Zapatos",
                    Descripcion = "Zapatos",
                    CodigoCategoria = "CAT_ROPA",
                    Precio = 49.99M,
                    Stock = 150
                });
        }
    }
}

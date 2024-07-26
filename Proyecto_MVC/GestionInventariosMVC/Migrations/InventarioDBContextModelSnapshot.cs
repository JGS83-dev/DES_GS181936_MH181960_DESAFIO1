﻿// <auto-generated />
using GestionInventariosMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionInventariosMVC.Migrations
{
    [DbContext(typeof(InventarioDBContext))]
    partial class InventarioDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionInventariosMVC.Models.Categoria", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Codigo");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Codigo = "CAT_ELECTRONICA",
                            Descripcion = "Electrónica",
                            Nombre = "Electrónica"
                        },
                        new
                        {
                            Codigo = "CAT_ROPA",
                            Descripcion = "Ropa",
                            Nombre = "Ropa"
                        },
                        new
                        {
                            Codigo = "CAT_ALIMENTOS",
                            Descripcion = "Alimentos",
                            Nombre = "Alimentos"
                        });
                });

            modelBuilder.Entity("GestionInventariosMVC.Models.Producto", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CodigoCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCategoria");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Codigo = "PROD_0000",
                            CodigoCategoria = "CAT_ELECTRONICA",
                            Descripcion = "Smartphone",
                            Nombre = "Smartphone",
                            Precio = 299.99m,
                            Stock = 50
                        },
                        new
                        {
                            Codigo = "PROD_0001",
                            CodigoCategoria = "CAT_ROPA",
                            Descripcion = "Camisa",
                            Nombre = "Camisa",
                            Precio = 19.99m,
                            Stock = 200
                        },
                        new
                        {
                            Codigo = "PROD_0002",
                            CodigoCategoria = "CAT_ALIMENTOS",
                            Descripcion = "Pan",
                            Nombre = "Pan",
                            Precio = 1.99m,
                            Stock = 100
                        },
                        new
                        {
                            Codigo = "PROD_0003",
                            CodigoCategoria = "CAT_ELECTRONICA",
                            Descripcion = "Laptop",
                            Nombre = "Laptop",
                            Precio = 799.99m,
                            Stock = 30
                        },
                        new
                        {
                            Codigo = "PROD_0004",
                            CodigoCategoria = "CAT_ROPA",
                            Descripcion = "Zapatos",
                            Nombre = "Zapatos",
                            Precio = 49.99m,
                            Stock = 150
                        });
                });

            modelBuilder.Entity("GestionInventariosMVC.Models.Producto", b =>
                {
                    b.HasOne("GestionInventariosMVC.Models.Categoria", "Categoria")
                        .WithMany("Producto")
                        .HasForeignKey("CodigoCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("GestionInventariosMVC.Models.Categoria", b =>
                {
                    b.Navigation("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}

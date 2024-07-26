using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionInventariosMVC.Migrations
{
    /// <inheritdoc />
    public partial class Creacionestructurabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CodigoCategoria = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CodigoCategoria",
                        column: x => x.CodigoCategoria,
                        principalTable: "Categorias",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Codigo", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { "CAT_ALIMENTOS", "Alimentos", "Alimentos" },
                    { "CAT_ELECTRONICA", "Electrónica", "Electrónica" },
                    { "CAT_ROPA", "Ropa", "Ropa" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Codigo", "CodigoCategoria", "Descripcion", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { "PROD_0000", "CAT_ELECTRONICA", "Smartphone", "Smartphone", 299.99m, 50 },
                    { "PROD_0001", "CAT_ROPA", "Camisa", "Camisa", 19.99m, 200 },
                    { "PROD_0002", "CAT_ALIMENTOS", "Pan", "Pan", 1.99m, 100 },
                    { "PROD_0003", "CAT_ELECTRONICA", "Laptop", "Laptop", 799.99m, 30 },
                    { "PROD_0004", "CAT_ROPA", "Zapatos", "Zapatos", 49.99m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CodigoCategoria",
                table: "Productos",
                column: "CodigoCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}

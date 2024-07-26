using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionInventarioEntities.DTO
{
    public class ProductoDto
    {
        [Key]
        public string CodigoProducto { get; set; }

        [StringLength(50, MinimumLength = 4, ErrorMessage = "El nombre del producto debe contener entre 4 y 50 caracteres")]        
        [Required(ErrorMessage = "El campo nombre del producto es requerido")]
        public string NombreProducto { get; set; } = string.Empty;

        public string DescripcionProducto { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "El precio del producto debe ser mayor a 0")]
        [Required(ErrorMessage = "El campo precio del producto es requerido")]
        public decimal PrecioProducto { get; set; } = 0.00M;

        [Range(0, int.MaxValue, ErrorMessage = "Las existencias del producto deben ser mayor o igual a 0")]
        [Required(ErrorMessage = "El campo existencias del producto es requerido")]
        public int Stock { get; set; } = 0;

        [Required]
        public string? CodigoCategoria { get; set; } = string.Empty;
    }
}

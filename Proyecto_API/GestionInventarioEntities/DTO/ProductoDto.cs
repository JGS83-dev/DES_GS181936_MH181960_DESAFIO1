using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionInventarioEntities.DTO
{
    public class ProductoDto
    {
        [Key]
        public string CodigoProducto { get; set; }        

        [Range(0, int.MaxValue, ErrorMessage = "Las existencias del producto deben ser mayor o igual a 0")]
        [Required(ErrorMessage = "El campo existencias del producto es requerido")]
        public int StockProducto { get; set; } = 0;       
    }
}

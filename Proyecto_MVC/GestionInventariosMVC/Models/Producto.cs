using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionInventariosMVC.Models
{
    public class Producto
    {
        [Key]
        public string Codigo { get; set; }

        [StringLength(50,MinimumLength = 4,ErrorMessage = "El nombre del producto debe contener entre 4 y 50 caracteres")]
        [Display(Name = "Nombre Producto")]
        [Required(ErrorMessage = "El campo nombre del producto es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción Producto")]
        public string? Descripcion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "El precio del producto debe ser mayor a 0")]
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo precio del producto es requerido")]
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Las existencias del producto deben ser mayor o igual a 0")]
        [Display(Name = "Existencias")]
        [Required(ErrorMessage = "El campo existencias del producto es requerido")]
        public int Stock { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public string? CodigoCategoria { get; set; }

        public Categoria? Categoria { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GestionInventariosMVC.Models
{
    public class Categoria
    {
        [Key]
        public string Codigo { get; set; }

        [StringLength(50, MinimumLength = 4, ErrorMessage = "El nombre de la categoria debe contener entre 4 y 50 caracteres")]
        [Display(Name = "Nombre Categoria")]
        [Required(ErrorMessage = "El campo nombre de la categoria es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción Categoria")]
        public string? Descripcion { get; set; }

        public ICollection<Producto>? Producto { get; set; }
    }
}

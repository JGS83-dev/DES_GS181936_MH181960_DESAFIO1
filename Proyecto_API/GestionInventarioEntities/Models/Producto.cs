using System.ComponentModel.DataAnnotations;

namespace GestionInventarioEntities.Models
{
    public class Producto
    {
        [Key]
        public string Codigo { get; set; }
        
        public int Stock { get; set; }        
    }
}

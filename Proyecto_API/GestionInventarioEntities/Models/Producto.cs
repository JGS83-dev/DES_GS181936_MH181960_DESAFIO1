using System.ComponentModel.DataAnnotations;

namespace GestionInventarioEntities.Models
{
    public class Producto
    {
        [Key]
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string? CodigoCategoria { get; set; }
    }
}

using GestionInventarioEntities.Models;

namespace GestionInventarioDAL.Interfaces
{
    public interface IProductoRepository
    {
        public Task<Producto> UpdateStockAsync(Producto producto);
    }
}

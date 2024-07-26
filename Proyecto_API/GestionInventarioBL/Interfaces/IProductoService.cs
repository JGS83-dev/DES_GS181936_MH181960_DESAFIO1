using GestionInventarioEntities.DTO;

namespace GestionInventarioBL.Interfaces
{
    public interface IProductoService
    {
        public Task<ProductoDto> UpdateStockAsync(ProductoDto producto);
    }
}

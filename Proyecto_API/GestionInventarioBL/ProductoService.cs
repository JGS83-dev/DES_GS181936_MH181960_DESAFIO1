using AutoMapper;
using GestionInventarioBL.Interfaces;
using GestionInventarioDAL.Interfaces;
using GestionInventarioEntities.DTO;
using GestionInventarioEntities.Models;

namespace GestionInventarioBL
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository repository;
        private readonly IMapper mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ProductoDto> UpdateStockAsync(ProductoDto model)
        {
            try
            {
                var entity = mapper.Map<ProductoDto, Producto>(model);
                var result = await repository.UpdateStockAsync(entity);
                return mapper.Map<Producto, ProductoDto>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

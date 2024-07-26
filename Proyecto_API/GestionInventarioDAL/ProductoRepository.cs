using Dapper;
using GestionInventarioDAL.Interfaces;
using GestionInventarioEntities.Models;

namespace GestionInventarioDAL
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public ProductoRepository(IDatabaseRepository databaseRepository)
        {
            this.databaseRepository = databaseRepository;
        }

        public async Task<Producto> UpdateStockAsync(Producto producto)
        {
            string query = "UPDATE Productos SET Stock = @Stock WHERE Codigo = @Codigo";
            var parameters = new DynamicParameters();
            parameters.Add("@Codigo", producto.Codigo);
            parameters.Add("@Stock", producto.Stock);
            await databaseRepository.UpdateAsync<Producto>(query, parameters);
            return producto;
        }
    }
}

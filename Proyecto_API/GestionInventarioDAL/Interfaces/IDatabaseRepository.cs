using Dapper;

namespace GestionInventarioDAL.Interfaces
{
    public interface IDatabaseRepository
    {
        public Task<T> UpdateAsync<T>(string storeProcedure, DynamicParameters? parameters = null);
    }
}

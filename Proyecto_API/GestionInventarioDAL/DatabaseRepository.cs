using Dapper;
using GestionInventarioCommon;
using GestionInventarioDAL.Interfaces;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace GestionInventarioDAL
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private readonly string connectionString;

        public DatabaseRepository(IOptions<AppSettings> appSettings)
        {
            connectionString = appSettings.Value.ConnectionString;
        }

        public async Task<T?> UpdateAsync<T>(string query, DynamicParameters? parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<T>(query, parameters);
                    connection.Close();
                    if (result != null && result.Any())
                    {
                        return result.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta de actualizar: " + ex.Message);
            }
            return default;
        }
    }
}

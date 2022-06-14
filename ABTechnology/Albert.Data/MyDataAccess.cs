using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;
namespace Albert.Data
{
    /// <summary>
    /// A special class to Access MySQL Data  
    /// </summary>
    public class MyDataAccess
    {
        public static async Task<List<T>> LoadData<T, U>(string _sql, U _parameters, string _connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionString))
            {
               var rows = await connection.QueryAsync<T>(_sql, _parameters);
                return rows.ToList();
            }
        }

        public Task SaveData<T>(string _sql,T _paremters,string _connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionString))
            {
               return connection.ExecuteAsync(_sql, _paremters);
            }
        }

        
    }
}


namespace Albert.Data
{
    /// <summary>
    /// Interfce to implment data acess 
    /// </summary>
    public interface IMyDataAccess
    {
        Task<List<T>> LoadData<T,U>(string _sql, U _paremters,string _connectionString);
        Task SaveData<T>(string _sql,T _paremters, string _connectionString);
    }
}

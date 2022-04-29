namespace DataAccessLibrary
{
    public class SqlDataAccessBase
    {
        public async Task GetData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            using (System.Data.IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
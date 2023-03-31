using Microsoft.Data.Sqlite;
using System.Data.Common;

namespace Financeiro.Data
{
    public class DataSqlite
    {
        public async Task<DbConnection> OpenConnectionAsync()
        {
            var connection = new SqliteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}Financeiro.db;Version=3;");
            await connection.OpenAsync();
            return connection;
        }
    }
}

using Microsoft.Data.Sqlite;
using SQLitePCL;
using System.Data.Common;

namespace Financeiro.Data
{
    public class DataSqlite
    {
        public async Task<DbConnection> OpenConnectionAsync()
        {

            if (DatabaseExists())
            {
                var connection = new SqliteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}Financeiro.db");
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());

                await connection.OpenAsync();
                return connection;
            }

            throw new Exception("Database not found");

        }

        private bool DatabaseExists()
        {
            return File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}Financeiro.db");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Data
    {
        public async Task<DbConnection> OpenConnectionAsync()
        {
            var connection = new SQLiteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}Financeiro.db;Version=3;");
            await connection.OpenAsync();
            return connection;
        }
    }
}

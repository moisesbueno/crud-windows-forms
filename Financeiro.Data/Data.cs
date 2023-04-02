
using Dapper;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System.Data.Common;

namespace Financeiro.Data
{
    public class DataSqlite
    {
        public async Task<DbConnection> OpenConnectionAsync()
        {

            if (!DatabaseExists())
            {
                CreateDatabase();
                await CreateTableAsync();
            }
               

            var connection = new SqliteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}Financeiro.db");
            SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());

            await connection.OpenAsync();
            return connection;


        }

        private bool DatabaseExists()
        {
            return File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}Financeiro.db");
        }

        private void CreateDatabase()
        {
            using (File.Create($"{AppDomain.CurrentDomain.BaseDirectory}Financeiro.db")) ;
        }

        private async Task CreateTableAsync()
        {
            var sql = @"CREATE TABLE `tb_lancamentos` (
	                                    `Id`	INTEGER,
	                                    `Data`	DateTime,
	                                    `Hora`	TEXT,
	                                    `Terminal`	TEXT,
	                                    `Controle`	TEXT,
	                                    `ContaCreditada`	TEXT,
	                                    `Nome`	TEXT,
	                                    `Valor`	decimal(10,2),
	                                    `NumeroEnvelope`	TEXT,
	                                    `NumeroControle`	TEXT,
	                                    PRIMARY KEY(`Id`)
                                    )";

            using var connection = await OpenConnectionAsync();
            var command = connection.ExecuteAsync(sql);
        }
    }
}
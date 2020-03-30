using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbSqLite
    {
        private static readonly DbSqLite instance = new DbSqLite();

        private DbSqLite() { }

        public static DbSqLite GetInstance() => instance;

        public SQLiteConnection GetConnection()
        {
            var connectionString = "Data Source = "+ AppDomain.CurrentDomain.BaseDirectory + "Financeiro.db;" + " Version = 3; ";

            //"Data Source=c:\\dados\\Cadastro.sqlite; 
            return new SQLiteConnection(connectionString);
        }
    }
}

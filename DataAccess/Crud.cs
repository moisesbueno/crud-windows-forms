using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Data;
using System.Dynamic;
using System;
using System.Data.SQLite;
using System.Linq;

namespace DataAccess
{
    public static class Crud<T> where T : class, IEntity, new()
    {
        #region Insert
        public static int Insert(T entidade)
        {
            string nomeTabela = typeof(T).GetCustomAttribute<TableAttribute>().Nome;

            StringBuilder sql = new StringBuilder();

            List<SQLiteParameter> parametros = new List<SQLiteParameter>();
     

            foreach (var c in GetColumns())
            {
                string auxiliar = string.Empty;
                if (c.GetValue(entidade) != null)
                {
                    auxiliar = $"@{c.Name.ToUpper()},";
                    sql.Append(auxiliar);
                    parametros.Add(new SQLiteParameter(auxiliar.Replace(",", ""), c.GetValue(entidade)));
                }
            }

            var campos = sql.ToString().Substring(0, sql.Length - 1);

            var sqlInsert = $"INSERT INTO {nomeTabela} ({campos.Replace("@", "")}) VALUES ({campos})";

            using (SQLiteConnection conexao = DbSqLite.GetInstance().GetConnection())
            {
                conexao.Open();
                using (SQLiteTransaction transacao = conexao.BeginTransaction())
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Parameters.AddRange(parametros.ToArray());
                    command.Connection = conexao;
                    command.Transaction = transacao;
                    command.CommandText = sqlInsert;
                    var id = Convert.ToInt32(command.ExecuteScalar());
                    transacao.Commit();
                    return id;
                }
            }
        }
        #endregion

        #region Delete
        public static void Delete(int id, string key = "")
        {
            using (SQLiteConnection conexao = DbSqLite.GetInstance().GetConnection())
            {
                string aux = "";

                if (key == "")
                    aux = "WHERE Id";
                else
                    aux = $"WHERE {key}";

                conexao.Open();
                using (SQLiteTransaction transacao = conexao.BeginTransaction())
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexao;
                    command.Transaction = transacao;
                    command.CommandText = $"DELETE FROM {GetTableName()} {aux} = {id} ";
                    command.ExecuteNonQuery();
                    transacao.Commit();
                }
            }
        }
        #endregion

        #region Update
        public static void Update(T entidade)
        {

            StringBuilder consulta = new StringBuilder();
            consulta.Append($"UPDATE {GetTableName()} SET ");

            List<SQLiteParameter> parametros = new List<SQLiteParameter>();

            foreach (var e in GetColumns())
            {
                if (e.GetValue(entidade) != null)
                {
                    consulta.Append($"{e.Name.ToLower()} = @{e.Name.ToLower()},");
                    parametros.Add(new SQLiteParameter($"@{e.Name.ToLower()}", e.GetValue(entidade)));
                }
            }
            consulta.Remove(consulta.Length - 1, 1).Append($" WHERE Id = {entidade.Id}");


            using (SQLiteConnection conexao = DbSqLite.GetInstance().GetConnection())
            {
                conexao.Open();
                using (SQLiteTransaction transacao = conexao.BeginTransaction())
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Parameters.AddRange(parametros.ToArray());
                    command.Connection = conexao;
                    command.Transaction = transacao;
                    command.CommandText = consulta.ToString();
                    command.ExecuteNonQuery();
                    transacao.Commit();
                }
            }
        }
        #endregion

        #region Select
        public static List<T> Select(int id = 0)
        {
            string sql = $"Select * from {GetTableName()}";

            if (id != 0) sql += $" WHERE Id = {id}";

            var colunas = typeof(T).GetProperties();//.Where(p => !p.IsDefined(typeof(WritableAttribute)));
            List<T> lista = new List<T>();
            using (SQLiteConnection conexao = DbSqLite.GetInstance().GetConnection())
            {
                conexao.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = sql;
                    var reader = command.ExecuteReader();

                    IDictionary<string, object> dictionary = null;

                    while (reader.Read())
                    {
                        dynamic person = new ExpandoObject();

                        dictionary = (IDictionary<string, object>)person;

                        foreach (var c in colunas) dictionary.Add(c.Name, reader[c.Name]);

                        lista.Add(Conversor.ConvertDictionaryTo<T>(dictionary));

                    }
                }
                return lista;
            }
        }
        #endregion

        public static DataTable GetDataTable(int id = 0)
        {
            string sql = $"Select * from {GetTableName()}";
            if (id != 0) sql += $" WHERE Id = {id}";
            using (SQLiteConnection connection = DbSqLite.GetInstance().GetConnection())
            {
                connection.Open();
                SQLiteDataAdapter fbData = new SQLiteDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                fbData.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable GetDataTable(string coluna, int id = 0)
        {
            string sql = $"Select * from {GetTableName()} WHERE {coluna}";

            if (id != 0) sql += $"= {id}";

            using (SQLiteConnection connection = DbSqLite.GetInstance().GetConnection())
            {
                connection.Open();
                SQLiteDataAdapter fbData = new SQLiteDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                fbData.Fill(dataTable);
                return dataTable;
            }
        }

        public static int GetNextId()
        {
            ///var generator = typeof(T).GetCustomAttribute<GeneratorAttribute>().Generator;
            using (SQLiteConnection connection = DbSqLite.GetInstance().GetConnection())
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT max(id) from {GetTableName()}", connection))
                {
                    var reader = cmd.ExecuteScalar();
                    return Convert.IsDBNull(reader) ? 1 : Convert.ToInt32(reader) + 1;
                }
            }
        }

        private static string GetTableName() => typeof(T).GetCustomAttribute<TableAttribute>().Nome;

        private static IEnumerable<PropertyInfo> GetColumns()
        {
            return typeof(T).GetProperties().Where(c => c.Name != "Id");
        }
    }
}

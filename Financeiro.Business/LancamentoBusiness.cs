using Dapper;
using Financeiro.Data;
using Financeiro.Model;

namespace Financeiro.Business
{
    public class LancamentoBusiness
    {
        public async Task InsertAsync(Lancamento lancamento)
        {
            using (var connection = await new DataSqlite().OpenConnectionAsync())
            {
                var sql = @"INSERT INTO tb_lancamentos(Id,Data,Hora,Terminal,Controle,ContaCreditada,Nome,Valor,NumeroEnvelope,NumeroControle)
                          VALUES (@Id,@Data,@Hora,@Terminal,@Controle,@ContaCreditada,@Nome,@Valor,@NumeroEnvelope,@NumeroControle);";

                var result = await connection.ExecuteAsync(sql, lancamento);
            }

        }

        public async Task UpdateAsync(Lancamento lancamento)
        {

            using (var connection = await new DataSqlite().OpenConnectionAsync())
            {

                var sql = @"UPDATE tb_lancamentos SET Data=@Data,Hora=@Hora,Terminal=@Terminal,Controle=@Controle,ContaCreditada=@ContaCreditada,Nome=@Nome,Valor=@Valor,NumeroEnvelope=@NumeroEnvelope,NumeroControle=@NumeroControle
                            WHERE Id=@Id";


                var result = await connection.ExecuteAsync(sql, lancamento);
            }

        }

        public async Task RemoveAsync(int id)
        {
            using (var connection = await new DataSqlite().OpenConnectionAsync())
            {
                var result = await connection.ExecuteAsync("DELETE FROM tb_lancamentos WHERE Id = @Id", new { id });
            }
        }
        
        public async Task<IEnumerable<Lancamento>> ListAsync()
        {
            using (var connection = await new DataSqlite().OpenConnectionAsync())
            {
                return await connection.QueryAsync<Lancamento>("SELECT * FROM tb_lancamentos");
            }
        }

        public async Task<Lancamento> GetAsync(int id)
        {
            using (var connection = await new DataSqlite().OpenConnectionAsync())
            {
                var result = await connection.QueryFirstOrDefaultAsync<Lancamento>("SELECT * FROM  tb_lancamentos WHERE Id = @Id", new { id });

                return result;
            }
        }

        public async Task<int> NextIdAsync()
        {
            using (var connection = await new DataSqlite().OpenConnectionAsync())
            {
                var result = await connection.ExecuteScalarAsync<int>("SELECT max(id) from tb_lancamentos");

                if (result == 0) result = 1;
                return result;
            }

        }
    }
}
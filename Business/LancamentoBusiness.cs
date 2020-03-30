using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class LancamentoBusiness
    {
        public static void Inserir(Lancamento lancamento)
        {
            Crud<Lancamento>.Insert(lancamento);
        }

        public static void Apagar(int id)
        {
            Crud<Lancamento>.Delete(id);
        }
        public static void Atualizar(Lancamento lancamento)
        {
            Crud<Lancamento>.Update(lancamento);
        }
        public static List<Lancamento> GetLancamentos()
        {
           // var temp = Crud<Lancamento>.Select().OrderBy(c => c.Data).ToList();

            return Crud<Lancamento>.Select().OrderBy(c => c.Data).ToList();
        }

        public static Lancamento GetLancamento(int id)
        {
            var obj = Crud<Lancamento>.Select(id);
            if (obj.Count > 0)
            {
                return obj.First();
            }
            else
            {
                return null;
            }
        }

        public static string GetNextId()
        {
            return Crud<Lancamento>.GetNextId().ToString();
        }
    }
}

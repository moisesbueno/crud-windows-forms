using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    [Table(Nome ="tb_lancamentos")]
    public class Lancamento:IEntity
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Terminal { get; set; }
        public string Controle { get; set; }
        public string ContaCreditada { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string NumeroEnvelope { get; set; }
        public string NumeroControle { get; set; }
    }
}

using System;
namespace Model
{

    public class Lancamento
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

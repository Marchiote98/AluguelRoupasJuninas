using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelRoupasJuninas
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int IdRoupa { get; set; }
        public DateTime DataAluguel{ get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Cliente { get; set; }
        public double Valor { get; set; }
        public string FormaPagamento { get; set; }
        public bool Devolucao { get; set; }
    }
}

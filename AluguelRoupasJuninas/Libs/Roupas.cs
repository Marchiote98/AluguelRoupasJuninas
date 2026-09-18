using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace AluguelRoupasJuninas
{
    public class Roupa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string CaminhoImagem { get; set; }
        public string Categoria { get; set; }
        public List<DateTime> DatasIndisponiveis { get; set; } = new List<DateTime>();
    };

}

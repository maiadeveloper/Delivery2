using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class Caixa
    {
        public int CaixaId { get; set; }
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public decimal? ValorInicial { get; set; }
        public decimal? ValorFinal { get; set; }
        public bool Situacao { get; set; }
    }
}

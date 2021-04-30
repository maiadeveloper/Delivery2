using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class MovimentacaoContaCorrente
    {
        public int MovimentacaoContaCorrenteId { get; set; }
        public int? ContaCorrenteId { get; set; }
        public DateTime DataHoraMovimentacao { get; set; }
        public string TipoMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public virtual IEnumerable<ItensPedido> ItensPedidos { get; set; }
        public virtual ContaCorrente ContaCorrente { get; set; }
    }
}

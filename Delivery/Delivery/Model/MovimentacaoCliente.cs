using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class MovimentacaoCliente
    {
        public int Id { get; set; }

        public int? PedidoId { get; set; }

        public int? ClienteId { get; set; }

        public string TipoMovimentacao { get; set; }

        public decimal ValorCredito { get; set; }

        public decimal ValorDebito{ get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Cliente Cliente { get; set; }

        public DateTime DataHora { get; set; }
    }
}

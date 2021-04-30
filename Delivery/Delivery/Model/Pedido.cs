using System;
using System.Collections.Generic;

namespace Delivery.Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public DateTime? DataHoraPgto { get; set; }
        public DateTime? DataHoraInicio { get; set; }
        public DateTime? DataRetornoEntregaPacote { get; set; }
        public int? ClienteId { get; set; }
        public int? FuncionarioId { get; set; }//Utilizado para especificar o entregar
        public int? FormaPagamentoId { get; set; }
        public int? OperadorId { get; set; }
        public string TipoPedido { get; set; }//Pedido balcão-Mesa-Entrega
        public decimal? TaxaEntrega { get; set; }
        public decimal? VlrDesconto { get; set; }
        public decimal? VlrTotal { get; set; }
        public decimal? VlrTotalFinal { get; set; }//Recebe resultado de (VlrTotal-VlrDesconto)
        public string Situacao { get; set; }//Aberto - Fechado
        public bool IsExcluir { get; set; }
        public bool IsPcte { get; set; }
        public string DiasEntrega { get; set; }
        public bool IsBloquearEntrega { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual IEnumerable<ItensPedido> ItensPedidos { get; set; }
    }
}

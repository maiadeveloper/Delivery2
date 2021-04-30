using System;
namespace Delivery.Model
{
    public class ItensPedido
    {
        public int ItensPedidoId { get; set; }
        public int? Item { get; set; }
        public int? PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Qtde { get; set; }
        public DateTime? DataConsumo{get;set;}
        public bool IsConsumo { get; set; }
        public bool IsPctItem { get; set; }
        public bool IsChecked { get; set; }
        public decimal VlrUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}

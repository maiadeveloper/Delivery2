using System;

namespace Delivery.Model
{
    public class FormaPagamento
    {
        public int FormaPagamentoId { get; set; }
        public string Nome { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO
        public DateTime DataHora { get; set; }
    }
}

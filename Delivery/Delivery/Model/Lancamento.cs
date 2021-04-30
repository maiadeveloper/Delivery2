using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class Lancamento
    {
        [Key]
        public int LancamentoID { get; set; }
        public string NumParcela { get; set; }
        public string TipoLancamento { get; set; }
        public int FornecedorId { get; set; }
        public int CategoriaLancamentoID { get; set; }
        public int SubCategoriaLancamentoID { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Descricao { get; set; }
        public string NumDoc { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPgto { get; set; }
        public decimal ValorPrincipal { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorDesconto { get; set; }
        public string Situacao { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual SubCategoriaLancamento SubCategoriaLancamento { get; set; }
        public virtual CategoriaLancamento CategoriaLancamento { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}

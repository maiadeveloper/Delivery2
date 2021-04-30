using System;

namespace Delivery.Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public DateTime DataHora { get; set; }
        public string CodigoBarra { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPcteSemanal { get; set; }
        public decimal ValorPcteQuinzenal { get; set; }
        public decimal ValorPcteMensal { get; set; }
        public decimal CustoAdicional { get; set; }
        public decimal DescMax { get; set; }
        public decimal DescProm { get; set; }
        public int CategoriaId { get; set; }
        public string Obs { get; set; }
        public virtual Categoria Categoria { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO

    }
}

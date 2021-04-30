using System;
using System.Collections.Generic;

namespace Delivery.Model
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO
        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}

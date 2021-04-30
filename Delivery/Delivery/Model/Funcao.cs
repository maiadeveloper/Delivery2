using System;
using System.Collections.Generic;

namespace Delivery.Model
{
    public class Funcao
    {
        public int FuncaoId { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO
        public DateTime DataHora { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Funcionario> Funcionarios { get; set; }
    }
}

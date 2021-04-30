using System;
using System.Collections.Generic;

namespace Delivery.Model
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string GrauInstrucao { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Municipio { get; set; }
        public string FoneResidencial { get; set; }
        public string Celular { get; set; }
        public string FoneComercial { get; set; }
        public string Email { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int QtdeFilhos { get; set; }
        public string Conjuge { get; set; }
        public string PathFoto { get; set; }
        public string Situcao { get; set; }
        public int FuncaoId { get; set; }

        public virtual Funcao Funcao { get; set; }
    }
}

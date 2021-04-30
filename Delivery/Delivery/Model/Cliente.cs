using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Delivery.Model
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO
        public DateTime DataHora { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string Documento { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string Celular { get; set; }
        public virtual IEnumerable<Endereco> Enderecos { get; set; }
        public virtual IEnumerable<Restricoes> Restricoes { get; set; }
    }
}

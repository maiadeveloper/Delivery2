using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class ContaCorrente
    {
        public int ContaCorrenteId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string DescricaoContaCorrente { get; set; }
        public int BancoId { get; set; }
        public string Agencia { get; set; }
        public string NumeroCC { get; set; }
        public virtual Banco Banco { get; set; }
        public decimal Saldo { get; set; }
        public virtual IEnumerable<MovimentacaoContaCorrente> MovimentacaoContaCorrentes { get; set; }
    }
}

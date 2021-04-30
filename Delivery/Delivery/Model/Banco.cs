using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class Banco
    {
        public int BancoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<ContaCorrente> ContaCorrentes { get; set; }
    }
}

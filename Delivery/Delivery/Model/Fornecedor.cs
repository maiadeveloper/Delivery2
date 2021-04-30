using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public DateTime DataHora { get; set; }
        public string CNPJCPF { get; set; }
        public String Razao { get; set; }
        public string Fantasia { get; set; }
    }
}

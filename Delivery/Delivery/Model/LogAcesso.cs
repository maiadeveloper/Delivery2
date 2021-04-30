using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class LogAcesso
    {
        public int LogAcessoId { get; set; }
        public int OperadorId { get; set; }
        public DateTime DataHora { get; set; }
        public virtual Operador Operador { get; set; }
    }
}

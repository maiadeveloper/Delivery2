using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class TipoDocumento
    {
        public int TipoDocumentoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO
    }
}

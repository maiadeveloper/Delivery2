using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Model
{
    public class CategoriaLancamento
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
    }
}

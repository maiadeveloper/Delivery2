using System.ComponentModel.DataAnnotations;

namespace Delivery.Model
{
    public class ConfiguracaoSistema
    {
        [Key]
        public int ConfiguracaoID { get; set; }

        public bool IsBackup { get; set; }

        public bool IsImprimirEtiqueta { get; set; }

        public bool IsEnderecoRodapeRecibo { get; set; }
    }
}

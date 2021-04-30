using System;

namespace Delivery.Model
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public DateTime DataHora { get; set; }
        public string CNPJ { get; set; }
        public String Razao { get; set; }
        public string Fantasia { get; set; }
        public string PathLogoMarca { get; set; }
        public bool ConfirmaImpressao { get; set; }
        public int QtdeImpressao { get; set; }
    }
}

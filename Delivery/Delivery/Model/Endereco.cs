namespace Delivery.Model
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public int? ClienteId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string EntreRua { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string PontoRef { get; set; }
        public bool IsEnderecoEntrega { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}

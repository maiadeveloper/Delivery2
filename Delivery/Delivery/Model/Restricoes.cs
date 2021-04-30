
namespace Delivery.Model
{
    public class Restricoes
    {
        public int id { get; set; }
        public int? ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}

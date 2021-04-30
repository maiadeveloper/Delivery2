using Delivery.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Delivery.DataContext
{
    public class MyDataContextConfiguration : DbContext
    {
        public MyDataContextConfiguration()
            : base("name=MyDataContextConfiguration")
        {
        }

        public DbSet<Sistema> Sistemas { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Funcao> Funcoes { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItensPedido> ItensPedidos { get; set; }

        public DbSet<Operador> Operadores { get; set; }

        public DbSet<Restricoes> Restricoes { get; set; }

        public DbSet<MovimentacaoCliente> MovimentacoesCliente { get; set; }

        public DbSet<Sangria> Sangrias { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Lancamento> Lancamentos { get; set; }

        public DbSet<CategoriaLancamento> CategoriaLancamento { get; set; }

        public DbSet<SubCategoriaLancamento> SubCategoriaLancamento { get; set; }

        public DbSet<LogAcesso> LogAcessos { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
  
        public DbSet<Banco> Bancos { get; set; }

        public DbSet<ContaCorrente> ContaCorrentes { get; set; }

        public DbSet<MovimentacaoContaCorrente> MovimentacoesContaCorrentes { get; set; }

        public DbSet<ConfiguracaoSistema> ConfiguracoesSistema { get; set; }

        public DbSet<Caixa> Caixa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}

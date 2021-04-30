using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBaseRletorioGeralPedidosProduto : Form
    {
        public frmBaseRletorioGeralPedidosProduto()
        {
            InitializeComponent();
        }

        StringBuilder sbItemPedido = new StringBuilder();


        public void CarregaListaPedido(IList<Pedido> pedidos)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                foreach (var item in pedidos)
                {
                    int cont = 1;
                    string dataHora = item.Data.ToString("dd/MM/yyyy");

                    var itensPedidos = db.ItensPedidos.Where(i => i.PedidoId == item.PedidoId).ToList();

                    //Adiciona o item do pedido                 
                    foreach (var itemPedido in itensPedidos)
                    {

                        sbItemPedido.Append("Item" + cont + ": " + itemPedido.Produto.Nome + "  ");
                        cont++;
                    }

                    item.Cliente.Nome = item.ClienteId == null ? "CLIENTE AVULSO" : item.Cliente.Nome;

                    DataSetRelatorios.PedidoProduto.AddPedidoProdutoRow(item.PedidoId.ToString(), dataHora, item.Cliente.Nome, sbItemPedido.ToString());
                    sbItemPedido.Clear();

                }

                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
        }

        private void frmBaseRletorioGeralPedidosProduto_Load(object sender, EventArgs e)
        {
        }
    }
}

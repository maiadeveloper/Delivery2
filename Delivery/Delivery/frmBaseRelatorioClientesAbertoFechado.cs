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
    public partial class frmBaseRelatorioClientesAbertoFechado : Form
    {
        public frmBaseRelatorioClientesAbertoFechado()
        {
            InitializeComponent();
        }

        public void CarregaRelatorio(DateTime dtInicial, DateTime dtFinal, int? parametroCliente, string status)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                List<Pedido> pedidos = null;

                if (parametroCliente == null && status.Equals("Todos"))
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false).OrderBy(p => p.Data).ToList();
                    pedidos = lista;
                }
                else if (parametroCliente == null && status != "Todos")
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false && p.Situacao.Equals(status)).OrderBy(p => p.Data).ToList();
                    pedidos = lista;
                }
                else if (parametroCliente != null && status.Equals("Todos"))
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false && p.ClienteId == parametroCliente).OrderBy(p => p.Data).ToList();
                    pedidos = lista;
                }
                else if (parametroCliente != null && status != "Todos")
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false && p.ClienteId == parametroCliente && p.Situacao.Equals(status)).OrderBy(p => p.Data).ToList();
                    pedidos = lista;
                }

                string dataHora, cliente, formaPgto, vlrTotal, vlrDesconto, vlrTaxa, situacao;
                double vlrTotalPagar;

                foreach (var item in pedidos.Where(p => p.IsExcluir == false))
                {
                    dataHora = item.Data.ToString("dd/MM/yyyy");
                    cliente = item.Cliente.Nome;
                    formaPgto = item.FormaPagamentoId == null ? string.Empty : item.FormaPagamento.Nome;
                    vlrTotal = Convert.ToDecimal(item.VlrTotal).ToString("C");
                    vlrTaxa = Convert.ToDecimal(item.TaxaEntrega).ToString("C");
                    vlrDesconto = Convert.ToDecimal(item.VlrDesconto).ToString("C");
                    vlrTotalPagar = Convert.ToDouble(item.VlrTotalFinal);
                    situacao = item.Situacao;

                    DataSetRelatorios.Pedido.AddPedidoRow(dataHora, situacao, cliente, formaPgto, vlrTotal, vlrTaxa, vlrDesconto, vlrTotalPagar);
                }

                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
        }

        private void frmBaseRelatorioClientesAbertoFechado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

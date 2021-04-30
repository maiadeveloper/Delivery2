using Delivery.DataContext;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBaseRletorioGeralPedidos : Form
    {
        public frmBaseRletorioGeralPedidos()
        {
            InitializeComponent();
        }

        private void frmBaseReportPedidoEntrega_Load(object sender, EventArgs e)
        {
        }

        public void CarregaRelatorio(DateTime dtInicial, DateTime dtFinal)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedidos = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false).OrderBy(p => p.Data).ToList();

                string dataHora, cliente, formaPgto, vlrTotal, vlrDesconto, vlrTaxa;
                double vlrTotalPagar;

                foreach (var item in pedidos)
                {
                    dataHora = item.Data.ToString("dd/MM/yyyy");
                    cliente = item.ClienteId == null ? "Cliente avulso" : item.Cliente.Nome;
                    formaPgto = item.FormaPagamento.Nome;
                    vlrTotal = Convert.ToDecimal(item.VlrTotal).ToString("C");
                    vlrTaxa = Convert.ToDecimal(item.TaxaEntrega).ToString("C");
                    vlrDesconto = Convert.ToDecimal(item.VlrDesconto).ToString("C");
                    vlrTotalPagar = Convert.ToDouble(item.VlrTotalFinal);

                    DataSetRelatorios.Pedido.AddPedidoRow(dataHora,item.Situacao, cliente, formaPgto, vlrTotal, vlrTaxa, vlrDesconto, vlrTotalPagar);
                }

                //List<ReportParameter> parametros = new List<ReportParameter>();
                //parametros.Add(new ReportParameter("DataInicial", dtInicial.ToString()));
                //this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", dtInicial.ToString()));
                //this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFim", dtFinal.ToString()));
                //this.reportViewer1.LocalReport.SetParameters(parametros);

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

                this.reportViewer1.RefreshReport();
            }
        }

        private void frmBaseRletorioGeralPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

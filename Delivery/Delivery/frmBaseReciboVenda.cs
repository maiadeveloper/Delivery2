using Delivery.DataContext;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBaseReciboVenda : Form
    {
        public frmBaseReciboVenda()
        {
            InitializeComponent();
        }

        public void CarregaReciboVenda(int pedidoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var empresa = db.Empresas.FirstOrDefault();
                var pedido = db.Pedidos.Include("Cliente").FirstOrDefault(p => p.PedidoId == pedidoId);
                var endereco = db.Enderecos.Where(e => e.ClienteId == pedido.ClienteId && e.IsEnderecoEntrega == true).FirstOrDefault();
                var itensPedido = db.ItensPedidos.Where(p => p.PedidoId == pedidoId).ToList();

                int? produtoId = null;

                foreach (var itemX in itensPedido)
                {
                    if (pedido.IsPcte)
                    {
                        int? qtde = 0;

                        foreach (var itemY in itensPedido)
                        {
                            if (itemX.ProdutoId == itemY.ProdutoId)
                            {
                                qtde += 1;
                            }
                        }

                        if (itemX.ProdutoId != produtoId || produtoId == null)
                        {
                            DataSetRelatorios.ItensPedido.AddItensPedidoRow(itemX.ProdutoId.ToString(),
                                                    itemX.Produto.Nome,
                                                    qtde.ToString(),
                                                    itemX.VlrUnitario.ToString("N2"),
                                                    Convert.ToDecimal(itemX.VlrUnitario * qtde).ToString("N2"));
                        }

                        produtoId = itemX.ProdutoId;
                    }
                    else
                    {
                        DataSetRelatorios.ItensPedido.AddItensPedidoRow(itemX.ProdutoId.ToString(),
                                                   itemX.Produto.Nome,
                                                   itemX.Qtde.ToString(),
                                                   itemX.VlrUnitario.ToString("N2"),
                                                   Convert.ToDecimal(itemX.VlrUnitario * itemX.Qtde).ToString("N2"));
                    }
                }

                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("isEnderco", Util.IsIncluirEnderecoEntrega().ToString()));
                //Cabeçalho
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("empresa", empresa.Razao));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("cnpj", Util.FormatarDocumento("cnpj", empresa.CNPJ)));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("hora", pedido.Hora));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("data", pedido.Data.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("pedido", Util.AdicionaZero(pedido.PedidoId.ToString())));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("cliente", pedido.ClienteId == null ? "VENDA AVULSA" : pedido.Cliente.Nome));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("clienteDocumento", pedido.ClienteId == null ? "" : pedido.Cliente.Documento));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("entregador", pedido.Funcionario.Nome));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("formaPgto", pedido.FormaPagamento.Nome));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("celular", pedido.Cliente.Celular));

                //Endereço cliente
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("bairro", endereco == null ? "" : endereco.Bairro));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("numero", endereco == null ? "" : endereco.Numero));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("rua", endereco == null ? "" : endereco.Rua));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("complemento", endereco == null ? "" : endereco.Complemento));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("entreRua", endereco == null ? "" : endereco.EntreRua));


                //Rodapé
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("totalPedido", Convert.ToDecimal(pedido.VlrTotal).ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("taxaEntrega", Convert.ToDecimal(pedido.TaxaEntrega).ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("desconto", Convert.ToDecimal(pedido.VlrDesconto).ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("totalApagar", Convert.ToDecimal(pedido.VlrTotalFinal).ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("pagando", Convert.ToDecimal(pedido.VlrTotalFinal).ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("troco", "0,00"));

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
        }

        private void frmBaseReciboVenda_Load(object sender, EventArgs e)
        {
        }
    }
}

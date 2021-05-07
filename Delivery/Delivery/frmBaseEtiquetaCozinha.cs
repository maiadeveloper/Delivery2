using Delivery.DataContext;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBaseEtiquetaCozinha : Form
    {
        public frmBaseEtiquetaCozinha()
        {
            InitializeComponent();
        }

        public void CarregaEtiquetaCozinha(int pedidoId)
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

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
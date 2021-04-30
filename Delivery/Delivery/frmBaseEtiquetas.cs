using Delivery.DataContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBaseEtiquetas : Form
    {
        public frmBaseEtiquetas()
        {
            InitializeComponent();
        }

        private void frmBaseEtiquetas_Load(object sender, EventArgs e)
        {
        }


        public void ElaborarEtiquetas(List<int> pedidos)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                string enderecoCliente = string.Empty;
                int contador = 1;

                foreach (var item in pedidos.ToList())//passo 1
                {
                    var itemPedido = db.ItensPedidos.Find(item);

                    var cliente = db.Clientes.Where(c => c.ClienteId == itemPedido.Pedido.ClienteId).FirstOrDefault();

                    var enderecos = db.Enderecos.Where(e => e.ClienteId == itemPedido.Pedido.ClienteId).ToList();

                    string nome = cliente != null ? cliente.Nome : "CLIENTE AVULSO";

                    string restricao = string.Empty;

                    foreach (var endereco in enderecos)
                    {
                        if (endereco.IsEnderecoEntrega == true)
                        {
                            enderecoCliente = endereco.Rua + ", " + endereco.Numero + "," + endereco.Bairro + ", Complemento: " + endereco.Complemento;
                            break;
                        }
                    }

                    var restricoes = db.Restricoes.Where(r => r.ClienteId == itemPedido.Pedido.ClienteId && r.ProdutoId == itemPedido.ProdutoId).FirstOrDefault();

                    if (restricoes != null)
                    {
                        restricao = restricoes.Descricao;
                    }

                    string pedidoRestricao = itemPedido.Produto.Nome + "\n" + restricao;

                    DataSetRelatorios.Etiqueta.AddEtiquetaRow(nome, enderecoCliente, pedidoRestricao, contador);
                    contador++;
                }

                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
        }

        private void frmBaseEtiquetas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

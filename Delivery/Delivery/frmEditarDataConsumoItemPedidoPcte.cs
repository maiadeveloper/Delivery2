using Delivery.DataContext;
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
    public partial class frmEditarDataConsumoItemPedidoPcte : Form
    {
        public frmEditarDataConsumoItemPedidoPcte()
        {
            InitializeComponent();
        }

        int? id = null;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaItemPedidoPacoteIditar(int id)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var itemPedido = db.ItensPedidos.Find(id);

                if (itemPedido != null)
                {
                    this.id = itemPedido.ItensPedidoId;
                    txtDataAntigaConsumo.Text = itemPedido.DataConsumo == null ? "Não existe data para este item" : Convert.ToDateTime(itemPedido.DataConsumo).ToString("dd/MM/yyyy dddddddddddddd");
                    txtValorUnitario.Text = Convert.ToDecimal(itemPedido.VlrUnitario).ToString("C");
                    txtCodigo.Text = id.ToString();
                    txtproduto.Text = itemPedido.Produto.Nome;
                }
            }
        }

        protected string AdicionaZero(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var itemPedido = db.ItensPedidos.Find(id);

                if (MessageBox.Show("Tem certeza que deseja alterar a data de consumo ?", "Confirmação de alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (itemPedido.DataConsumo >= Convert.ToDateTime(txtNovaDataConsumo.Text))
                    {
                        MessageBox.Show("A nova data para consumo não pode ser igual nem retroativa a data antiga.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNovaDataConsumo.Focus();
                        return;
                    }

                    itemPedido.DataConsumo = Convert.ToDateTime(txtNovaDataConsumo.Text);

                    itemPedido.IsChecked = itemPedido.IsPctItem == true ? true : false;

                    db.SaveChanges();

                    MessageBox.Show("Data de consumo alterado com sucesso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void frmEditarDataConsumoItemPedidoPcte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

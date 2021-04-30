using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmTodosProdutos : Form
    {
        public Produto produto;

        int count = 0;

        bool campoBuscaFocus = false;

        public frmTodosProdutos()
        {
            InitializeComponent();
        }

        private void CarregaListagemProdutos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwProdutos.Items.Clear();
                txtQtdeItem.Clear();
                count = 0;

                var produtos = db.Produtos.Where(p => p.Nome.Contains(txtParametroBusca.Text)).ToList();

                if (produtos.Count != 0)
                {
                    lwProdutos.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var produto in produtos)
                    {
                        lwProdutos.Items.Add(produto.ProdutoId.ToString());
                        lwProdutos.Items[count].SubItems.Add(produto.CodigoBarra);
                        lwProdutos.Items[count].SubItems.Add(produto.Nome);
                        lwProdutos.Items[count].SubItems.Add(produto.Categoria.Nome);
                        lwProdutos.Items[count].SubItems.Add(produto.Valor.ToString("C"));
                        lwProdutos.Items[count].SubItems.Add(produto.ValorPcteSemanal.ToString("C"));
                        lwProdutos.Items[count].SubItems.Add(produto.ValorPcteQuinzenal.ToString("C"));
                        lwProdutos.Items[count].SubItems.Add(produto.ValorPcteMensal.ToString("C"));
                        count++;
                    }
                    txtQtdeItem.Text = lwProdutos.Items.Count.ToString();
                }
                else
                {
                    lwProdutos.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemProdutos();
        }

        private void frmTodosProdutos_Load(object sender, EventArgs e)
        {
            txtParametroBusca.Focus();
            CarregaListagemProdutos();
        }

        private void frmTodosProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lwProdutos.Items.Count > 0)
                {
                    try
                    {
                        if (int.Parse(lwProdutos.FocusedItem.SubItems[0].Text) > 0)
                        {
                            produto = new Produto();

                            produto.ProdutoId = int.Parse(lwProdutos.FocusedItem.SubItems[0].Text);
                            produto.CodigoBarra = lwProdutos.FocusedItem.SubItems[1].Text;
                            produto.Nome = lwProdutos.FocusedItem.SubItems[2].Text;
                            produto.Valor = decimal.Parse(lwProdutos.FocusedItem.SubItems[4].Text.Substring(2));
                            produto.ValorPcteSemanal = decimal.Parse(lwProdutos.FocusedItem.SubItems[5].Text.Substring(2));
                            produto.ValorPcteMensal = decimal.Parse(lwProdutos.FocusedItem.SubItems[7].Text.Substring(2));

                            this.Close();
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Por favor! Selecione o produto desejado\nou então pressione enter 2x para selecionar o primeiro item da lista", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lwProdutos.Focus();
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Down)
            {
                ListViewItem item = lwProdutos.FindItemWithText(txtParametroBusca.Text);

                if (item != null)
                {
                    if (campoBuscaFocus == true)
                    {
                        item.Selected = true;
                        lwProdutos.Focus();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;
            frmProduto frm = new frmProduto();
            frm.ShowDialog();
            pPrincipal.Visible = true;
            CarregaListagemProdutos();
        }

        private void lwProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lwProdutos.Items.Count > 0)
            {
                pPrincipal.Visible = false;
                int produtoId = Convert.ToInt32(lwProdutos.FocusedItem.SubItems[0].Text);
                frmProduto frm = new frmProduto();
                frm.CarregaProdutoSelecionado(produtoId);
                frm.ShowDialog();
                CarregaListagemProdutos();
                pPrincipal.Visible = true;
            }
        }
    }
}

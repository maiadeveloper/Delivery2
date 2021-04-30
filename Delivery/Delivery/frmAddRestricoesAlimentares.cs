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
    public partial class frmAddRestricoesAlimentares : Form
    {
        public frmAddRestricoesAlimentares()
        {
            InitializeComponent();
        }

        int? codigoCliente = null;
        int count = 0;
        Cliente cliente = null;

        private void btnIncluirRestricoes_Click(object sender, EventArgs e)
        {
            if (txtProdutos.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Selecione o produto desejado", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdutos.Focus();
                return;
            }

            if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe a descrição", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return;
            }

            lwRestricoesAlimentares.Items.Add(txtProdutos.SelectedValue.ToString());
            lwRestricoesAlimentares.Items[count].SubItems.Add(txtProdutos.Text);
            lwRestricoesAlimentares.Items[count].SubItems.Add(txtDescricao.Text);
            count++;

            txtProdutos.Text = "Selecionar...";
            txtDescricao.Clear();
            txtProdutos.Focus();
        }

        private void LimparCampos()
        {
            count = 0;
            lwRestricoesAlimentares.Items.Clear();
            codigoCliente = null;
            txtCelular.Clear();
            txtCodigo.Clear();
            txtCPF.Clear();
            txtDescricao.Clear();
            txtNomeCliente.Clear();
            txtProdutos.Text = "Selecionar...";       
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            if (cliente == null)
            {
                frmTodosClientes frm = new frmTodosClientes();
                frm.ShowDialog();

                if (frm.cliente != null)
                {
                    txtCodigo.Text = frm.cliente.ClienteId.ToString();
                    txtCPF.Text = frm.cliente.Documento;
                    txtNomeCliente.Text = frm.cliente.Nome;
                    txtCelular.Text = frm.cliente.Celular;
                    codigoCliente = frm.cliente.ClienteId;
                }
            }
        }

        private void frmAddRestricoesAlimentares_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F3)
            {
                BuscarCliente();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (codigoCliente == null)
            {
                MessageBox.Show("Informe o nome cliente desejado", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lwRestricoesAlimentares.Items.Count == 0)
            {
                MessageBox.Show("Informe ao menos um produto para restrição", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdutos.Focus();
                return;
            }

            SalvaItemsRestricoes();
        }

        private void frmAddRestricoesAlimentares_Load(object sender, EventArgs e)
        {
            CarregaComboProduto();
        }

        private void CarregaComboProduto()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var produto = db.Produtos.ToList();

                if (produto.Count > 0)
                {
                    txtProdutos.DataSource = produto.ToList();
                    txtProdutos.ValueMember = "ProdutoId";
                    txtProdutos.DisplayMember = "Nome";
                    txtProdutos.Text = "Selecionar...";
                }
            }
        }

        private void SalvaItemsRestricoes()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                for (int i = 0; i < lwRestricoesAlimentares.Items.Count; i++)
                {
                    Restricoes restricao = new Restricoes();

                    restricao.ClienteId = codigoCliente;
                    restricao.ProdutoId = int.Parse(lwRestricoesAlimentares.Items[i].SubItems[0].Text);
                    restricao.Descricao = lwRestricoesAlimentares.Items[i].SubItems[2].Text;
                 
                    db.Restricoes.Add(restricao);
                    db.SaveChanges();
                }

                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cliente != null)
                {
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("Deseja realizar um novo cadastro ?", "Sistema pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimparCampos();
                        txtProdutos.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        public void SelecionarRestricaoPorClienteId(int clienteId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var cliente = db.Clientes.Find(clienteId);

                if (cliente != null)
                {
                    this.cliente = cliente;
                    txtCodigo.Text = cliente.ClienteId.ToString();
                    txtCPF.Text = cliente.Documento;
                    txtNomeCliente.Text = cliente.Nome;
                    txtCelular.Text = cliente.Celular;
                    codigoCliente = cliente.ClienteId;
                    
                }
            }
        }
    }
}

using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmAddEnderco : Form
    {
        public frmAddEnderco()
        {
            InitializeComponent();
        }

        int? codigoCliente = null;
        int count = 0;
        Cliente cliente = null;
        Endereco endereco = null;

        private void frmAddEnderco_KeyDown(object sender, KeyEventArgs e)
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

        private void BuscarCliente()
        {
            if (endereco == null)
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (codigoCliente == null)
            {
                MessageBox.Show("Informe o nome cliente desejado", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            if (endereco == null)
            {
                SalvaEndereco();
            }
            else
            {
                EditarEndereco(endereco.EnderecoId);
            }
        }

        private void EditarEndereco(int enderecoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var endereco = db.Enderecos.Find(enderecoId);

                if (endereco != null)
                {
                    endereco.IsEnderecoEntrega = ckEntrega.Checked;
                    endereco.Rua = txtRua.Text;
                    endereco.Numero = txtNumero.Text;
                    endereco.Bairro = txtBairro.Text;
                    endereco.Complemento = txtComplemento.Text;
                    endereco.EntreRua = txtEntreRuas.Text;
                    endereco.CEP = txtCeP.Text;
                    endereco.UF = txtUF.Text;
                    endereco.Cidade = txtCidade.Text;

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Cadastro alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        private void SalvaEndereco()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                for (int i = 0; i < lwEnderecos.Items.Count; i++)
                {
                    Endereco endereco = new Endereco();

                    endereco.ClienteId = codigoCliente;
                    endereco.IsEnderecoEntrega = lwEnderecos.Items[i].SubItems[0].Text == "SIM" ? true : false;
                    endereco.Rua = lwEnderecos.Items[i].SubItems[1].Text;
                    endereco.Numero = lwEnderecos.Items[i].SubItems[2].Text;
                    endereco.Bairro = lwEnderecos.Items[i].SubItems[3].Text;
                    endereco.Complemento = lwEnderecos.Items[i].SubItems[4].Text;
                    endereco.EntreRua = lwEnderecos.Items[i].SubItems[5].Text;
                    endereco.CEP = lwEnderecos.Items[i].SubItems[6].Text;
                    endereco.UF = lwEnderecos.Items[i].SubItems[7].Text;
                    endereco.Cidade = lwEnderecos.Items[i].SubItems[8].Text;

                    db.Enderecos.Add(endereco);
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
                        txtCeP.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void LimparCampos()
        {
            count = 0;
            lwEnderecos.Items.Clear();
            codigoCliente = null;
            txtCelular.Clear();
            txtCodigo.Clear();
            txtCPF.Clear();
            txtNomeCliente.Clear();
            txtBairro.Clear();
            txtCeP.Clear();
            txtCidade.Text = "Porto Velho";
            txtComplemento.Clear();
            txtEntreRuas.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtUF.Text = "RO";
            ckEntrega.Checked = false;
        }

        private void btnIncluirRestricoes_Click(object sender, EventArgs e)
        {
            if (txtRua.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o nome da rua", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRua.Focus();
                return;
            }

            if (txtBairro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o nome do bairro", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return;
            }

            if (txtNumero.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o número do endereço", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            lwEnderecos.Items.Add(ckEntrega.Checked == true ? "SIM" : "NÃO");
            lwEnderecos.Items[count].SubItems.Add(txtRua.Text);
            lwEnderecos.Items[count].SubItems.Add(txtNumero.Text);
            lwEnderecos.Items[count].SubItems.Add(txtBairro.Text);
            lwEnderecos.Items[count].SubItems.Add(txtComplemento.Text);
            lwEnderecos.Items[count].SubItems.Add(txtEntreRuas.Text);
            lwEnderecos.Items[count].SubItems.Add(txtCeP.Text);
            lwEnderecos.Items[count].SubItems.Add(txtUF.Text);
            lwEnderecos.Items[count].SubItems.Add(txtCidade.Text);
            count++;

            txtBairro.Clear();
            txtCeP.Clear();
            txtComplemento.Clear();
            txtEntreRuas.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            ckEntrega.Checked = false;

            txtCeP.Focus();

        }

        private void frmAddEnderco_Load(object sender, EventArgs e)
        {
            txtCidade.Text = "Porto Velho";
            txtUF.Text = "RO";
        }

        public void SelecionarEnderecoPorEnderecoId(int enderecoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var endereco = db.Enderecos.Find(enderecoId);

                if (endereco != null)
                {
                    this.endereco = endereco;

                    //Exibi dados cliente
                    this.cliente = endereco.Cliente;
                    txtCodigo.Text = cliente.ClienteId.ToString();
                    txtCPF.Text = cliente.Documento;
                    txtNomeCliente.Text = cliente.Nome;
                    txtCelular.Text = cliente.Celular;
                    codigoCliente = cliente.ClienteId;

                    //Exibi dados endereço cliente
                    txtBairro.Text = endereco.Bairro;
                    txtCeP.Text = endereco.CEP;
                    txtCidade.Text = endereco.Cidade;
                    txtComplemento.Text = endereco.Complemento;
                    txtEntreRuas.Text = endereco.EntreRua;
                    txtNumero.Text = endereco.Numero.ToString();
                    txtRua.Text = endereco.Rua;
                    txtUF.Text = endereco.UF;
                    ckEntrega.Checked = endereco.IsEnderecoEntrega;

                    btnIncluirRestricoes.Visible = false;
                    lwEnderecos.Visible = false;

                    panel1.Height = 350;

                    btnPesquisarCliente.Enabled = false;
                }
            }
        }

        public void SelecionarClienteId(int clienteId)
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
                    btnPesquisarCliente.Enabled = false;
                }
            }
        }
    }
}

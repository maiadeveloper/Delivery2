using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmTodosClientes : Form
    {
        int count = 0;
        public Cliente cliente;
        bool campoBuscaFocus = false;

        public frmTodosClientes()
        {
            InitializeComponent();
        }

        private void frmTodosClientes_Load(object sender, EventArgs e)
        {
            txtParametroBusca.Focus();

            CarregaListagemClientes();
        }

        private void CarregaListagemClientes()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwClientes.Items.Clear();
                txtQtdeItem.Clear();
                count = 0;

                var clientes = db.Clientes.Where(c => c.Nome.Contains(txtParametroBusca.Text)).ToList();

                if (clientes.Count != 0)
                {
                    lwClientes.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var cliente in clientes)
                    {
                        lwClientes.Items.Add(cliente.ClienteId.ToString());
                        lwClientes.Items[count].SubItems.Add(cliente.Situacao);
                        lwClientes.Items[count].SubItems.Add(cliente.Nome);
                        lwClientes.Items[count].SubItems.Add(cliente.RG);
                        lwClientes.Items[count].SubItems.Add(cliente.Documento);
                        lwClientes.Items[count].SubItems.Add(cliente.Celular);
                        lwClientes.Items[count].SubItems.Add(cliente.TelefoneResidencial);

                        count++;
                    }

                    txtQtdeItem.Text = lwClientes.Items.Count.ToString();
                }
                else
                {
                    lwClientes.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtParametroBusca_TextChanged_1(object sender, EventArgs e)
        {
            CarregaListagemClientes();
        }

        private void lwClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lwClientes.Items.Count > 0)
            {
                pPrincipal.Visible = false;
                int clienteId = Convert.ToInt32(lwClientes.FocusedItem.SubItems[0].Text);
                frmCliente frm = new frmCliente();
                frm.CarregaClienteSelecionado(clienteId);
                frm.ShowDialog();
                CarregaListagemClientes();
                pPrincipal.Visible = true;
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
            CarregaListagemClientes();
            pPrincipal.Visible = true;
        }

        private void frmTodosClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lwClientes.Items.Count > 0)
                {
                    try
                    {
                        if (int.Parse(lwClientes.FocusedItem.SubItems[0].Text) > 0)
                        {
                            cliente = new Cliente();

                            cliente.ClienteId = int.Parse(lwClientes.FocusedItem.SubItems[0].Text);
                            cliente.Nome = lwClientes.FocusedItem.SubItems[2].Text;
                            cliente.Documento = lwClientes.FocusedItem.SubItems[4].Text;
                            cliente.Celular = lwClientes.FocusedItem.SubItems[5].Text;

                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Por favor! Selecione o cliente desejado\nou então pressione enter 2x para selecionar o primeiro item da lista", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lwClientes.Focus();
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Down)
            {
                ListViewItem item = lwClientes.FindItemWithText(txtParametroBusca.Text);

                if (item != null)
                {
                    if (campoBuscaFocus == true)
                    {
                        item.Selected = true;
                        lwClientes.Focus();
                    }
                }
            }
        }

        private void txtParametroBusca_Enter(object sender, EventArgs e)
        {
            campoBuscaFocus = true;
        }
    }
}

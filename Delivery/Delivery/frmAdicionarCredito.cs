using Delivery.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Delivery.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmAdicionarCredito : Form
    {
        public frmAdicionarCredito()
        {
            InitializeComponent();
        }

        public int? clienteId = null;

        private void frmAdicionarCredito_Load(object sender, EventArgs e)
        {
            CarregaListaFormaCredito();
        }

        private void CarregaListaFormaCredito()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var formCreditos = db.FormaPagamentos.ToList();

                if (formCreditos.Count > 0)
                {
                    txtFormaCredito.DataSource = formCreditos.ToList();
                    txtFormaCredito.ValueMember = "FormaPagamentoId";
                    txtFormaCredito.DisplayMember = "Nome";
                    txtFormaCredito.Text = "Selecionar...";
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCredito_Leave(object sender, EventArgs e)
        {
            try
            {
                txtCredito.Text = Convert.ToDecimal(txtCredito.Text).ToString("C");
            }
            catch(Exception msg)
            {
                //error
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                if(ValidarCampos() == true)
                {
                    MovimentacaoCliente mc = new MovimentacaoCliente();

                    mc.DataHora = DateTime.Now;
                    mc.ClienteId = clienteId;
                    mc.PedidoId = null;
                    mc.TipoMovimentacao = txtFormaCredito.Text;
                    mc.ValorCredito = Convert.ToDecimal(txtCredito.Text.Substring(2));
                    mc.ValorDebito = 0;

                    if (MessageBox.Show("Confirma a inclusão do crédito para este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.MovimentacoesCliente.Add(mc);
                        db.SaveChanges();

                        txtCredito.Clear();
                        txtFormaCredito.Text = "Selecionar...";
                        txtCredito.Focus();

                        MessageBox.Show("Crédito adicionado com sucesso.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCredito.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe o valor do crédito.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCredito.Focus();
                return false;
            }
            if (txtFormaCredito.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Informe a forma de crédito.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFormaCredito.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

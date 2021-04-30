using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmAbrirCaixa : Form
    {
        public frmAbrirCaixa()
        {
            InitializeComponent();
            txtData.Text = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
        }

        Caixa caixa;

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbrirCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe o valor em caixa", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (caixa != null)
            {
                String mensagemUser;

                if (caixa.Situacao == true)
                {
                    mensagemUser = "Confirma fechamento deste caixa";
                }
                else
                {
                    mensagemUser = "Confirma abertura deste caixa";
                }

                if (MessageBox.Show(mensagemUser, "Confirmação recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (caixa.Situacao == true)
                    {
                        FecharCaixa();
                    }
                    else
                    {
                        AbrirCaixa();
                    }
                }
            }
            else
            {
                AbrirCaixa();
            }
        }

        public void CarregaDadosCaixaSelecionado(Caixa caixa)
        {
            this.caixa = caixa;

            if (caixa.Situacao == true)
            {
                lblData.Text = "Data de fechamento";
                lblTipoFechamento.Text = "Fechamento de caixa";
            }
            else
            {
                lblData.Text = "Data de abertura:";
                lblTipoFechamento.Text = "Abertura de caixa";
            }
        }

        public void FecharCaixa()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var consultaCaixa = db.Caixa.Find(caixa.CaixaId);

                if (consultaCaixa != null)
                {
                    consultaCaixa.DataFechamento = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    consultaCaixa.ValorFinal = Convert.ToDecimal(txtValor.Text.Substring(2));
                    consultaCaixa.Situacao = false;
                    db.SaveChanges();

                    MessageBox.Show("Caixa fechado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        public void AbrirCaixa()
        {
            if (Util.VerificarCaixaAbertoDiaAnterior() == false)
            {
                if (Util.VerificarCaixaIsAberto() == false)
                {
                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        Caixa caixa = new Caixa();

                        caixa.DataAbertura = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                        caixa.ValorInicial = Convert.ToDecimal(txtValor.Text.Substring(2));
                        caixa.Situacao = true;

                        db.Caixa.Add(caixa);
                        db.SaveChanges();

                        MessageBox.Show("Caixa aberto com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                return;
            }
            this.Close();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToDecimal(txtValor.Text).ToString("C");
        }
    }
}

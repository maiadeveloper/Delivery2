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
    public partial class frmSangria : Form
    {
        int? sangriaId = null;

        public frmSangria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sangriaId == null)
            {
                Salvar();
            }
        }

        private bool VerificaSaldoMovimentacao()
        {
            bool situacao = false;

            if (Util.IsBancoContaCorrenteExist() != null)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    int? id = Util.IsBancoContaCorrenteExist();

                    var contaCorrente = db.ContaCorrentes.Find(id);

                    if (contaCorrente != null)
                    {
                        if (contaCorrente.Saldo > 0)
                        {
                            situacao = true;
                        }
                        else
                        {
                            MessageBox.Show("Operação não pode ser realizada.\n Para continuar é nessário que tenha saldo em espécie no caixa.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            situacao = false;
                        }
                    }
                }
            }

            return situacao;
        }

        private void Salvar()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                if (txtValor.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Campo obrigatório! Informe o valor a ser retirado do caixa", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Focus();
                    return;
                }
                if (txtDescricaoDespesa.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Campo obrigatório! Informe a descrição", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescricaoDespesa.Focus();
                    return;
                }

                var sangria = new Sangria();

                sangria.DataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                sangria.Valor = Convert.ToDecimal(txtValor.Text.Substring(2));
                sangria.Descricao = txtDescricaoDespesa.Text;

                if (MessageBox.Show("Confirma retirada do caixa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Sangrias.Add(sangria);
                    db.SaveChanges();

                    if (Util.IsBancoContaCorrenteExist() != null)
                    {
                        Util.RealizarMovimentacaoContaCorrenteAtualizarSaldoContaCorrente(Util.IsBancoContaCorrenteExist(), sangria.DataHora, sangria.Valor, "DEBITO");
                    }

                    MessageBox.Show("Retirada realizada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Desejar realizar outra  retirada do caixa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtValor.Focus();
                        txtDescricaoDespesa.Clear();
                        txtValor.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = Convert.ToDecimal(txtValor.Text).ToString("C");
            }
            catch (Exception msg)
            {
                //erro;
            }
        }

        private void frmSangria_Load(object sender, EventArgs e)
        {
            txtValor.Focus();
        }

        private void frmSangria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

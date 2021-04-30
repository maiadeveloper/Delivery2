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
    public partial class frmMovimentacaoEntradaSaida : Form
    {
        int? movimentacaoId = null;

        public frmMovimentacaoEntradaSaida()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (movimentacaoId == null)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    if (string.IsNullOrEmpty(txtData.Text.Trim()))
                    {
                        MessageBox.Show("Campo obrigatório! - Informe o data da movimentação", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtData.Focus();
                        return;
                    }

                    MovimentacaoContaCorrente mc = new MovimentacaoContaCorrente();

                    mc.DataHoraMovimentacao = Convert.ToDateTime(txtData.Text);
                    mc.ContaCorrenteId = Convert.ToInt32(txtAgenciaCC.SelectedValue);
                    mc.Valor = Convert.ToDecimal(txtValor.Text.Substring(2));
                    mc.TipoMovimentacao = "CREDITO";

                    Util.RealizarMovimentacaoContaCorrenteAtualizarSaldoContaCorrente(mc.ContaCorrenteId, mc.DataHoraMovimentacao, mc.Valor, mc.TipoMovimentacao);

                    if (MessageBox.Show("Movimentação realizada com sucesso \n\n\nDeseja realizar uma nova movimentação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IniciarNovoCadastro();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void CarregaComboBancos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var bancos = db.Bancos.OrderBy(b => b.Descricao).ToList();

                if (bancos.Count > 0)
                {
                    txtBancos.DataSource = bancos.ToList();
                    txtBancos.ValueMember = "BancoId";
                    txtBancos.DisplayMember = "Descricao";
                    txtBancos.Text = "Selecionar...";
                }
            }
        }


        private void IniciarNovoCadastro()
        {
            CarregaComboBancos();
            txtData.Value = Convert.ToDateTime(DateTime.Now);
            movimentacaoId = null;
            txtValor.Clear();
            txtSaldo.Clear();
            txtBancos.Text = "Selecionar...";
            txtAgenciaCC.Text = "Selecionar...";
            txtData.Focus();
        }

        private void frmMovimentacaoEntradaSaida_Load(object sender, EventArgs e)
        {
            IniciarNovoCadastro();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = Convert.ToDecimal(txtValor.Text).ToString("C");
            }
            catch (Exception error)
            {
                //Error
            }
        }

        private void frmMovimentacaoEntradaSaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaComboContaCorrentes(int bancoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var contas = db.ContaCorrentes.Where(c => c.BancoId == bancoId).ToList();

                if (contas.Count > 0)
                {
                    txtAgenciaCC.DataSource = contas.ToList();
                    txtAgenciaCC.ValueMember = "ContaCorrenteId";
                    txtAgenciaCC.DisplayMember = "DescricaoContaCorrente";
                    txtAgenciaCC.Text = "Selecionar...";
                }
            }
        }


        public void AtualizarSaldoMovimentacao(int contaCorrenteId, decimal valor, string tipoMovimentacao)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var movimentacao = db.ContaCorrentes.Find(contaCorrenteId);

                if (movimentacao != null)
                {
                    if (tipoMovimentacao.Equals("CREDITO"))
                    {
                        movimentacao.Saldo += valor;
                    }
                    else
                    {
                        movimentacao.Saldo -= valor;
                    }

                    db.SaveChanges();
                }
            }
        }

        private void txtBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarregaComboContaCorrentes(Convert.ToInt32(txtBancos.SelectedValue));
                txtSaldo.Clear();
            }
            catch (Exception error)
            {
                //Error
            }
        }

        private void txtAgenciaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var contaCorrente = db.ContaCorrentes.Find(Convert.ToInt32(txtAgenciaCC.SelectedValue));

                    if (contaCorrente != null)
                    {
                        txtSaldo.Text = contaCorrente.Saldo.ToString("C");
                    }
                }
            }
            catch (Exception error)
            { //Errror
            }
        }
    }
}

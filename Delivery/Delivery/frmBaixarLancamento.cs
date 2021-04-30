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
    public partial class frmBaixarLancamento : Form
    {
        int? codLancamento = null;

        public frmBaixarLancamento()
        {
            InitializeComponent();
        }

        public void CarregaDadosLancamento(int lancamentoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var lancamento = db.Lancamentos.Find(lancamentoId);
                codLancamento = lancamento.LancamentoID;

                txtClasse.Text = lancamento.CategoriaLancamento.Nome;
                txtClassificao.Text = lancamento.TipoLancamento;
                txtDataEmissao.Text = lancamento.DataEmissao.ToString();
                txtDataEntrada.Text = lancamento.DataCadastro.ToString();
                txtDescricaoLancamento.Text = lancamento.Descricao;
                txtFavorecido.Text = lancamento.Fornecedor.Fantasia;
                txtNumeroDoc.Text = lancamento.NumDoc;
                txtParcela.Text = lancamento.NumParcela;
                txtSubClasse.Text = lancamento.SubCategoriaLancamento.Nome;
                txtTipoDocum.Text = lancamento.TipoDocumento.Nome;
                txtValorDocumento.Text = lancamento.ValorPrincipal.ToString("C");
                txtVencimentoInicial.Text = lancamento.DataVencimento.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObrigatoriosBaixa() == true)
            {
                if (MessageBox.Show("Confirma a baixa deste lançamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        var lancamento = db.Lancamentos.Find(codLancamento);


                        lancamento.DataPgto = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                        lancamento.Situacao = "pago";

                        db.SaveChanges();

                        MovimentacaoContaCorrente mc = new MovimentacaoContaCorrente();

                        mc.DataHoraMovimentacao = DateTime.Now;
                        mc.ContaCorrenteId = Convert.ToInt32(txtAgenciaCC.SelectedValue);
                        mc.Valor = Convert.ToDecimal(txtValorDocumento.Text.Substring(2));
                        mc.TipoMovimentacao = "DEBITO";

                        db.MovimentacoesContaCorrentes.Add(mc);
                        db.SaveChanges();

                        Util.RealizarMovimentacaoContaCorrenteAtualizarSaldoContaCorrente(mc.ContaCorrenteId, mc.DataHoraMovimentacao, mc.Valor, mc.TipoMovimentacao);

                        MessageBox.Show("Lançamento baixado com sucesso", "Pagamento efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                return;
            }
        }

        public bool ValidarCamposObrigatoriosBaixa()
        {
            if (txtBancos.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! \nInforme o banco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtBancos.Focus();
                return false;
            }
            if (txtAgenciaCC.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! \nInforme a agência para qual será debitado o pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtAgenciaCC.Focus();
                return false;
            }
            else
            {
                return true;
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

        private void frmBaixarLancamento_Load(object sender, EventArgs e)
        {
            CarregaComboBancos();
            txtBancos.Focus();
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

        private void frmBaixarLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

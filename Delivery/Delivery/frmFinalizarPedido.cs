using Delivery.DataContext;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmFinalizarPedido : Form
    {
        int? pedidoId = null;
        int? entregadorId = null;
        public decimal returnTotal;
        bool isPcte;
        public decimal returnTroco;
        public int? returnCodFormaPgto = null;
        public decimal? returnDesconto = Convert.ToDecimal("0,00");
        public decimal? returnTaxaEntrega = null;
        public decimal? returnTotalFinal = null;
        public decimal? returnPagando = null;
        public string situacao;
        public bool isCancel = false;
        public bool isCredito = false;
        public bool isFinalizado = false;

        public bool isFocoDesconto = false;
        public bool isFocoTaxa = false;
        public bool isFocoPagando = false;
        public bool isFocoFormaPgto = false;

        decimal totalPagando = 0;
        decimal totalPagar = 0;

        int? clienteId = null;
        int cont = 0;
        DateTime dataPedido;

        public frmFinalizarPedido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isCancel = true;
            isFinalizado = false;
            this.Close();
        }

        private void frmFinalizarPedido_Load(object sender, EventArgs e)
        {
            txtDesconto.Text = Convert.ToDecimal("0").ToString("C");
            txtTaxaEntrega.Text = Convert.ToDecimal("0").ToString("C");
            txtPagando.Text = Convert.ToDecimal("0").ToString("C");
            txtTroco.Text = Convert.ToDecimal("0").ToString("C");

            CarregaListaFormaPagamento();
        }

        private void CarregaListaFormaPagamento()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var formaPgtos = db.FormaPagamentos.ToList();

                foreach (var item in formaPgtos)
                {
                    listBoxFormaPagamento.Items.Add(item.FormaPagamentoId + " - " + item.Nome);
                }

                listBoxFormaPagamento.SelectedIndex = 0;
                listBoxFormaPagamento.Focus();
            }
        }

        public void CarregaDadosPedido(int? pedidoId, decimal total, int? clienteId, DateTime dataPedido, bool isPcte, int entregadorId)
        {
            this.pedidoId = pedidoId;
            this.isPcte = isPcte;
            this.returnTotal = total;
            this.clienteId = clienteId;
            this.dataPedido = dataPedido;
            this.entregadorId = entregadorId;
            txtTotalPedido.Text = total.ToString("C");
            txtTotalPagar.Text = total.ToString("C");
        }

        private void frmFinalizarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                decimal valorTotalPedido = Convert.ToDecimal(txtTotalPedido.Text.Substring(2));

                if (e.KeyCode == Keys.Enter)
                {
                    if (isFocoFormaPgto == true)
                    {
                        txtPagando.Focus();
                        txtPagando.Clear();
                        isFocoFormaPgto = false;
                    }

                    //Realiza calculo acrescimo taxa de entrega
                    if (isFocoTaxa == true)
                    {
                        CalcularTaxaEntrega(valorTotalPedido);
                    }
                    //Realiza calculo para desconto
                    if (isFocoDesconto == true)
                    {
                        CalcularDesconto(valorTotalPedido);
                    }
                    //Realiza calculo de pagamento
                    if (isFocoPagando == true)
                    {
                        if (!string.IsNullOrEmpty(txtPagando.Text))
                        {
                            if (txtPagando.Text.StartsWith("R"))
                            {
                                totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
                            }
                            else
                            {
                                totalPagar = Convert.ToDecimal(txtTotalPagar.Text.Substring(2));
                            }

                            totalPagando = Convert.ToDecimal(txtPagando.Text);
                            decimal totalTroco;

                            if (totalPagando < totalPagar)
                            {
                                MessageBox.Show("O valor informado é menor que o valor total a pagar", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtSituacaoPedido.Enabled = false;
                                txtPagando.Focus();
                                return;
                            }
                            else
                            {
                                totalTroco = totalPagando >= totalPagar ? (totalPagando - totalPagar) : 0;
                                txtTroco.Text = Convert.ToDecimal(totalTroco).ToString("C");
                                txtPagando.Text = Convert.ToDecimal(totalPagando).ToString("C");

                                returnTotalFinal = totalPagar;
                                returnPagando = totalPagando;
                                returnTroco = totalTroco;
                                isFocoPagando = false;
                                txtSituacaoPedido.Enabled = true;
                                txtSituacaoPedido.Focus();
                            }
                        }
                    }
                }

                if (e.KeyCode == Keys.F8)
                {
                    btnAplicarDesconto_Click(this, e);
                }

                if (e.KeyCode == Keys.F9)
                {
                    btnAplicarTaxa_Click(this, e);
                }

                if (e.KeyCode == Keys.F4)
                {
                    btnSalvar_Click(this, e);
                }

                if (e.KeyCode == Keys.Escape)
                {
                    isCancel = true;
                    isFinalizado = false;
                    this.Close();
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show("Entre com a sequencia correta por favor!", "Atenção  usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcularDesconto(decimal valorTotalPedido)
        {
            decimal valorDesconto = 0;
            decimal valorTaxaEntrega = 0;
            decimal totalComDesconto = 0;

            if (!string.IsNullOrEmpty(txtDesconto.Text))
            {
                valorDesconto = txtDesconto.Text.StartsWith("R") ? Convert.ToDecimal(txtDesconto.Text.Substring(2)) : Convert.ToDecimal(txtDesconto.Text);
            }

            if (!string.IsNullOrEmpty(txtTaxaEntrega.Text))
            {
                valorTaxaEntrega = txtTaxaEntrega.Text.StartsWith("R") ? Convert.ToDecimal(txtTaxaEntrega.Text.Substring(2)) : Convert.ToDecimal(txtTaxaEntrega.Text);
            }

            totalComDesconto = ((valorTotalPedido + valorTaxaEntrega) - valorDesconto);

            txtDesconto.Text = valorDesconto.ToString("C");
            txtTotalPagar.Text = totalComDesconto.ToString("C");

            returnDesconto = valorDesconto;
            txtPagando.Focus();
            txtPagando.Clear();
            isFocoDesconto = false;
        }

        private void CalcularTaxaEntrega(decimal valorTotalPedido)
        {
            decimal valorDesconto = 0;
            decimal valorTaxaEntrega = 0;
            decimal totalComTaxa = 0;

            if (!string.IsNullOrEmpty(txtTaxaEntrega.Text))
            {
                valorTaxaEntrega = txtTaxaEntrega.Text.StartsWith("R") ? Convert.ToDecimal(txtTaxaEntrega.Text.Substring(2)) : Convert.ToDecimal(txtTaxaEntrega.Text);
            }

            if (!string.IsNullOrEmpty(txtDesconto.Text))
            {
                valorDesconto = txtDesconto.Text.StartsWith("R") ? Convert.ToDecimal(txtDesconto.Text.Substring(2)) : Convert.ToDecimal(txtDesconto.Text);
            }

            totalComTaxa = ((valorTotalPedido + valorTaxaEntrega) - valorDesconto);

            txtTaxaEntrega.Text = valorTaxaEntrega.ToString("C");
            txtTotalPagar.Text = totalComTaxa.ToString("C");

            returnTaxaEntrega = valorTaxaEntrega;
            txtPagando.Focus();
            txtPagando.Clear();
            isFocoTaxa = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSituacaoPedido.Text.Equals("Selecionar..."))
                {
                    txtSituacaoPedido.Focus();
                    MessageBox.Show("Informe a situação do pedido", "Atenção usuário!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Deseja finalizar este pedido ?", "Confirmação de finalização de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    returnCodFormaPgto = Convert.ToInt32(listBoxFormaPagamento.SelectedItem.ToString().Substring(0, 1));
                    situacao = txtSituacaoPedido.Text;

                    returnTaxaEntrega = entregadorId == null ? Convert.ToDecimal(null) : Convert.ToDecimal(txtTaxaEntrega.Text.Substring(2));
                    isFinalizado = true;

                    if (listBoxFormaPagamento.SelectedItem.ToString().Equals("DINHEIRO"))
                    {
                        if (Util.IsBancoContaCorrenteExist() != null)
                        {
                            Util.RealizarMovimentacaoContaCorrenteAtualizarSaldoContaCorrente(Util.IsBancoContaCorrenteExist(),
                                DateTime.Now, Convert.ToDecimal(txtTotalPagar.Text.Substring(2)), "CREDITO");
                        }
                    }

                    this.Close();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message + ".\nVamos tentar novamente,caso erro volte a persitir, entre em contato com suporte ténico."
                                            , "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTaxaEntrega_Enter(object sender, EventArgs e)
        {
            isFocoTaxa = true;
        }

        private void lwFormaPgto_DoubleClick(object sender, EventArgs e)
        {
            CarregaListaFormaPagamento();
        }

        private void lwFormaPgto_Enter(object sender, EventArgs e)
        {
            isFocoFormaPgto = true;
        }

        private void txtSituacaoPedido_Enter(object sender, EventArgs e)
        {
            isFocoPagando = true;
        }

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            txtDesconto.Enabled = true;
            txtDesconto.Focus();
        }

        private void listBoxFormaPagamento_Enter(object sender, EventArgs e)
        {
            isFocoFormaPgto = true;
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            isFocoDesconto = true;
        }

        private void txtPagando_Enter(object sender, EventArgs e)
        {
            isFocoPagando = true;
        }

        private void btnAplicarTaxa_Click(object sender, EventArgs e)
        {
            txtTaxaEntrega.Enabled = true;
            txtTaxaEntrega.Focus();
        }

        private void txtTaxaEntrega_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaxaEntrega.Text))
            {
                txtTaxaEntrega.Text = Convert.ToDecimal("0").ToString("C");
            }

            txtTaxaEntrega.Enabled = false;
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesconto.Text))
            {
                txtDesconto.Text = Convert.ToDecimal("0").ToString("C");
            }

            txtDesconto.Enabled = false;
        }

        private void txtPagando_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPagando.Text))
            {
                txtPagando.Text = Convert.ToDecimal("0").ToString("C");
            }
        }

        private void pcBoxFechar_MouseHover(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pcBoxFechar_MouseLeave(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void pcBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSituacaoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSituacaoPedido.Text != "Selecionar...")
            {
                if (txtSituacaoPedido.Text.Equals("pago"))
                {
                    txtSituacaoPedido.ForeColor = System.Drawing.Color.Green;
                    txtSituacaoPedido.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtSituacaoPedido.ForeColor = System.Drawing.Color.Red;
                    txtSituacaoPedido.ForeColor = System.Drawing.Color.Red;
                }

                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }
    }
}

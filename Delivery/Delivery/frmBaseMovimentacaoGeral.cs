using Delivery.DataContext;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBaseMovimentacaoGeral : Form
    {
        public frmBaseMovimentacaoGeral()
        {
            InitializeComponent();
        }

        private void frmBaseMovimentacaoGeral_Load(object sender, EventArgs e)
        {
            txtDataInicial.Text = DateTime.Now.ToString();
            txtDataFinal.Text = DateTime.Now.ToString();

            CarregaTodasDespesas();
            CarregaTodasReceitas();
            CarregaFormaPgtoDelhate();
        }

        private void CarregaTodasDespesas()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwDespesas.Items.Clear();
                int count = 0;
                decimal totalDespesa = 0;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                txtQtdeDespesa.Text = "0";

                txtTotalDespesa.Text = Convert.ToDecimal(0).ToString("C"); ;

                var lancamentos = db.Lancamentos.Where(l => l.DataPgto >= dtInicial && l.DataPgto <= dtFinal).OrderBy(l => l.DataPgto).ToList();
                var sangrias = db.Sangrias.Where(s => s.DataHora >= dtInicial && s.DataHora <= dtFinal).OrderBy(s => s.DataHora).ToList();

                if ((lancamentos.Count != 0) || (sangrias.Count != 0))
                {
                    foreach (var lancamento in lancamentos)
                    {
                        lwDespesas.Items.Add(lancamento.Descricao);
                        lwDespesas.Items[count].SubItems.Add(lancamento.ValorPrincipal.ToString("C"));

                        count++;
                        totalDespesa += lancamento.ValorPrincipal;
                    }

                    foreach (var sangria in sangrias)
                    {
                        lwDespesas.Items.Add(sangria.Descricao);
                        lwDespesas.Items[count].SubItems.Add(sangria.Valor.ToString("C"));

                        count++;
                        totalDespesa += sangria.Valor;
                    }

                    txtTotalDespesa.Text = totalDespesa.ToString("C");
                    txtQtdeDespesa.Text = (Convert.ToDecimal(lancamentos.Count) + Convert.ToDecimal(sangrias.Count)).ToString();
                }
            }
        }

        private void CarregaTodasReceitas()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwReceitas.Items.Clear();
                int count = 0;
                decimal? totalReceita = 0;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                txtQtdeReceita.Text = "0";
                txtTotalReceitas.Text = Convert.ToDecimal(0).ToString("C");

                var pedidos = db.Pedidos.Where(p => p.DataHoraPgto >= dtInicial
                                                    && p.DataHoraPgto <= dtFinal
                                                    && p.IsExcluir == false
                                                    && p.Situacao.Equals("pago")).OrderBy(p => p.Data).ToList();

                if (pedidos.Count != 0)
                {
                 
                    foreach (var pedido in pedidos)
                    {
         
                        string descricao = pedido.IsPcte == true ? "PACOTE" : "NORMAL";

                        lwReceitas.Items.Add(Util.AdicionaZero(pedido.PedidoId.ToString()));
                        lwReceitas.Items[count].SubItems.Add(pedido.TipoPedido + " | " + descricao);
                        lwReceitas.Items[count].SubItems.Add(Convert.ToDecimal(pedido.VlrTotalFinal).ToString("C"));                     
                        count++;

                        totalReceita += pedido.VlrTotalFinal;
                    }

                    txtTotalReceitas.Text = Convert.ToDecimal(totalReceita).ToString("C");
                    txtQtdeReceita.Text = pedidos.Count.ToString();
                }
            }
        }

        private void CarregaFormaPgtoDelhate()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwFormaPgtoDetalhe.Items.Clear();
                decimal? totalFormaPgto = 0;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                txtTotalFormaPgto.Clear();

                int count = 0;

                var formPagtos = db.FormaPagamentos.ToList();

                if (formPagtos.Count != 0)
                {

                    foreach (var formPgto in formPagtos)
                    {
                        lwFormaPgtoDetalhe.Items.Add(formPgto.Nome);

                        decimal? total = db.Pedidos.Where(p => p.DataHoraPgto >= dtInicial
                                                   && p.DataHoraPgto <= dtFinal
                                                   && p.IsExcluir == false
                                                   && p.Situacao.Equals("pago")
                                                   && p.FormaPagamentoId == formPgto.FormaPagamentoId).Sum(p => p.VlrTotalFinal).GetValueOrDefault();



                        lwFormaPgtoDetalhe.Items[count].SubItems.Add(Convert.ToDecimal(total).ToString("C"));

                        totalFormaPgto += total;
                        count++;
                    }

                    txtTotalFormaPgto.Text = Convert.ToDecimal(totalFormaPgto).ToString("C");
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaTodasDespesas();
        }

        private void frmBaseMovimentacaoGeral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaTodasDespesas();
                CarregaFormaPgtoDelhate();
                CarregaTodasReceitas();
                
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

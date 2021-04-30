using Delivery.DataContext;
using System;
using System.Collections;
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
    public partial class frmConsultarClientesSaldo : Form
    {
        public frmConsultarClientesSaldo()
        {
            InitializeComponent();
        }

        int contador = 0;
        decimal saldoGeral = 0;

        List<SaldoCliente> listaSaldo;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmBaseRelatorioMovimentacaoCliente frm = new frmBaseRelatorioMovimentacaoCliente();
            frm.CarregaReport(listaSaldo);
            frm.ShowDialog();
        }

        private void frmConsultarClientesSaldo_Load(object sender, EventArgs e)
        {
            CarregarListagemClientesSaldos();
        }

        private void CarregarListagemClientesSaldos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwClientesSaldos.Items.Clear();
                listaSaldo = new List<SaldoCliente>();
                saldoGeral = 0;
                contador = 0;

                var clientes = db.Clientes.Where(c => c.Nome.Contains(txtParametroBusca.Text)).ToList();

                if (clientes.Count != 0)
                {
                    lwClientesSaldos.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var item in clientes)
                    {
                        var movimentacoes = db.MovimentacoesCliente.Where(c => c.ClienteId == item.ClienteId);

                        if (movimentacoes.Count() > 0)
                        {
                            btnGerarRelatorio.Enabled = true;

                            var clienteCredito = db.MovimentacoesCliente.Where(c => c.ClienteId == item.ClienteId).Sum(c => c.ValorCredito);
                            var clienteDebito = db.MovimentacoesCliente.Where(c => c.ClienteId == item.ClienteId).Sum(c => c.ValorDebito);

                            decimal vlrSaldo = clienteCredito - clienteDebito;

                            if (vlrSaldo > 0)
                            {
                                SaldoCliente saldo = new SaldoCliente();

                                saldo.codCliente = item.ClienteId;
                                saldo.cpf = item.Documento;
                                saldo.nomeCliente = item.Nome;
                                saldo.saldo = vlrSaldo;

                                listaSaldo.Add(saldo);
                                saldoGeral += vlrSaldo;
                            }
                        }
                    }

                    if (listaSaldo.Count > 0)
                    {
                        if (rbCrescente.Checked == true)
                        {
                            listaSaldo = listaSaldo.OrderBy(s => s.saldo).ToList();
                        }
                        else
                        {
                            listaSaldo = listaSaldo.OrderByDescending(s => s.saldo).ToList();
                        }

                        foreach (var item2 in listaSaldo)
                        {
                            lwClientesSaldos.Items.Add(item2.codCliente.ToString());
                            lwClientesSaldos.Items[contador].SubItems.Add(item2.nomeCliente);
                            lwClientesSaldos.Items[contador].SubItems.Add(item2.cpf);
                            lwClientesSaldos.Items[contador].SubItems.Add(item2.saldo.ToString("C"));
                            contador++;
                        }
                    }

                    txtQtdeItem.Text = lwClientesSaldos.Items.Count.ToString();
                    txtTotalGeral.Text = saldoGeral.ToString("C");

                }
                else
                {
                    lwClientesSaldos.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregarListagemClientesSaldos();
        }

        private void frmConsultarClientesSaldo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbCrescente_CheckedChanged(object sender, EventArgs e)
        {
            CarregarListagemClientesSaldos();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CarregarListagemClientesSaldos();
        }
    }
}

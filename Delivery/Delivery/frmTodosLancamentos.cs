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
    public partial class frmTodosLancamentos : Form
    {
        public Operador operador = new Operador();
        int count = 0;
        decimal totalGeral = 0;
        decimal totalNaoPago = 0;
        decimal totalPago = 0;
        string situacao = string.Empty;

        public frmTodosLancamentos(Operador operador)
        {
            InitializeComponent();
            this.operador = operador;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;
            frmLancamento frm = new frmLancamento(operador);
            frm.operador = operador;
            frm.ShowDialog();
            CarregaListagemTodosLancamentos();
            pPrincipal.Visible = true;
        }


        private void CarregaListagemTodosLancamentos()
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    listViewLancamentos.Items.Clear();

                    txtQtdeItem.Clear();
                    txtQtdeItem.Clear();
                    txtTotalGeral.Clear();
                    txtTotalNaoPago.Clear();
                    txtTotalPago.Clear();
                    count = 0;
                    totalGeral = 0;
                    totalNaoPago = 0;
                    totalPago = 0;

                    listViewLancamentos.SmallImageList = imageList1;

                    List<Lancamento> lancamentos = null;

                    DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                    DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                    if (situacao.Equals("TODOS"))
                    {
                        var consulta1 = db.Lancamentos.Where(l => l.DataVencimento >= dtInicial && l.DataVencimento <= dtFinal
                            && l.Fornecedor.Razao.Contains(txtParametroBusca.Text)).ToList();

                        lancamentos = consulta1.ToList();
                    }
                    else
                    {
                        var consulta2 = db.Lancamentos.Where(l => l.DataVencimento >= dtInicial && l.DataVencimento <= dtFinal
                            && l.Fornecedor.Razao.Contains(txtParametroBusca.Text)
                            && l.Situacao.Equals(situacao)).ToList();

                        lancamentos = consulta2.ToList();
                    }

                    if (lancamentos.Count != 0)
                    {
                        listViewLancamentos.Visible = true;
                        btnMensagem.Visible = false;

                        foreach (var item in lancamentos)
                        {
                            if (item.Situacao.Equals("não pago"))
                            {
                                listViewLancamentos.Items.Add(item.Situacao, 1);
                            }
                            else if (item.Situacao.Equals("pago"))
                            {
                                listViewLancamentos.Items.Add(item.Situacao, 0);
                            }
                            else
                            {
                                listViewLancamentos.Items.Add(item.Situacao, 2);
                            }

                            listViewLancamentos.Items[count].SubItems.Add(item.LancamentoID.ToString());
                            listViewLancamentos.Items[count].SubItems.Add(item.DataVencimento.ToString("dd/MM/yyyy"));
                            listViewLancamentos.Items[count].SubItems.Add(item.NumParcela);
                            listViewLancamentos.Items[count].SubItems.Add(item.ValorPrincipal.ToString("C"));
                            listViewLancamentos.Items[count].SubItems.Add(item.Descricao);
                            listViewLancamentos.Items[count].SubItems.Add(item.Fornecedor.Fantasia);
                            listViewLancamentos.Items[count].SubItems.Add(DiasAtraso(item.DataVencimento).ToString());
                            listViewLancamentos.Items[count].SubItems.Add(item.NumDoc);
                            listViewLancamentos.Items[count].SubItems.Add(item.TipoDocumento.Nome);
                            listViewLancamentos.Items[count].SubItems.Add(item.CategoriaLancamento.Nome);
                            listViewLancamentos.Items[count].SubItems.Add(item.SubCategoriaLancamento.Nome);

                            AlterarFundoCorList(DiasAtraso(item.DataVencimento));

                            count++;

                            Somatorios(item.Situacao, item.ValorPrincipal);
                        }

                        txtQtdeItem.Text = listViewLancamentos.Items.Count.ToString();
                        txtTotalGeral.Text = totalGeral.ToString("C");
                        txtTotalNaoPago.Text = totalNaoPago.ToString("C");
                        txtTotalPago.Text = totalPago.ToString("C");
                    }
                    else
                    {
                        listViewLancamentos.Visible = false;
                        btnMensagem.Visible = true;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ouve uma falha de implementação! Favor entrar em contato com o administrador do sistema.", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AlterarFundoCorList(int diasAtraso)
        {
            if (diasAtraso.ToString().StartsWith("-"))
            {
                listViewLancamentos.Items[count].UseItemStyleForSubItems = false;//Desabilita e pega a posição que deseja aplicar o estilo
                listViewLancamentos.Items[count].SubItems[7].BackColor = Color.Red;//Linha e coluna
            }
            else
            {
                listViewLancamentos.Items[count].UseItemStyleForSubItems = false;
                listViewLancamentos.Items[count].SubItems[7].BackColor = Color.LimeGreen;
            }
        }

        public int DiasAtraso(DateTime dataVencimeto)
        {
            TimeSpan intervalo = DateTime.Now.Subtract(dataVencimeto);
            return -intervalo.Days + 1;
        }

        private void frmBaseTodosLancamentos_Load(object sender, EventArgs e)
        {
            situacao = "TODOS";
            CarregaListagemTodosLancamentos();
        }

        private void Somatorios(string situacao, decimal valor)
        {
            switch (situacao)
            {
                case "pago":
                    totalPago += valor;
                    break;
                case "não pago":
                    totalNaoPago += valor;
                    break;
            }

            totalGeral += valor;
        }

        private void cancelarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewLancamentos.Items.Count > 0)
            {
                int lancamentoId = Convert.ToInt32(listViewLancamentos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var lancamento = db.Lancamentos.Find(lancamentoId);

                    if (lancamento.Situacao != "pago")
                    {
                        if (MessageBox.Show("Deseja excluir o lançamento: " + lancamentoId + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Lancamentos.Remove(lancamento);
                            db.SaveChanges();

                            MessageBox.Show("Lançamento excluido com sucesso!", "Mensagem de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregaListagemTodosLancamentos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não tem permissão para excluir um lançamento que ja foi baixado!\nContate o administrador do sistema.", "Mensagem de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void fecharPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewLancamentos.Items.Count > 0)
            {
                int lancamentoId = Convert.ToInt32(listViewLancamentos.FocusedItem.SubItems[1].Text);

                if (listViewLancamentos.FocusedItem.SubItems[1].Text != "pago")
                {                    
                    pPrincipal.Visible = false;
                    frmBaixarLancamento frm = new frmBaixarLancamento();
                    frm.CarregaDadosLancamento(lancamentoId);
                    frm.ShowDialog();
                    CarregaListagemTodosLancamentos();
                    pPrincipal.Visible = true;
                }
            }
        }

        private void listViewLancamentos_DoubleClick(object sender, EventArgs e)
        {
            if (listViewLancamentos.Items.Count > 0)
            {
                int lancamentoId = Convert.ToInt32(listViewLancamentos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var lancamento = db.Lancamentos.Find(lancamentoId);

                    if (lancamento.Situacao != "pago")
                    {
                        pPrincipal.Visible = false;
                        frmLancamento frm = new frmLancamento(operador);
                        frm.operador = operador;

                        frm.SelecionarLancamentoId(lancamentoId);
                        frm.ShowDialog();

                        CarregaListagemTodosLancamentos();
                        pPrincipal.Visible = true;
                    }
                }
            }
        }

        private void rbAberto_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "não pago";
            CarregaListagemTodosLancamentos();
        }

        private void rbFechado_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "pago";
            CarregaListagemTodosLancamentos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaListagemTodosLancamentos();
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemTodosLancamentos();
        }

        private void frmTodosLancamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaListagemTodosLancamentos();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "TODOS";
            CarregaListagemTodosLancamentos();
        }

        private void txtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            CarregaListagemTodosLancamentos();
        }

        private void txtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            CarregaListagemTodosLancamentos();
        }
    }
}

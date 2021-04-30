using Delivery.DataContext;
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
    public partial class frmRelacaoCaixaAbertoFechado : Form
    {
        public frmRelacaoCaixaAbertoFechado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaCaixas();
        }

        private void frmRelacaoCaixaAbertoFechado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                CarregaCaixas();
            }
        }

        private void frmRelacaoCaixaAbertoFechado_Load(object sender, EventArgs e)
        {
            txtDataInicial.Text = DateTime.Now.ToString();
            txtDataFinal.Text = DateTime.Now.ToString();

            CarregaCaixas();
        }

        private void CarregaCaixas()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwCaixas.Items.Clear();
                int count = 0;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                var caixas = db.Caixa.Where(c => c.DataAbertura >= dtInicial
                                                    && c.DataAbertura <= dtFinal).OrderBy(c => c.DataAbertura).ToList();

                if (caixas.Count != 0)
                {
                    lwCaixas.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var caixa in caixas)
                    {
                        lwCaixas.Items.Add(caixa.CaixaId.ToString());
                        lwCaixas.Items[count].SubItems.Add(Convert.ToDateTime(caixa.DataAbertura).ToString("dd/MM/yyyy"));
                        lwCaixas.Items[count].SubItems.Add(caixa.DataFechamento == null ? "" : Convert.ToDateTime(caixa.DataFechamento).ToString("dd/MM/yyyy"));
                        lwCaixas.Items[count].SubItems.Add(Convert.ToDecimal(caixa.ValorInicial).ToString("C"));
                        lwCaixas.Items[count].SubItems.Add(caixa.ValorFinal == null ? "" : Convert.ToDecimal(caixa.ValorFinal).ToString("C"));

                        lwCaixas.Items[count].SubItems.Add(caixa.Situacao == false ? "Fechado" : "Aberto");

                        if (caixa.Situacao == true)
                        {
                            lwCaixas.Items[count].ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lwCaixas.Items[count].ForeColor = System.Drawing.Color.Red;
                        }

                        count++;
                    }
                }
                else
                {
                    lwCaixas.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAbrirCaixa frm = new frmAbrirCaixa();
            frm.ShowDialog();
            CarregaCaixas();
        }

        private void lwCaixas_DoubleClick(object sender, EventArgs e)
        {
            if (lwCaixas.Items.Count > 0)
            {
                int caixaId = int.Parse(lwCaixas.FocusedItem.SubItems[0].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var caixa = db.Caixa.Find(caixaId);

                    if (caixa != null)
                    {
                        frmAbrirCaixa frm = new frmAbrirCaixa();

                        frm.CarregaDadosCaixaSelecionado(caixa);

                        frm.ShowDialog();
                        CarregaCaixas();
                    }
                }
            }
        }

        private void cancelarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwCaixas.Items.Count > 0)
            {
                int caixaId = int.Parse(lwCaixas.FocusedItem.SubItems[0].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var caixa = db.Caixa.Find(caixaId);

                    if (caixa.Situacao == false)
                    {
                        if (MessageBox.Show("Deseja reabrir o caixa referente ao dia " + Convert.ToDateTime(caixa.DataAbertura).ToString("dd/MM/yyyy") + "?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            caixa.Situacao = true;
                            db.SaveChanges();

                            MessageBox.Show("Caixa reaberto com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregaCaixas();
                        }
                    }
                }
            }
        }
    }
}

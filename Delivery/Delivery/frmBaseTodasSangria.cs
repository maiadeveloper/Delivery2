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
    public partial class frmBaseTodasSangria : Form
    {
        public frmBaseTodasSangria()
        {
            InitializeComponent();
        }

        private void frmBaseMovimentacaoGeral_Load(object sender, EventArgs e)
        {
            txtDataInicial.Text = DateTime.Now.ToString();
            txtDataFinal.Text = DateTime.Now.ToString();

            CarregaTodasSangrias();
        }

        private void CarregaTodasSangrias()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwSangrias.Items.Clear();
                int count = 0;
                decimal? totalSangria = 0;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                txtQtdeItem.Text = "0";
                txtTotalGeral.Text = Convert.ToDecimal(0).ToString("C");

                var sangrias = db.Sangrias.Where(s => s.DataHora >= dtInicial
                                                    && s.DataHora <= dtFinal
                                                    && s.Descricao.Contains(txtParametroBusca.Text)).OrderBy(s => s.DataHora).ToList();

                if (sangrias.Count != 0)
                {
                    lwSangrias.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var sangria in sangrias)
                    {
                        lwSangrias.Items.Add(sangria.SangriaId.ToString());
                        lwSangrias.Items[count].SubItems.Add(sangria.Descricao);
                        lwSangrias.Items[count].SubItems.Add(Convert.ToDateTime(sangria.DataHora).ToString("dd/MM/yyyy"));
                        lwSangrias.Items[count].SubItems.Add(Convert.ToDecimal(sangria.Valor).ToString("C"));

                        count++;

                        totalSangria += sangria.Valor;
                    }

                    txtTotalGeral.Text = Convert.ToDecimal(totalSangria).ToString("C");
                    txtQtdeItem.Text = sangrias.Count.ToString();
                }
                else
                {
                    lwSangrias.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Util.VerificarCaixaIsAbertoOperacoesDiversas() == true)
            {
                frmSangria frm = new frmSangria();
                frm.ShowDialog();
                CarregaTodasSangrias();
            }
            else
            {
                MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data ainda não foi aberto ou ja  foi fechado.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaTodasSangrias();
        }

        private void frmBaseTodasSangria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaTodasSangrias();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaTodasSangrias();
        }

        private void cancelarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwSangrias.Items.Count > 0)
            {
                int codigo = Convert.ToInt32(lwSangrias.FocusedItem.SubItems[0].Text);

                if (MessageBox.Show("Deseja excluir a sangria de codigo: " + codigo + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        var sangria = db.Sangrias.Find(codigo);

                        if (sangria != null)
                        {
                            db.Sangrias.Remove(sangria);
                            db.SaveChanges();

                            MessageBox.Show("Sangria excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregaTodasSangrias();
                        }
                    }
                }
            }

        }
    }
}

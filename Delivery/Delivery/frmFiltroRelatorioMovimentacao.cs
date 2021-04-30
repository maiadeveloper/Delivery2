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
    public partial class frmFiltroRelatorioMovimentacao : Form
    {
        public frmFiltroRelatorioMovimentacao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //frmBaseRelatorioMovimentacao frm = new frmBaseRelatorioMovimentacao();
            //frm.CarregaRelatorio(Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text));
            //frm.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDataInicial.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmFiltroRelatorioMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

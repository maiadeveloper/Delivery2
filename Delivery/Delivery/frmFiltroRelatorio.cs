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
    public partial class frmFiltroRelatorio : Form
    {
        public frmFiltroRelatorio()
        {
            InitializeComponent();
            btnLimpar.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFiltroRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDataInicial.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBaseRletorioGeralPedidos frm = new frmBaseRletorioGeralPedidos();
            frm.CarregaRelatorio(Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text));
            frm.ShowDialog();
        }
    }
}

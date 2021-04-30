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
    public partial class frmSuporteTecnico : Form
    {
        public frmSuporteTecnico()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuporteTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmSuporteTecnico_Load(object sender, EventArgs e)
        {
            txtSobre.Text = $"Aviso:  este programa de computador é protegido  por leis de direitos autorais e tratatos internacionais. " +
                            $"A reprodução ou distribuição  não-autorizada  desde programa , ou qualquer parte dele, poderá " +
                            $"resultar em severas punições civis e criminais, e os infratores serão punidos dentro " +
                            $"do máximo rigor  permitido  por lei. {Util.CarregaBuildSistema()}";
        }
    }
}

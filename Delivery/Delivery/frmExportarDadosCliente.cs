using System;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmExportarDadosCliente : Form
    {
        public frmExportarDadosCliente()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (ckbNome.Checked == true || ckbCelular.Checked == true || ckbEmail.Checked == true)
            {
                Util.ExportarDadosClientes(ckbNome.Checked, ckbCelular.Checked, ckbEmail.Checked);
            }
            else
            {
                MessageBox.Show("Selecione ao menos um campo", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

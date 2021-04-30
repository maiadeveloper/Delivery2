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
    public partial class frmBaseRelatorioMovimentacaoCliente : Form
    {
        
        public frmBaseRelatorioMovimentacaoCliente()
        {
            InitializeComponent();
        }

        private void frmBaseRelatorioMovimentacaoCliente_Load(object sender, EventArgs e)
        {
        }

        private void frmBaseRelatorioMovimentacaoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        public void CarregaReport(List<SaldoCliente> listaSaldo)
        {
            if (listaSaldo.Count != 0)
            {
                btnMensagem.Visible = false;

                foreach (var item in listaSaldo)
                {
                    DataSetRelatorios.MovimentacaoCliente.AddMovimentacaoClienteRow(item.codCliente.ToString(), item.nomeCliente, item.cpf, item.saldo);
                }

                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                btnMensagem.Visible = true;
            }
        }
    }
}

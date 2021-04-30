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
    public partial class frmFiltroPedidoClienteAbertoFechado : Form
    {
        public frmFiltroPedidoClienteAbertoFechado()
        {
            InitializeComponent();
        }

        string status = "Todos";
        int? clienteId = null;

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmBaseRelatorioClientesAbertoFechado frm = new frmBaseRelatorioClientesAbertoFechado();
            frm.CarregaRelatorio(Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text), clienteId, status);
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFiltroPedidoClienteAbertoFechado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmBaseRelatorioClientesAbertoFechado frm = new frmBaseRelatorioClientesAbertoFechado();
                frm.CarregaRelatorio(Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text), clienteId, status);
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbAberto_CheckedChanged(object sender, EventArgs e)
        {
            status = "não pago";
        }

        private void rbFechado_CheckedChanged(object sender, EventArgs e)
        {
            status = "pago";
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            status = "Todos";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            pPrincipal.Visible = false;

            frmTodosClientes frm = new frmTodosClientes();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.cliente != null)
            {
                clienteId = frm.cliente.ClienteId;
                txtNome.Text = frm.cliente.Nome;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDataInicial.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            clienteId = null;
        }
    }
}

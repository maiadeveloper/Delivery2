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
    public partial class frmTodosFuncionarios : Form
    {
        int count = 0;

        public frmTodosFuncionarios()
        {
            InitializeComponent();
            CarregaListagemClientes();
        }

        private void CarregaListagemClientes()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwFuncionarios.Items.Clear();
                txtQtdeItem.Clear();
                count = 0;

                var funcionarios = db.Funcionarios.Where(c => c.Nome.Contains(txtParametroBusca.Text)).ToList();

                if (funcionarios.Count != 0)
                {
                    lwFuncionarios.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var funcionario in funcionarios)
                    {
                        lwFuncionarios.Items.Add(funcionario.FuncionarioId.ToString());
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.Situcao);
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.Nome);
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.Funcao.Nome);
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.CPF);
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.Celular);
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.FoneResidencial);
                        lwFuncionarios.Items[count].SubItems.Add(funcionario.FoneComercial);

                        count++;
                    }

                    txtQtdeItem.Text = lwFuncionarios.Items.Count.ToString();
                }
                else
                {
                    lwFuncionarios.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;
            frmFuncionario frm = new frmFuncionario();
            frm.ShowDialog();
            pPrincipal.Visible = true;
            CarregaListagemClientes();
        }

        private void lwFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            if (lwFuncionarios.Items.Count > 0)
            {
                pPrincipal.Visible = false;

                frmFuncionario frm = new frmFuncionario();
                frm.SelecionarFuncionarioId(int.Parse(lwFuncionarios.FocusedItem.SubItems[0].Text));
                frm.ShowDialog();
                pPrincipal.Visible = true;
                CarregaListagemClientes();
            }
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemClientes();
        }

        private void frmTodosFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

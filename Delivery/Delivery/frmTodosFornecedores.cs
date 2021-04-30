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
    public partial class frmTodosFornecedores : Form
    {
        int count = 0;

        public frmTodosFornecedores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;
            frmFornecedor frm = new frmFornecedor();
            frm.ShowDialog();
            CarregaListagemFornecedores();
            pPrincipal.Visible = true;
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemFornecedores();
        }

        private void CarregaListagemFornecedores()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwFornecedores.Items.Clear();
                txtQtdeItem.Clear();
                count = 0;

                var fornecedores = db.Fornecedores.Where(f => f.Razao.Contains(txtParametroBusca.Text)
                    || f.Fantasia.Contains(txtParametroBusca.Text)
                    || f.CNPJCPF.Contains(txtParametroBusca.Text)).ToList();

                if (fornecedores.Count != 0)
                {
                    lwFornecedores.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var item in fornecedores)
                    {
                        lwFornecedores.Items.Add(item.FornecedorId.ToString());
                        lwFornecedores.Items[count].SubItems.Add(item.Razao);
                        lwFornecedores.Items[count].SubItems.Add(item.Fantasia);
                        lwFornecedores.Items[count].SubItems.Add(item.CNPJCPF);

                        count++;
                    }

                    txtQtdeItem.Text = lwFornecedores.Items.Count.ToString();
                }
                else
                {
                    lwFornecedores.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void lwFornecedores_DoubleClick(object sender, EventArgs e)
        {
            if (lwFornecedores.Items.Count > 0)
            {
                pPrincipal.Visible = false;
                int id = Convert.ToInt32(lwFornecedores.FocusedItem.SubItems[0].Text);
                frmFornecedor frm = new frmFornecedor();
                frm.SelecionarFornecedorID(id);
                frm.ShowDialog();
                CarregaListagemFornecedores();
                pPrincipal.Visible = true;
            }
        }

        private void frmTodosFornecedores_Load(object sender, EventArgs e)
        {
            CarregaListagemFornecedores();
        }

        private void frmTodosFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

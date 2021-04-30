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
    public partial class frmTodasClassesLancamento : Form
    {
        int count = 0;

        public frmTodasClassesLancamento()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmClasseLancamentos frm = new frmClasseLancamentos();
            pPrincipal.Visible = false;
            frm.ShowDialog();
            CarregaListagemClassesLancamentos();
            pPrincipal.Visible = true;
        }

        private void CarregaListagemClassesLancamentos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwSubclassesLancamentos.Items.Clear();
                txtQtdeItem.Clear();
                count = 0;

                var classes = db.CategoriaLancamento.Where(c => c.Nome.Contains(txtParametroBusca.Text)).ToList();

                if (classes.Count != 0)
                {
                    lwSubclassesLancamentos.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var item in classes)
                    {
                        lwSubclassesLancamentos.Items.Add(item.ID.ToString());
                        lwSubclassesLancamentos.Items[count].SubItems.Add(item.Nome.ToUpper());
                        count++;
                    }

                    txtQtdeItem.Text = lwSubclassesLancamentos.Items.Count.ToString();
                }
                else
                {
                    lwSubclassesLancamentos.Visible = false;
                    btnMensagem.Visible = true;
                }
            }
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemClassesLancamentos();
        }

        private void frmTodasClassesLancamento_Load(object sender, EventArgs e)
        {
            CarregaListagemClassesLancamentos();
        }

        private void lwSubclassesLancamentos_DoubleClick(object sender, EventArgs e)
        {
            if (lwSubclassesLancamentos.Items.Count > 0)
            {
                pPrincipal.Visible = false;
                int id = Convert.ToInt32(lwSubclassesLancamentos.FocusedItem.SubItems[0].Text);

                frmClasseLancamentos frm = new frmClasseLancamentos();

                frm.CarregaClasseSelecionado(id);
                frm.ShowDialog();
                CarregaListagemClassesLancamentos();
                pPrincipal.Visible = true;
            }
        }

        private void frmTodasClassesLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

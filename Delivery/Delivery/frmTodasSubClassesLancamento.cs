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
    public partial class frmTodasSubClassesLancamento : Form
    {
        public frmTodasSubClassesLancamento()
        {
            InitializeComponent();
            CarregaListagemSubClassesLancamentos();
        }

        int count = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmSubClasseLancamento frm = new frmSubClasseLancamento();
            pPrincipal.Visible = false;
            frm.ShowDialog();
            CarregaListagemSubClassesLancamentos();
            pPrincipal.Visible = true;
        }

        private void CarregaListagemSubClassesLancamentos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwSubclassesLancamentos.Items.Clear();
                txtQtdeItem.Clear();
                count = 0;

                var subClasses = db.SubCategoriaLancamento.Where(s => s.Nome.Contains(txtParametroBusca.Text) || s.Nome.Contains(txtParametroBusca.Text)).ToList();

                if (subClasses.Count != 0)
                {
                    lwSubclassesLancamentos.Visible = true;
                    btnMensagem.Visible = false;

                    foreach (var item in subClasses)
                    {
                        lwSubclassesLancamentos.Items.Add(item.ID.ToString());
                        lwSubclassesLancamentos.Items[count].SubItems.Add(item.Nome.ToUpper());
                        lwSubclassesLancamentos.Items[count].SubItems.Add(item.CategoriaLancamento.Nome.ToUpper());

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
            CarregaListagemSubClassesLancamentos();
        }

        private void lwSubclassesLancamentos_DoubleClick(object sender, EventArgs e)
        {
            if (lwSubclassesLancamentos.Items.Count > 0)
            {
                pPrincipal.Visible = false;
                int id = Convert.ToInt32(lwSubclassesLancamentos.FocusedItem.SubItems[0].Text);

                frmSubClasseLancamento frm = new frmSubClasseLancamento();

                frm.CarregaSubClasseSelecionado(id);
                frm.ShowDialog();
                CarregaListagemSubClassesLancamentos();
                pPrincipal.Visible = true;
            }
        }

        private void frmTodasSubClassesLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

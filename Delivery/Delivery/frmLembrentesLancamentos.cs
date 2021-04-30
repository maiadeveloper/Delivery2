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
    public partial class frmLembrentesLancamentos : Form
    {
        public frmLembrentesLancamentos()
        {
            InitializeComponent();
        }

        int contador = 0;
        decimal totalPagar = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaListaContasAPagar()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var lancamentos = db.Lancamentos.Where(l => l.Situacao.Equals("não pago")).ToList();
                contador = 0;
                totalPagar = 0;
                listViewLancamentos.Items.Clear();
                int diasAtraso;

                if (lancamentos.Count > 0)
                {
                    foreach (var item in lancamentos)
                    {
                        diasAtraso = DiasAtraso(item.DataVencimento);

                        if ((diasAtraso <= 5) || (DateTime.Now >= item.DataVencimento))
                        {
                            listViewLancamentos.Items.Add(item.LancamentoID.ToString());
                            listViewLancamentos.Items[contador].SubItems.Add(item.Fornecedor.Fantasia);
                            listViewLancamentos.Items[contador].SubItems.Add(item.Descricao);
                            listViewLancamentos.Items[contador].SubItems.Add(item.DataVencimento.ToString("dd/MM/yyyy dddddddddddddd"));
                            listViewLancamentos.Items[contador].SubItems.Add(item.ValorPrincipal.ToString("C"));
                            listViewLancamentos.Items[contador].SubItems.Add(DiasAtraso(item.DataVencimento).ToString());

                            AlterarFundoCorList(diasAtraso);

                            contador++;

                            totalPagar += item.ValorPrincipal;
                        }
                    }

                    txtQtde.Text = listViewLancamentos.Items.Count.ToString();
                    txtTotalGeral.Text = totalPagar.ToString("C");
                }
            }
        }

        private void AlterarFundoCorList(int diasAtraso)
        {
            if (diasAtraso.ToString().StartsWith("-"))
            {
                listViewLancamentos.Items[contador].UseItemStyleForSubItems = false;
                listViewLancamentos.Items[contador].SubItems[5].BackColor = Color.Red;
            }
            else if (diasAtraso <= 5)
            {
                listViewLancamentos.Items[contador].UseItemStyleForSubItems = false;
                listViewLancamentos.Items[contador].SubItems[5].BackColor = Color.LimeGreen;
            }
        }

        private void frmLembrentesLancamentos_Load(object sender, EventArgs e)
        {
            CarregaListaContasAPagar();
        }

        public int DiasAtraso(DateTime dataVencimeto)
        {
            TimeSpan intervalo = DateTime.Now.Subtract(dataVencimeto);
            return -intervalo.Days + 1;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaListaContasAPagar();
        }

        private void btnTodosLançamentos_Click(object sender, EventArgs e)
        {
            this.Close();

            frmTodosLancamentos frm = new frmTodosLancamentos(null);
            frm.ShowDialog();
        }

        private void frmLembrentesLancamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

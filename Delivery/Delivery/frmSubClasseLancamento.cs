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
    public partial class frmSubClasseLancamento : Form
    {
        public SubCategoriaLancamento subCategoriaLancamento = new SubCategoriaLancamento();

        public frmSubClasseLancamento()
        {
            InitializeComponent();
        }

        int? id = null;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSubClasseLancamento_Load(object sender, EventArgs e)
        {
            CarregaComboCategoria();
        }

        private void CarregaComboCategoria()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var categoriaLancamento = db.CategoriaLancamento.ToList();

                if (categoriaLancamento.Count > 0)
                {
                    txtClasseLancamento.DataSource = categoriaLancamento.ToList();
                    txtClasseLancamento.ValueMember = "ID";
                    txtClasseLancamento.DisplayMember = "Nome";

                    txtClasseLancamento.Text = "Selecionar...";
                }
            }
        }

        public void CarregaSubClasseSelecionado(int id)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var subCategoriaLancamento = db.SubCategoriaLancamento.Where(s => s.ID == id).FirstOrDefault();

                if (subCategoriaLancamento != null)
                {
                    this.id = id;
                    txtClasseLancamento.Text = db.CategoriaLancamento.Find(subCategoriaLancamento.ID).Nome;
                    txtSubclasseLancamento.Text = subCategoriaLancamento.Nome;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                Salvar();
            }
            else
            {
                //Alterar();
            }
        }

        private void Salvar()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var subCategoriaLancamento = new SubCategoriaLancamento();

                if (txtClasseLancamento.Text.Equals("Selecionar..."))
                {
                    MessageBox.Show("Campo obrigatório! Selecione uma classe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtClasseLancamento.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSubclasseLancamento.Text))
                {
                    MessageBox.Show("Campo obrigatório! Informe o nome da sub-classe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtSubclasseLancamento.Focus();
                    return;
                }
                subCategoriaLancamento.CategoriaLancamentoID = Convert.ToInt32(txtClasseLancamento.SelectedValue);
                subCategoriaLancamento.DataCadastro = DateTime.Now;
                subCategoriaLancamento.Ativo = true;
                subCategoriaLancamento.Nome = txtSubclasseLancamento.Text;

                if (MessageBox.Show("Confirma salvar esta nova sub-classe ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.SubCategoriaLancamento.Add(subCategoriaLancamento);
                    db.SaveChanges();

                    this.subCategoriaLancamento = subCategoriaLancamento;

                    MessageBox.Show("Sub-classe salva com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja incluir uma nova sub-classe ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtClasseLancamento.Text = "Selecionar...";
                        txtClasseLancamento.Focus();
                        txtSubclasseLancamento.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void Alterar()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var subCategoriaLancamento = db.SubCategoriaLancamento.Where(s => s.ID == id).FirstOrDefault();

                subCategoriaLancamento.ID = Convert.ToInt32(txtClasseLancamento.SelectedValue);
                subCategoriaLancamento.Nome = txtSubclasseLancamento.Text;

                if (MessageBox.Show("Confirma a alteração desta sub-classe?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.SaveChanges();

                    MessageBox.Show("Sub-classe alterado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void frmSubClasseLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

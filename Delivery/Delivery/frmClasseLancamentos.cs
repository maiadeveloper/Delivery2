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
using Delivery.Model;

namespace Delivery
{
    public partial class frmClasseLancamentos : Form
    {
        public CategoriaLancamento categoriaLancamento = new CategoriaLancamento();

        public frmClasseLancamentos()
        {
            InitializeComponent();
        }

        int? id = null;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                var classe = new CategoriaLancamento();

                classe.DataCadastro = DateTime.Now;
                classe.Ativo = true;
                classe.Nome = txtClasseLancamento.Text;

                if (MessageBox.Show("Confirma salvar esta nova classe ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    db.CategoriaLancamento.Add(classe);
                    db.SaveChanges();

                    this.categoriaLancamento = classe;

                    MessageBox.Show("Classe salva com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja incluir uma nova classe ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtClasseLancamento.Focus();
                        txtClasseLancamento.Clear();
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
                var classe = db.CategoriaLancamento.Where(c => c.ID == id).FirstOrDefault();

                if (MessageBox.Show("Confirma alteração desta classe ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    classe.Nome = txtClasseLancamento.Text;
                    db.SaveChanges();

                    MessageBox.Show("Classe alterada com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja incluir uma nova classe ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtClasseLancamento.Focus();
                        txtClasseLancamento.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        public void CarregaClasseSelecionado(int id)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var classe = db.CategoriaLancamento.Where(c => c.ID == id).FirstOrDefault();

                if (classe != null)
                {
                    this.id = id;
                    txtClasseLancamento.Text = classe.Nome;
                }
            }
        }

        private void frmClasseLancamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

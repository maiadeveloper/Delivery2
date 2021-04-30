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
    public partial class frmBanco : Form
    {
        int? bancoId = null;

        public frmBanco()
        {
            InitializeComponent();
            IniciarNovoCadastro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (bancoId == null)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                    {
                        MessageBox.Show("Campo obrigatório! - Informe o nome do banco", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }

                    if (ConsultaNomeBancoExistente(txtNome.Text, db) != true)
                    {
                        Banco banco = new Banco();

                        banco.DataCadastro = DateTime.Now;
                        banco.Descricao = txtNome.Text;

                        db.Bancos.Add(banco);
                        db.SaveChanges();
                    }
                    else
                    {
                        return;
                    }

                    if (MessageBox.Show("Banco cadastrado com sucesso \n\n\nDeseja cadastrar um novo banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IniciarNovoCadastro();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private Boolean ConsultaNomeBancoExistente(string nomeBanco, MyDataContextConfiguration db)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(nomeBanco))
            {
                var bancos = db.Bancos.Where(b => b.Descricao.Contains(nomeBanco)).ToList();

                if (bancos.Count > 0)
                {
                    MessageBox.Show("Banco já encontra-se cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    txtNome.Clear();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        private void IniciarNovoCadastro()
        {
            txtNome.Focus();
            txtNome.Clear();
            bancoId = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

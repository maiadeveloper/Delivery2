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
    public partial class frmAlterarSenhaUser : Form
    {
        int operadorId;

        public frmAlterarSenhaUser(Operador operador)
        {
            InitializeComponent();
            operadorId = operador.OperadorId;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe a nova senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaNova.Focus();
                return;
            }
            if (txtConfirmacaoSenha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe a confirmação da senha", "?Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmacaoSenha.Focus();
                return;
            }

            if (MessageBox.Show("Confirma a alteração da senha!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {

                    var operador = db.Operadores.Find(operadorId);

                    if (operador != null)
                    {
                        operador.Senha = txtSenhaNova.Text;
                        db.SaveChanges();
                        
                        MessageBox.Show("Senha alterada com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpa campos
                        txtConfirmacaoSenha.Clear();
                        txtSenhaNova.Clear();
                    }
                }
            }
        }

        private void frmAlterarSenhaUser_Load(object sender, EventArgs e)
        {
            txtSenhaNova.Focus();
        }

        private void txtConfirmacaoSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text.Trim() != txtConfirmacaoSenha.Text.Trim())
            {
                MessageBox.Show("Senha de confirmação não confere com a nova senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmacaoSenha.Clear();
            }
        }

        private void frmAlterarSenhaUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

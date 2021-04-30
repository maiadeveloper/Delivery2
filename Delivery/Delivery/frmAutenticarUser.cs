using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmAutenticarUser : Form
    {
        public frmAutenticarUser()
        {
            InitializeComponent();
        }

        public Operador operador = new Operador();

        private void frmAutenticarUser_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
            CarregaBuildSistema();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método carrega informações referente ao versão - build do sistema
        private void CarregaBuildSistema()
        {
            lblSobre.Text = "Sistema de Informação para Gerenciamento de Delivery \n" + Util.CarregaBuildSistema();
        }

        private void AutenticarUsuarioSistema()
        {
            try
            {
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    txtLogin.Focus();
                    MessageBox.Show("Informe o login!!!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    txtSenha.Focus();
                    MessageBox.Show("Informe a senha!!!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var operador = db.Operadores.Where(o => o.Login == txtLogin.Text && o.Senha == txtSenha.Text).FirstOrDefault();

                    if (operador != null)
                    {

                        this.operador = operador;
                        GravaLogAcesso(operador.OperadorId);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        txtSenha.Focus();
                        MessageBox.Show("Usuário ou senha incorretos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção usuário - Contate o administrador do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravaLogAcesso(int operadorId)
        {
            if (operadorId > 0)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    LogAcesso logAcesso = new LogAcesso();

                    logAcesso.DataHora = DateTime.Now;
                    logAcesso.OperadorId = operadorId;

                    db.LogAcessos.Add(logAcesso);
                    db.SaveChanges();
                }
            }
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            AutenticarUsuarioSistema();
        }

        private void frmAutenticarUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnEntrar_Click(this, e);
            }
        }

        private void pcBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcBoxFechar_MouseHover(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pcBoxFechar_MouseLeave(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.SteelBlue;
        }
    }
}

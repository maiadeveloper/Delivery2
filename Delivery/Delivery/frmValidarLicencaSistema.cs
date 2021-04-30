using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmValidarLicencaSistema : Form
    {
        public frmValidarLicencaSistema()
        {
            InitializeComponent();
        }

    
        private void btnValidarLicenca_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtChaveAcesso.Text == string.Empty)
                {
                    txtChaveAcesso.Focus();
                    MessageBox.Show("Selecione o arquivo fornecido pelo administrador do sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Util.EscreverChaveLicenca(txtChaveAcesso.Text);

                if (Util.ValidarSistema() == false)
                {
                    txtChaveAcesso.Focus();
                    MessageBox.Show("A chave de acesso informada não é valida. Informe uma chave valida por gentileza", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChaveAcesso.Clear();
                    return;
                } 

                MessageBox.Show("Validação realizada com sucesso. Reinicie o sistema para que as demais funções sejam estabelecidas.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no gravação do Registro: " + erro.Message);
            }
        }

        private void frmValidarLicencaSistema_Load(object sender, EventArgs e)
        {
            txtChaveAcesso.Focus();
        }

        private void txtChaveAcesso_Leave(object sender, EventArgs e)
        {
            if(txtChaveAcesso.Text != string.Empty)
            {
                btnValidarLicenca.Enabled = true;
                pbImageOk.Visible = true;
            }
        }
    }
}

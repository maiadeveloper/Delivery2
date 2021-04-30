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
    public partial class frmContaCorrente : Form
    {
        int? contaCorrenteId = null;

        public frmContaCorrente()
        {
            InitializeComponent();
        }

        private void IniciarNovoCadastro()
        {
            CarregaComboCategoria();
            txtAgencia.Clear();
            txtContaCorrente.Clear();
            contaCorrenteId = null;
            txtBancos.Focus();
        }

        private void CarregaComboCategoria()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var bancos = db.Bancos.OrderBy(b => b.Descricao).ToList();

                if (bancos.Count > 0)
                {
                    txtBancos.DataSource = bancos.ToList();
                    txtBancos.ValueMember = "BancoId";
                    txtBancos.DisplayMember = "Descricao";

                    txtBancos.Text = "Selecionar...";
                }
            }
        }

        private Boolean ConsultaContaCorrenteExist(int bancoId, string agencia, string cc, MyDataContextConfiguration db)
        {
            bool result = false;

            var contaCorrente = db.ContaCorrentes.Where(c => c.BancoId == bancoId && c.Agencia.Equals(agencia) && c.NumeroCC.Equals(cc)).FirstOrDefault();

            if (contaCorrente != null)
            {
                MessageBox.Show("Conta corrente já encontra-se cadastrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAgencia.Clear();
                txtContaCorrente.Clear();
                txtBancos.Focus();
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (contaCorrenteId == null)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    if (txtBancos.Text.Equals("Selecionar..."))
                    {
                        MessageBox.Show("Campo obrigatório! - Informe o nome do banco", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBancos.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(txtAgencia.Text.Trim()))
                    {
                        MessageBox.Show("Campo obrigatório! - Informe a agência", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAgencia.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(txtContaCorrente.Text.Trim()))
                    {
                        MessageBox.Show("Campo obrigatório! - Informe o número da conta corrente", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContaCorrente.Focus();
                        return;
                    }

                    if (ConsultaContaCorrenteExist(Convert.ToInt32(txtBancos.SelectedValue), txtAgencia.Text, txtContaCorrente.Text, db) != true)
                    {
                        ContaCorrente contaCorrente = new ContaCorrente();

                        contaCorrente.DataCadastro = DateTime.Now;
                        contaCorrente.DescricaoContaCorrente = string.Format("Agência: {0} | Conta corrente: {1}", txtAgencia.Text, txtContaCorrente.Text);
                        contaCorrente.BancoId = Convert.ToInt32(txtBancos.SelectedValue);
                        contaCorrente.Agencia = txtAgencia.Text;
                        contaCorrente.NumeroCC = txtContaCorrente.Text;

                        db.ContaCorrentes.Add(contaCorrente);
                        db.SaveChanges();
                    }
                    else
                    {
                        return;
                    }

                    if (MessageBox.Show("Conta corrente cadastrado com sucesso \n\n\nDeseja cadastrar uma nova conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void frmContaCorrente_Load(object sender, EventArgs e)
        {
            IniciarNovoCadastro();
            txtBancos.Focus();
        }

        private void frmContaCorrente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

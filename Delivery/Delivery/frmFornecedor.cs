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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        int? forncedorID = null;
        public Fornecedor fornecedor = new Fornecedor();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (forncedorID == null)
            {
                SalvarFornecedor();
            }
            else
            {
                AlterarFornecedor();
            }
        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrEmpty(txtRazaoSocial.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe a razão social", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtRazaoSocial.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtRazaoSocial.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe o nome fantasia", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtRazaoSocial.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AlterarFornecedor()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var fornecedor = db.Fornecedores.Find(forncedorID);

                if (ValidarCamposObrigatorios())
                {
                    fornecedor.DataHora = DateTime.Now;
                    fornecedor.CNPJCPF = txtCPFCNPJ.Text;
                    fornecedor.Fantasia = txtNomeFantasia.Text;
                    fornecedor.Razao = txtRazaoSocial.Text;
                }

                else
                {
                    return;
                }

                if (MessageBox.Show("Confirma alterar informações deste fornecedor ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.SaveChanges();

                    MessageBox.Show("Fornecedor alterado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void SalvarFornecedor()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var fornecedor = new Fornecedor();

                if (ValidarCamposObrigatorios())
                {
                    fornecedor.DataHora = DateTime.Now;
                    fornecedor.CNPJCPF = txtCPFCNPJ.Text;
                    fornecedor.Fantasia = txtNomeFantasia.Text;
                    fornecedor.Razao = txtRazaoSocial.Text;
                }
                else
                {
                    return;
                }

                if (MessageBox.Show("Confirma salvar esta fornecedor ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Fornecedores.Add(fornecedor);
                    db.SaveChanges();

                    this.fornecedor = fornecedor;

                    MessageBox.Show("Fornecedor salvo com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja incluir um novo registro ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtRazaoSocial.Focus();
                        txtRazaoSocial.Clear();
                        txtCPFCNPJ.Clear();
                        txtNomeFantasia.Clear();
                        rbCNPJ.Checked = false;
                        rbCPF.Checked = false;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        public void SelecionarFornecedorID(int id)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var fornecedor = db.Fornecedores.Find(id);

                if (fornecedor != null)
                {
                    this.forncedorID = id;

                    if (fornecedor.CNPJCPF.Length > 14)
                    {
                        rbCNPJ.Checked = true;
                        txtCPFCNPJ.Mask = "99.999.999/9999-99";
                    }
                    else
                    {
                        rbCPF.Checked = true;
                        txtCPFCNPJ.Mask = "999,999,999-99";
                    }

                    txtCPFCNPJ.Text = fornecedor.CNPJCPF;
                    txtNomeFantasia.Text = fornecedor.Fantasia;
                    txtRazaoSocial.Text = fornecedor.Razao;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            //850.650.993-11
            txtCPFCNPJ.Mask = "999,999,999-99";
            txtCPFCNPJ.Focus();
            txtCPFCNPJ.Clear();
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            //78.425.986/0036-15
            txtCPFCNPJ.Mask = "99,999,999/9999-99";
            txtCPFCNPJ.Focus();
            txtCPFCNPJ.Clear();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            txtRazaoSocial.Focus();
        }

        private void frmFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

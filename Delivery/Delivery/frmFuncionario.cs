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
    public partial class frmFuncionario : Form
    {
        int? funcionarioId = null;
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InciarNovoCadastro()
        {
            if (funcionarioId != null)
            {
                btnExcluir.Visible = true;
            }
            else
            {
                txtNome.Focus();
                txtSituacao.Text = "ATIVADO";
                txtUF.Text = "RO";
                txtMunicipio.Text = "PORTO VELHO";
                txtDtCad.Text = DateTime.Now.ToString();
                AlterarCorSituacao(txtSituacao.Text);

                CarregaComboCategoria();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o funcionário selecionado ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var funcionario = db.Funcionarios.Find(funcionarioId);

                    db.Funcionarios.Remove(funcionario);

                    db.SaveChanges();

                    MessageBox.Show("Funcionário excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcionarioId == null)
            {
                Salvar();
            }
            else
            {
                Editar();
            }
        }

        private void Salvar()
        {
            if (ValidarCamposObrigatorios() == true)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var funcionario = new Funcionario();

                    funcionario.Bairro = txtBairro.Text;
                    funcionario.CEP = txtCEP.Text;
                    funcionario.Conjuge = "";
                    funcionario.CPF = txtCPF.Text;
                    funcionario.DataCadastro = Convert.ToDateTime(txtDtCad.Text);
                    funcionario.DataNascimento = Convert.ToDateTime(txtDtNasc.Text);
                    funcionario.Email = txtEmail.Text;
                    funcionario.EstadoCivil = txtEstadoCivil.Text;
                    funcionario.FoneComercial = txtFoneComercial.Text.Length == 13 ? txtFoneComercial.Text : string.Empty;
                    funcionario.FoneResidencial = txtFoneComercial.Text.Length == 13 ? txtFoneResidencial.Text : string.Empty;
                    funcionario.Celular = txtCelular.Text.Length == 13 ? txtCelular.Text : string.Empty;
                    funcionario.FuncaoId = Convert.ToInt32(txtCargo.SelectedValue);
                    funcionario.GrauInstrucao = txtGrauInstrucao.Text;
                    funcionario.Municipio = txtMunicipio.Text;
                    funcionario.Nome = txtNome.Text;
                    funcionario.NomeMae = txtNomeMae.Text;
                    funcionario.NomePai = txtNomePai.Text;
                    funcionario.Numero = txtNumero.Text;
                    funcionario.PathFoto = "";
                    funcionario.QtdeFilhos = 0;
                    funcionario.Rua = txtRua.Text;
                    funcionario.Sexo = txtSexo.Text;
                    funcionario.Situcao = txtSituacao.Text;
                    funcionario.UF = txtUF.Text;

                    if (MessageBox.Show("Confirma salvar este novo funcionário ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Persiste o produto
                        db.Funcionarios.Add(funcionario);
                        db.SaveChanges();

                        MessageBox.Show("Funcionário salvo com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Deseja incluir um novo funcionário ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            InciarNovoCadastro();
                            LimpaCamposGeral();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void LimpaCamposGeral()
        {
            txtBairro.Clear();
            txtCelular.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
            txtDtCad.Clear();
            txtDtNasc.Clear();
            txtEmail.Clear();
            txtEstadoCivil.Text = "Selecionar...";
            txtFoneComercial.Clear();
            txtFoneResidencial.Clear();
            txtGrauInstrucao.Text = "Selecionar...";
            txtCargo.Text = "Selecionar...";
            txtMunicipio.Clear();
            txtNome.Clear();
            txtNomeMae.Clear();
            txtNomePai.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtSexo.Text = "Selecionar...";
            txtSituacao.Text = "ATIVO";
            txtUF.Text = "Selecionar...";

            InciarNovoCadastro();

            txtNome.Focus();
        }

        private void Editar()
        {
            if (ValidarCamposObrigatorios() == true)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var funcionario = db.Funcionarios.Find(funcionarioId);

                    funcionario.Bairro = txtBairro.Text;
                    funcionario.CEP = txtCEP.Text;
                    funcionario.Conjuge = "";
                    funcionario.CPF = txtCPF.Text;
                    funcionario.DataCadastro = Convert.ToDateTime(txtDtCad.Text);
                    funcionario.DataNascimento = Convert.ToDateTime(txtDtNasc.Text);
                    funcionario.Email = txtEmail.Text;
                    funcionario.EstadoCivil = txtEstadoCivil.Text;
                    funcionario.FoneComercial = txtFoneComercial.Text.Length == 13 ? txtFoneComercial.Text : string.Empty;
                    funcionario.FoneResidencial = txtFoneComercial.Text.Length == 13 ? txtFoneResidencial.Text : string.Empty;
                    funcionario.Celular = txtCelular.Text.Length == 13 ? txtCelular.Text : string.Empty;
                    funcionario.FuncaoId = Convert.ToInt32(txtCargo.SelectedValue);
                    funcionario.GrauInstrucao = txtGrauInstrucao.Text;
                    funcionario.Municipio = txtMunicipio.Text;
                    funcionario.Nome = txtNome.Text;
                    funcionario.NomeMae = txtNomeMae.Text;
                    funcionario.NomePai = txtNomePai.Text;
                    funcionario.Numero = txtNumero.Text;
                    funcionario.PathFoto = "";
                    funcionario.QtdeFilhos = 0;
                    funcionario.Rua = txtRua.Text;
                    funcionario.Sexo = txtSexo.Text;
                    funcionario.Situcao = txtSituacao.Text;
                    funcionario.UF = txtUF.Text;

                    if (MessageBox.Show("Confirma alteração a este funcionário ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Persiste o produto
                        db.SaveChanges();

                        MessageBox.Show("Funcionário alterado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Deseja incluir um novo funcionário ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            InciarNovoCadastro();
                            LimpaCamposGeral();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private bool ValidarCamposObrigatorios()
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o nome do funcionário!", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            if (txtDtNasc.Text.Length != 10)
            {
                MessageBox.Show("Campo obrigatório! informe a data de nascimento!", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtNasc.Focus();
                return false;
            }
            if (txtCPF.Text.Length != 14)
            {
                MessageBox.Show("Campo obrigatório! informe o Documento do funcionário!", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                return false;
            }
            if (txtCargo.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! informe o cargo do funcionário!", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            InciarNovoCadastro();
        }

        public void SelecionarFuncionarioId(int id)
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var funcionario = db.Funcionarios.Find(id);

                    if (funcionario != null)
                    {
                        CarregaComboCategoria();

                        this.funcionarioId = id;
                        txtDtCad.Text = Convert.ToDateTime(funcionario.DataCadastro).ToString("dd/MM/yyyy");
                        txtNome.Text = funcionario.Nome;
                        txtBairro.Text = funcionario.Bairro;
                        txtCargo.Text = db.Funcoes.Find(funcionario.FuncaoId).Nome;
                        txtCelular.Text = funcionario.Celular;
                        txtCEP.Text = funcionario.CEP;
                        txtCPF.Text = funcionario.CPF;
                        txtDtNasc.Text = Convert.ToDateTime(funcionario.DataNascimento).ToString("dd/MM/yyyy");
                        txtEmail.Text = funcionario.Email;
                        txtEstadoCivil.Text = funcionario.EstadoCivil;
                        txtFoneComercial.Text = funcionario.FoneComercial;
                        txtFoneResidencial.Text = funcionario.FoneResidencial;
                        txtGrauInstrucao.Text = funcionario.GrauInstrucao;
                        txtMunicipio.Text = funcionario.Municipio;
                        txtNomeMae.Text = funcionario.NomeMae;
                        txtNomePai.Text = funcionario.NomePai;
                        txtNumero.Text = funcionario.Numero;
                        txtRua.Text = funcionario.Rua;
                        txtSexo.Text = funcionario.Sexo;
                        txtSituacao.Text = funcionario.Situcao;
                        txtUF.Text = funcionario.UF;

                        AlterarCorSituacao(funcionario.Situcao);

                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregaComboCategoria()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var funcoes = db.Funcoes.ToList();

                if (funcoes.Count > 0)
                {
                    txtCargo.DataSource = funcoes.ToList();
                    txtCargo.ValueMember = "FuncaoId";
                    txtCargo.DisplayMember = "Nome";

                    txtCargo.Text = "Selecionar...";
                }
            }
        }

        private void txtSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlterarCorSituacao(txtSituacao.Text);
        }


        private void AlterarCorSituacao(string situacao)
        {
            txtSituacao.BackColor = situacao == "ATIVADO" ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
        }

        private void frmFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class frmLancamento : Form
    {
        public Operador operador = new Operador();
        int? id = null;

        public frmLancamento(Operador operador)
        {
            InitializeComponent();
            this.operador = operador;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                GravarLancamento();
            }
            else
            {
                AlterarLancamento();
            }
        }

        private void AlterarLancamento()
        {
            if (MessageBox.Show("Confirma alteração deste lançamento ?", "Confirmação de alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    if (ValidarCamposObrigatorios() == true)
                    {
                        try
                        {
                            var lancamento = db.Lancamentos.Find(id);

                            lancamento.CategoriaLancamentoID = Convert.ToInt32(txtClasseLancamento.SelectedValue);
                            lancamento.DataCadastro = Convert.ToDateTime(txtDataEntrada.Text);
                            lancamento.DataEmissao = Convert.ToDateTime(txtDataEmissao.Text);
                            lancamento.DataPgto = DateTime.MinValue;
                            lancamento.DataVencimento = Convert.ToDateTime(txtVencimentoInicial.Text);
                            lancamento.Descricao = txtDescricaoLancamento.Text;
                            lancamento.FornecedorId = Convert.ToInt32(txtFavorecido.SelectedValue);
                            lancamento.NumDoc = txtNumeroDoc.Text;
                            lancamento.NumParcela = txtQtdeParcela.Text;
                            lancamento.Situacao = "não pago";
                            lancamento.SubCategoriaLancamentoID = Convert.ToInt32(txtSubClasseLancamento.SelectedValue);
                            lancamento.TipoDocumentoId = Convert.ToInt32(txtTipoDocumento.SelectedValue);
                            lancamento.TipoLancamento = txtCategoria.Text;
                            lancamento.ValorDesconto = 0;
                            lancamento.ValorJuros = 0;
                            lancamento.ValorPrincipal = Convert.ToDecimal(txtValorDocumento.Text.Substring(2));

                            db.SaveChanges();
                        }
                        catch (Exception error)
                        {
                        }

                        MessageBox.Show("Lançamento alterado com sucesso", "Mensagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private Boolean ValidarCamposObrigatorios()
        {
            if (txtCategoria.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Informe tipo de lançamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return false;
            }
            if (txtFavorecido.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Informe o nome do favorecido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFavorecido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumeroDoc.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe o número do documento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return false;
            }
            if (txtTipoDocumento.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Informe o tipo de documento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoDocumento.Focus();
                return false;
            }

            if (txtClasseLancamento.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Informe a classe do lançamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClasseLancamento.Focus();
                return false;
            }
            if (txtSubClasseLancamento.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Informe a sub-classe do lançamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubClasseLancamento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDescricaoLancamento.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe a descrição do lançamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricaoLancamento.Focus();
                return false;
            }
            if (txtValorDocumento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe o valor do documento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorDocumento.Focus();
                return false;
            }
            if (txtNumeroDoc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe o número do documento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return false;
            }
            if (txtQtdeParcela.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! Selecione a quantidade de parcela(s)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdeParcela.Focus();
                return false;
            }
            if (Convert.ToDateTime(txtVencimentoInicial.Text) <= Convert.ToDateTime(txtDataEmissao.Text))
            {
                MessageBox.Show("Error! Vencimento inicial não pode ser inferior que data de emissão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVencimentoInicial.Focus();
                return false;
            }
            if (listViewParcelas.Items.Count == 0)
            {
                MessageBox.Show("Não existe itens incluido no parcelamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGerarParcelas.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GravarLancamento()
        {
            if (MessageBox.Show("Deseja salvar este lançamento ?", "Confirmação para salvar lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    if (ValidarCamposObrigatorios() == true)
                    {
                        for (int i = 1; i <= int.Parse(txtQtdeParcela.Text); i++)
                        {
                            try
                            {
                                Lancamento lancamento = new Lancamento();

                                lancamento.CategoriaLancamentoID = Convert.ToInt32(txtClasseLancamento.SelectedValue);
                                lancamento.DataCadastro = Convert.ToDateTime(txtDataEntrada.Text);
                                lancamento.DataEmissao = Convert.ToDateTime(txtDataEmissao.Text);
                                lancamento.DataPgto = null;
                                lancamento.DataVencimento = Convert.ToDateTime(DataVencimento(i).ToString("dd/MM/yyyy"));
                                lancamento.Descricao = txtDescricaoLancamento.Text;
                                lancamento.FornecedorId = Convert.ToInt32(txtFavorecido.SelectedValue);
                                lancamento.NumDoc = txtNumeroDoc.Text;
                                lancamento.NumParcela = i.ToString() + "/" + txtQtdeParcela.Text;
                                lancamento.Situacao = "não pago";
                                lancamento.SubCategoriaLancamentoID = Convert.ToInt32(txtSubClasseLancamento.SelectedValue);
                                lancamento.TipoDocumentoId = Convert.ToInt32(txtTipoDocumento.SelectedValue);
                                lancamento.TipoLancamento = txtCategoria.Text;
                                lancamento.ValorDesconto = 0;
                                lancamento.ValorJuros = 0;
                                lancamento.ValorPrincipal = Convert.ToDecimal(txtValorDocumento.Text.Substring(2));

                                db.Lancamentos.Add(lancamento);
                                db.SaveChanges();
                            }
                            catch (Exception error)
                            {
                            }
                        }

                        MessageBox.Show("Lançamento realizado com sucesso", "Mensagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Deseja realizar um novo lançamento ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txtDataEntrada.Focus();
                            LimparCampos();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtDataEmissao.Value = DateTime.Now;
            txtCategoria.Text = "Selecionar...";
            txtClasseLancamento.Text = "Selecionar...";
            txtDataEntrada.Value = DateTime.Now;
            txtDescricaoLancamento.Clear();
            txtEmpresa.Clear();
            txtFavorecido.Text = "Selecionar...";
            txtNumeroDoc.Clear();
            txtQtdeParcela.Text = "Selecionar...";
            txtSubClasseLancamento.Text = "Selecionar...";
            txtTipoDocumento.Text = "Selecionar...";
            txtTotalParcelas.Clear();
            txtValorDocumento.Clear();
            txtVencimentoInicial.Value = DateTime.Now;
            listViewParcelas.Items.Clear();
        }

        private void InciarNovoCadastro()
        {
            if (id != null)
            {
                btnExcluir.Visible = true;
            }
            else
            {
                tabControl1.TabPages.Remove(tabPageBaixar);
                txtDataEntrada.Focus();
            }
        }

        private void CarregaComboTipoDocumento()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var tipoDocumentos = db.TipoDocumentos.ToList();

                if (tipoDocumentos.Count > 0)
                {
                    txtTipoDocumento.DataSource = tipoDocumentos.ToList();
                    txtTipoDocumento.ValueMember = "TipoDocumentoId";
                    txtTipoDocumento.DisplayMember = "Nome";

                    txtTipoDocumento.Text = "Selecionar...";
                }
            }
        }

        private void CarregaComboFavorecido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var fornecedores = db.Fornecedores.ToList();

                if (fornecedores.Count > 0)
                {
                    txtFavorecido.DataSource = fornecedores.ToList();
                    txtFavorecido.ValueMember = "FornecedorId";
                    txtFavorecido.DisplayMember = "Fantasia";

                    txtFavorecido.Text = "Selecionar...";
                }
            }
        }

        private void CarregaClasseLancamento()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var classeLancamentos = db.CategoriaLancamento.ToList();

                if (classeLancamentos.Count > 0)
                {
                    txtClasseLancamento.DataSource = classeLancamentos.ToList();
                    txtClasseLancamento.ValueMember = "ID";
                    txtClasseLancamento.DisplayMember = "Nome";

                    txtClasseLancamento.Text = "Selecionar...";
                }
            }
        }

        private void CarregaSubClasseLancamento(int classeId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var SubclasseLancamentos = db.SubCategoriaLancamento.Where(s => s.CategoriaLancamentoID == classeId).ToList();

                if (SubclasseLancamentos.Count > 0)
                {
                    txtSubClasseLancamento.DataSource = SubclasseLancamentos.ToList();
                    txtSubClasseLancamento.ValueMember = "ID";
                    txtSubClasseLancamento.DisplayMember = "Nome";

                    txtSubClasseLancamento.Text = "Selecionar...";
                }
            }
        }

        private void frmLancamento_Load(object sender, EventArgs e)
        {
            if (id == null)
            {
                CarregaComboTipoDocumento();

                CarregaComboFavorecido();

                CarregaClasseLancamento();
            }
        }

        private void txtClasseLancamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtClasseLancamento.Text != "Selecionar...")
                {
                    txtSubClasseLancamento.Enabled = true;
                    CarregaSubClasseLancamento(Convert.ToInt32(txtClasseLancamento.SelectedValue));
                }
            }
            catch (Exception erro)
            {
                txtSubClasseLancamento.Enabled = false;
            }
        }

        private DateTime DataVencimento(int i)
        {
            DateTime dataVecimentoInicial = txtVencimentoInicial.Value;
            DateTime dataVencimentoParcela;

            if (i == 1)
            {
                return dataVecimentoInicial;
            }
            else
            {
                return dataVencimentoParcela = dataVecimentoInicial.AddMonths(i - 1);
            }
        }

        private void txtValorDocumento_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValorDocumento.Text = Convert.ToDecimal(txtValorDocumento.Text).ToString("C");
            }
            catch (Exception error)
            {
                //error
            }
        }

        private void txtDataEmissao_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataVecimentoInicial = txtDataEmissao.Value;
            txtVencimentoInicial.Value = dataVecimentoInicial.AddMonths(1);
        }

        public void SelecionarLancamentoId(int id)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var lancamento = db.Lancamentos.Find(id);

                if (lancamento != null)
                {
                    CarregaComboTipoDocumento();

                    CarregaComboFavorecido();

                    CarregaClasseLancamento();

                    this.id = id;

                    txtCategoria.Text = lancamento.TipoLancamento;
                    txtClasseLancamento.Text = lancamento.CategoriaLancamento.Nome;
                    txtDataEmissao.Text = lancamento.DataEmissao.ToString("dd/MM/yyyy");
                    txtDataEntrada.Text = lancamento.DataCadastro.ToString("dd/MM/yyyy");
                    txtDescricaoLancamento.Text = lancamento.Descricao;
                    txtEmpresa.Text = txtEmpresa.Text;
                    txtQtdeParcela.Text = lancamento.NumParcela;
                    txtFavorecido.Text = lancamento.Fornecedor.Fantasia;
                    txtNumeroDoc.Text = lancamento.NumDoc;
                    txtSubClasseLancamento.Text = lancamento.SubCategoriaLancamento.Nome;
                    txtTipoDocumento.Text = lancamento.TipoDocumento.Nome;
                    txtTotalParcelas.Text = lancamento.ValorPrincipal.ToString("C");
                    txtValorDocumento.Text = lancamento.ValorPrincipal.ToString("C");
                    txtVencimentoInicial.Text = lancamento.DataVencimento.ToString("dd/MM/yyyy");

                    btnGerarParcelas.Enabled = false;
                    txtQtdeParcela.Enabled = false;
                }
            }
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            if (txtValorDocumento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe o valor do documento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorDocumento.Focus();
                return;
            }
            if (txtNumeroDoc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Informe o número do documento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDoc.Focus();
                return;
            }
            if (id == null)
            {
                if (txtQtdeParcela.Text.Equals("Selecionar..."))
                {
                    MessageBox.Show("Campo obrigatório! Selecione a quantidade de parcela(s)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdeParcela.Focus();
                    return;
                }
            }
            if (Convert.ToDateTime(txtVencimentoInicial.Text) <= Convert.ToDateTime(txtDataEmissao.Text))
            {
                MessageBox.Show("Error! Vencimento inicial não pode ser inferior que data de emissão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVencimentoInicial.Focus();
                return;
            }

            int lvLinhaParcela = 0;
            decimal totalParcelas = 0;
            listViewParcelas.Items.Clear();

            for (int i = 1; i <= int.Parse(txtQtdeParcela.Text); i++)
            {
                listViewParcelas.Items.Add(i.ToString());
                listViewParcelas.Items[lvLinhaParcela].SubItems.Add("Ref ao documento de nº " + txtNumeroDoc.Text);
                listViewParcelas.Items[lvLinhaParcela].SubItems.Add(DataVencimento(i).ToString("dd/MM/yyyy dddddddddddddd"));
                listViewParcelas.Items[lvLinhaParcela].SubItems.Add(txtValorDocumento.Text.Substring(2));

                totalParcelas += Convert.ToDecimal(txtValorDocumento.Text.Substring(2));

                lvLinhaParcela++;
            }

            txtTotalParcelas.Text = Convert.ToDecimal(totalParcelas).ToString("C");
        }

        private void btnAddTipoDespesa_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;

            frmFornecedor frm = new frmFornecedor();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.fornecedor != null)
            {
                CarregaComboFavorecido();
                txtFavorecido.Text = frm.fornecedor.Fantasia;
                txtFavorecido.Focus();
            }
        }

        private void btnAddClasseLancamento_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;

            frmClasseLancamentos frm = new frmClasseLancamentos();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.categoriaLancamento != null)
            {
                CarregaClasseLancamento();
                txtClasseLancamento.Text = frm.categoriaLancamento.Nome;
                txtClasseLancamento.Focus();
            }
        }

        private void btnAddSubClasseLancamento_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;

            frmSubClasseLancamento frm = new frmSubClasseLancamento();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.subCategoriaLancamento != null)
            {
                try
                {
                    if (txtClasseLancamento.Text != "Selecionar...")
                    {
                        txtSubClasseLancamento.Enabled = true;
                        CarregaSubClasseLancamento(Convert.ToInt32(txtClasseLancamento.SelectedValue));
                    }
                }
                catch (Exception)
                {
                    txtSubClasseLancamento.Enabled = false;
                }

                txtSubClasseLancamento.Text = frm.subCategoriaLancamento.Nome;
                txtSubClasseLancamento.Focus();
            }
        }

        private void frmLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (listViewParcelas.Items.Count > 0)
                {
                    if (MessageBox.Show("Existe informações que não foram salvas! Deseja sair deste procedimento mesmo assim?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }

            }
        }
    }
}

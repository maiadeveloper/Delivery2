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
    public partial class frmProduto : Form
    {
        int? produtoId = null;

        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            InciarNovoCadastro();
        }

        private void InciarNovoCadastro()
        {
            if (produtoId != null)
            {
                btnExcluir.Visible = true;
            }
            else
            {
                CarregaComboCategoria();
                tabControl1.SelectTab("tabPage1");
                txtSituacao.Text = "ATIVADO";
                GetProdutoId();
                AlterarCorSituacao(txtSituacao.Text);
                txtDescricaoProduto.Focus();
            }
        }

        private void AlterarCorSituacao(string situacao)
        {
            txtSituacao.BackColor = situacao == "ATIVADO" ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void Alterar()
        {
            if (ValidaCamposObrigatorios() == true)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var produto = db.Produtos.Find(produtoId);

                    produto.CategoriaId = Convert.ToInt32(txtCategoria.SelectedValue);
                    produto.CodigoBarra = txtCodCodBarra.Text;
                    produto.DataHora = DateTime.Now;
                    produto.DescMax = Convert.ToDecimal(0);
                    produto.DescProm = Convert.ToDecimal(0);
                    produto.Valor = Convert.ToDecimal(txtValorServico.Text.Substring(2));
                    produto.ValorPcteSemanal = Convert.ToDecimal(txtVlrSemanal.Text.Substring(2));
                    produto.ValorPcteQuinzenal = Convert.ToDecimal(txtVlrQuinzenal.Text.Substring(2));
                    produto.ValorPcteMensal = Convert.ToDecimal(txtVlrMensal.Text.Substring(2));
                    produto.CustoAdicional = Convert.ToDecimal(txtGastoProduto.Text.Substring(2));
                    produto.Nome = txtDescricaoProduto.Text;
                    produto.Obs = txtObs.Text;
                    produto.Situacao = txtSituacao.Text;

                    if (MessageBox.Show("Confirma alterar este novo produto ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Persiste o produto
                        db.SaveChanges();

                        MessageBox.Show("Produto alterado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
            }
        }

        private void Salvar()
        {
            if (ValidaCamposObrigatorios() == true)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var produto = new Produto();

                    produto.CategoriaId = Convert.ToInt32(txtCategoria.SelectedValue);
                    produto.CodigoBarra = txtCodCodBarra.Text;
                    produto.DataHora = DateTime.Now;
                    produto.DescMax = Convert.ToDecimal(0);
                    produto.DescProm = Convert.ToDecimal(0);
                    produto.Valor = Convert.ToDecimal(txtValorServico.Text.Substring(2));
                    produto.ValorPcteSemanal = Convert.ToDecimal(txtVlrSemanal.Text.Substring(2));
                    produto.ValorPcteQuinzenal = Convert.ToDecimal(txtVlrQuinzenal.Text.Substring(2));
                    produto.ValorPcteMensal = Convert.ToDecimal(txtVlrMensal.Text.Substring(2));
                    produto.CustoAdicional = Convert.ToDecimal(txtGastoProduto.Text.Substring(2));
                    produto.Nome = txtDescricaoProduto.Text;
                    produto.Obs = txtObs.Text;
                    produto.Situacao = txtSituacao.Text;

                    if (MessageBox.Show("Confirma salvar este novo produto ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Persiste o produto
                        db.Produtos.Add(produto);
                        db.SaveChanges();

                        MessageBox.Show("Produto salvo com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Deseja incluir um novo produto ?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        public bool ValidaCamposObrigatorios()
        {
            if (txtCodCodBarra.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o codigo de barra", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCodBarra.Focus();
                return false;
            }
            if (txtCategoria.Text.Equals("Selecionar..."))
            {
                MessageBox.Show("Campo obrigatório! informe a categoria do produto", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return false;
            }
            if (txtDescricaoProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe a descrição do produto", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricaoProduto.Focus();
                return false;
            }
            if (txtGastoProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o valor do gasto com produto", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGastoProduto.Focus();
                return false;
            }
            if (txtValorServico.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o valor do produto", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorServico.Focus();
                return false;
            }


            if (txtVlrSemanal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o valor do produto - Pacote Semanal", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrSemanal.Focus();
                return false;
            }

            if (txtVlrQuinzenal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o valor do produto - Pacote Quinzenal", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrQuinzenal.Focus();
                return false;
            }

            if (txtVlrMensal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! informe o valor do produto - Pacocte Mensal", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVlrMensal.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        private void LimpaCamposGeral()
        {
            InciarNovoCadastro();
            txtCodCodBarra.Focus();
            txtDescricaoProduto.Clear();
            txtGastoProduto.Clear();
            txtObs.Clear();
            txtValorServico.Clear();
            txtVlrMensal.Clear();
            txtVlrQuinzenal.Clear();
            txtVlrSemanal.Clear();
            txtCategoria.Text = "Selecionar...";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (produtoId == null)
            {
                Salvar();
            }
            else
            {
                Alterar();
            }
        }

        private void CarregaComboCategoria()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var categorias = db.Categorias.ToList();

                if (categorias.Count > 0)
                {
                    txtCategoria.DataSource = categorias.ToList();
                    txtCategoria.ValueMember = "CategoriaId";
                    txtCategoria.DisplayMember = "Nome";

                    txtCategoria.Text = "Selecionar...";
                }
            }
        }

        private void GetProdutoId()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var produto = db.Produtos.OrderByDescending(p => p.ProdutoId).FirstOrDefault();

                if (produto == null)
                {
                    txtCodCodBarra.Text = AdicionaZero("1").ToString();
                }
                else
                {
                    produto.ProdutoId = produto.ProdutoId + 1;
                    txtCodCodBarra.Text = AdicionaZero(produto.ProdutoId.ToString());
                }
            }
        }

        protected string AdicionaZero(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }

        private void txtGastoProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                txtGastoProduto.Text = Convert.ToDecimal(txtGastoProduto.Text).ToString("C");
            }
            catch (Exception error) { }
        }

        private void txtValorServico_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValorServico.Text = Convert.ToDecimal(txtValorServico.Text).ToString("C");
            }
            catch(Exception error) { }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirProduto();
        }

        private void ExcluirProduto()
        {
            if (ConsultaProdutoIsPedido() == false && ConsultaProdutoIsRestricao() == false)
            {
                if (MessageBox.Show("Deseja excluir este produto ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        try
                        {
                            var produto = db.Produtos.Find(produtoId);

                            if (produto != null)
                            {
                                db.Produtos.Remove(produto);
                                db.SaveChanges();

                                MessageBox.Show("Produto excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Produto esta sendo ultilizado por uma ação no sistema!\nNão pode ser excluido", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private Boolean ConsultaProdutoIsPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var itemsPedido = db.ItensPedidos.Where(i => i.ProdutoId == produtoId).ToList();

                if (itemsPedido.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private Boolean ConsultaProdutoIsRestricao()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var restricoes = db.Restricoes.Where(r => r.ProdutoId == produtoId).ToList();

                if (restricoes.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void CarregaProdutoSelecionado(int produtoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var produto = db.Produtos.Find(produtoId);

                if (produto != null)
                {
                    this.produtoId = produtoId;
                    txtCodCodBarra.Text = produto.CodigoBarra;

                    CarregaComboCategoria();

                    txtCategoria.Text = db.Categorias.Where(c => c.CategoriaId == produto.CategoriaId).FirstOrDefault().Nome;

                    txtSituacao.Text = produto.Situacao;
                    txtDescricaoProduto.Text = produto.Nome;
                    txtGastoProduto.Text = produto.CustoAdicional.ToString("C");
                    txtValorServico.Text = produto.Valor.ToString("C");
                    txtVlrMensal.Text = produto.ValorPcteMensal.ToString("C");
                    txtVlrQuinzenal.Text = produto.ValorPcteQuinzenal.ToString("C");
                    txtVlrSemanal.Text = produto.ValorPcteSemanal.ToString("C");
                    txtObs.Text = produto.Obs;

                    AlterarCorSituacao(produto.Situacao);
                }
            }
        }

        private void txtSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlterarCorSituacao(txtSituacao.Text);
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtVlrSemanal_Leave(object sender, EventArgs e)
        {
            try
            {
                txtVlrSemanal.Text = Convert.ToDecimal(txtVlrSemanal.Text).ToString("C");
            }
            catch (Exception error) { }
        }

        private void txtVlrQuinzenal_Leave(object sender, EventArgs e)
        {
            try
            {
                txtVlrQuinzenal.Text = Convert.ToDecimal(txtVlrQuinzenal.Text).ToString("C");
            }
            catch (Exception error) { }
        }

        private void txtVlrMensal_Leave(object sender, EventArgs e)
        {
            try
            {
                txtVlrMensal.Text = Convert.ToDecimal(txtVlrMensal.Text).ToString("C");
            }
            catch (Exception error) { }
        }
    }
}

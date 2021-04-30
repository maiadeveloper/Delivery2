using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmCliente : Form
    {
        int count = 0;
        int countRestr = 0;
        int indexPosItem = 0;
        Cliente cliente = null;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            InciarNovoCadastro();

            if (lwMovimentacoes.Items.Count > 0)
            {
                btnZerarSaldo.Enabled = true;
            }
        }

        private void InciarNovoCadastro()
        {
            if (cliente == null)
            {
                btnExcluir.Enabled = false;
                btnRestricao.Enabled = false;
                btnAddEndereco.Enabled = false;
                btnZerarSaldo.Enabled = false;
                btnAdicionarCredito.Enabled = false;
            }
            else
            {
                tabControl1.SelectTab("tabPage1");
                txtSituacao.Text = "ATIVADO";
                txtUF.Text = "RO";
                txtCidade.Text = "PORTO VELHO";
                AlterarCorSituacao(txtSituacao.Text);
                btnRestricao.Enabled = true;
                btnExcluir.Enabled = true;
                btnZerarSaldo.Enabled = true;
                btnAddEndereco.Enabled = true;
                btnAdicionarCredito.Enabled = true;
            }

            txtSituacao.Text = "ATIVADO";
            txtUF.Text = "RO";
            txtCidade.Text = "PORTO VELHO";
            txtNome.Focus();
        }

        private void Salvar()
        {
            if (ValidarCamposGeralObrigatorios() == true)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    Cliente cliente = new Cliente();

                    cliente.Celular = txtCelular.Text;
                    cliente.Nome = txtNome.Text.Trim();
                    cliente.Documento = txtDocumento.Text;
                    cliente.DataHora = DateTime.Now;
                    cliente.DataNascimento = txtDataNascimento.Text.Equals("  /  /") ? cliente.DataNascimento : Convert.ToDateTime(txtDataNascimento.Text);
                    cliente.Email = txtEmail.Text.Trim() == string.Empty ? null : txtEmail.Text;
                    cliente.RG = txtRG.Text.Trim() == string.Empty ? null : txtRG.Text;
                    cliente.Situacao = txtSituacao.Text;
                    cliente.TelefoneComercial = txtFoneComercial.Text.Length != 14 ? null : txtFoneComercial.Text;
                    cliente.TelefoneResidencial = txtFoneComercial.Text.Length != 14 ? null : txtFoneResidencial.Text;

                    if (MessageBox.Show("Confirma salvar este novo cliente?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Persiste o cliente
                        db.Clientes.Add(cliente);
                        db.SaveChanges();

                        SalvarEnderecos(cliente.ClienteId);

                        MessageBox.Show("Cliente salvo com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Deseja incluir um novo cliente?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            LimpaCamposGeral();
                            InciarNovoCadastro();
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

        private void Alterar()
        {
            if (ValidarCamposGeralObrigatorios() == true)
            {
                //Persiste o cliente
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var cliente = db.Clientes.Where(c => c.ClienteId == this.cliente.ClienteId).FirstOrDefault();

                    cliente.Celular = txtCelular.Text;
                    cliente.Nome = txtNome.Text.Trim();
                    cliente.Documento = txtDocumento.Text;
                    cliente.DataHora = DateTime.Now;
                    cliente.DataNascimento = txtDataNascimento.Text.Equals("  /  /") ? cliente.DataNascimento : Convert.ToDateTime(txtDataNascimento.Text);
                    cliente.Email = txtEmail.Text.Trim() == string.Empty ? null : txtEmail.Text;
                    cliente.RG = txtRG.Text.Trim() == string.Empty ? null : txtRG.Text;
                    cliente.Situacao = txtSituacao.Text;
                    cliente.TelefoneComercial = txtFoneComercial.Text.Length != 13 ? null : txtFoneComercial.Text;
                    cliente.TelefoneResidencial = txtFoneComercial.Text.Length != 13 ? null : txtFoneResidencial.Text;

                    //AlterarEnderecos(cliente.ClienteId);

                    if (MessageBox.Show("Confirma a alteração deste cliente?", "Confirmação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.SaveChanges();

                        MessageBox.Show("Cliente alterado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private bool ValidarCamposGeralObrigatorios()
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatorio!\n\n Infome o nome do cliente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            else if (txtCelular.Text.Length != 15)
            {
                MessageBox.Show("Campo obrigatorio!\n\n Infome o número celular", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                return false;
            }
            if (txtRua.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatorio!\n\n Infome o nome da rua", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRua.Focus();
                return false;
            }
            else if (txtNumero.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatorio!\n\n Infome o número do endereço", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }
            else if (txtBairro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatorio!\n\n Infome o nme do bairro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SalvarEnderecos(int clienteId)
        {

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var endereco = new Endereco();

                endereco.ClienteId = clienteId;
                endereco.IsEnderecoEntrega = true;
                endereco.Rua = txtRua.Text;
                endereco.Numero = txtNumero.Text;
                endereco.Bairro = txtBairro.Text;
                endereco.Complemento = txtComplemento.Text;
                endereco.EntreRua = txtEntreRuas.Text;
                endereco.CEP = txtCeP.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.UF = txtUF.Text;

                db.Enderecos.Add(endereco);
                db.SaveChanges();

                LimparCamposEndereco();
            }
        }

        private void AlterarEnderecos(int clienteId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var endereco = db.Enderecos.Where(e => e.ClienteId == clienteId).FirstOrDefault();

                if (endereco != null)
                {
                    endereco.ClienteId = clienteId;
                    endereco.IsEnderecoEntrega = true;
                    endereco.Rua = txtRua.Text;
                    endereco.Numero = txtNumero.Text;
                    endereco.Bairro = txtBairro.Text;
                    endereco.Complemento = txtComplemento.Text;
                    endereco.EntreRua = txtEntreRuas.Text;
                    endereco.CEP = txtCeP.Text;
                    endereco.Cidade = txtCidade.Text;
                    endereco.UF = txtUF.Text;

                    db.SaveChanges();

                }
                else
                {
                    SalvarEnderecos(clienteId);
                }

                LimparCamposEndereco();
            }
        }

        private void LimparCamposEndereco()
        {
            txtBairro.Clear();
            txtCeP.Clear();
            txtComplemento.Clear();
            txtEntreRuas.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtRua.Focus();
        }

        private void LimpaCamposGeral()
        {
            txtNome.Clear();
            txtRG.Clear();
            txtDocumento.Clear();
            txtCelular.Clear();
            txtFoneComercial.Clear();
            txtEmail.Clear();
            txtFoneResidencial.Clear();
            cliente = null;

            lwRestricoesAlimentares.Items.Clear();

            countRestr = 0;
            count = 0;

            txtNome.Focus();
        }

        private void CarregaRestricoes(int? clienteId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwRestricoesAlimentares.Items.Clear();

                countRestr = 0;

                var restricoes = db.Restricoes.Where(r => r.ClienteId == clienteId).ToList();

                if (restricoes.Count != 0)
                {
                    foreach (var item in restricoes)
                    {
                        lwRestricoesAlimentares.Items.Add(item.id.ToString());
                        lwRestricoesAlimentares.Items[countRestr].SubItems.Add(item.Descricao);
                        lwRestricoesAlimentares.Items[countRestr].SubItems.Add(item.Produto.Nome);

                        countRestr++;
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                txtRua.Focus();
            }
        }

        private bool ValidaCpfExistente()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {

                var cliente = db.Clientes.Where(c => c.Documento.Equals(txtDocumento.Text)).FirstOrDefault();

                if (cliente != null)
                {
                    MessageBox.Show("Documento ja esta sendo utilizado por um cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDocumento.Focus();
                    txtDocumento.Clear();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool ValidaRGxistente()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var cliente = db.Clientes.Where(c => c.RG.Equals(txtRG.Text)).FirstOrDefault();

                if (cliente != null)
                {
                    MessageBox.Show("RG ja esta sendo utilizado por um cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRG.Focus();
                    txtRG.Clear();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        private bool ValidaCelularExistente()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {

                var cliente = db.Clientes.Where(c => c.Celular.Equals(txtCelular.Text)).FirstOrDefault();

                if (cliente != null)
                {
                    MessageBox.Show("Número celular ja esta sendo utilizado por um cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                    txtCelular.Clear();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            ValidaCpfExistente();
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            ValidaRGxistente();
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            ValidaCelularExistente();
        }

        public void CarregaClienteSelecionado(int clienteId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var cliente = db.Clientes.Where(c => c.ClienteId == clienteId).FirstOrDefault();

                if (cliente != null)
                {
                    this.cliente = cliente;

                    if (cliente.Documento.Length == 14)
                    {
                        rbPessoaFisica.Checked = true;
                        AlterarCamposPessoaFisica();
                    }
                    else
                    {
                        rbPessoaJuridica.Checked = true;
                        AlterarCamposPessoaJuridica();
                    }

                    txtCelular.Text = cliente.Celular;
                    txtDataNascimento.Text = cliente.DataNascimento.ToString();
                    txtDocumento.Text = cliente.Documento;
                    txtEmail.Text = cliente.Email;
                    txtFoneComercial.Text = cliente.TelefoneComercial;
                    txtFoneResidencial.Text = cliente.TelefoneResidencial;
                    txtNome.Text = cliente.Nome;
                    txtRG.Text = cliente.RG;
                    txtSituacao.Text = cliente.Situacao;

                    AlterarCorSituacao(cliente.Situacao);

                    //Carrega restriçoes
                    CarregaRestricoes(clienteId);

                    //Carrega Movimentações do cliente
                    CarregaMovimentacoes(clienteId);

                    //Carrega Endereços
                    CarregaEnderecos(clienteId);

                    var enderecos = db.Enderecos.Where(e => e.ClienteId == clienteId).ToList();

                    if (enderecos.Count > 0)
                    {
                        foreach (var item in enderecos)
                        {
                            if (item.IsEnderecoEntrega == true)
                            {
                                ckIsEndereco.Checked = item.IsEnderecoEntrega;
                                txtRua.Text = item.Rua;
                                txtNumero.Text = item.Numero;
                                txtBairro.Text = item.Bairro;
                                txtComplemento.Text = item.Complemento;
                                txtEntreRuas.Text = item.EntreRua;
                                txtCeP.Text = item.CEP;
                                txtUF.Text = item.UF;
                                txtCidade.Text = item.Cidade;
                            }
                        }
                    }

                    gbEnderecoEntrega.Enabled = false;
                }
            }
        }

        private void CarregaEnderecos(int clienteId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwEnderecos.Items.Clear();

                count = 0;

                var enderecos = db.Enderecos.Where(e => e.ClienteId == clienteId).ToList();

                if (enderecos.Count != 0)
                {
                    foreach (var item in enderecos)
                    {
                        lwEnderecos.Items.Add(item.EnderecoId.ToString());
                        lwEnderecos.Items[count].SubItems.Add(item.IsEnderecoEntrega == true ? "SIM" : "NÃO");
                        lwEnderecos.Items[count].SubItems.Add(item.Rua);
                        lwEnderecos.Items[count].SubItems.Add(item.Numero);
                        lwEnderecos.Items[count].SubItems.Add(item.Bairro);
                        lwEnderecos.Items[count].SubItems.Add(item.Complemento);
                        lwEnderecos.Items[count].SubItems.Add(item.EntreRua);
                        lwEnderecos.Items[count].SubItems.Add(item.CEP);
                        lwEnderecos.Items[count].SubItems.Add(item.UF);
                        lwEnderecos.Items[count].SubItems.Add(item.Cidade);
                        count++;
                    }
                }
            }
        }

        private void CarregaMovimentacoes(int? clienteId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var movimentacoes = db.MovimentacoesCliente.Where(m => m.ClienteId == clienteId).ToList();
                int count = 0;
                decimal credito = 0;
                decimal debito = 0;
                txtTotalCredito.Clear();
                txtTotalDebito.Clear();
                txtSaldoCredito.Clear();

                lwMovimentacoes.Items.Clear();

                if (movimentacoes.Count > 0)
                {
                    foreach (var item in movimentacoes)
                    {
                        lwMovimentacoes.Items.Add(string.Empty);
                        lwMovimentacoes.Items[count].SubItems.Add(item.Id.ToString());
                        lwMovimentacoes.Items[count].SubItems.Add(item.DataHora.ToString("dd/MM/yyyy"));
                        lwMovimentacoes.Items[count].SubItems.Add(item.ValorCredito.ToString("C"));
                        lwMovimentacoes.Items[count].SubItems.Add(string.Empty);
                        lwMovimentacoes.Items[count].SubItems.Add(item.ValorDebito.ToString("C"));
                        lwMovimentacoes.Items[count].SubItems.Add((item.ValorCredito - item.ValorDebito).ToString());

                        credito += item.ValorCredito;
                        debito += item.ValorDebito;
                        count++;
                    }

                    txtTotalCredito.Text = credito.ToString("C");
                    txtTotalDebito.Text = debito.ToString("C");

                    txtSaldoCredito.Text = (credito - debito).ToString("C");
                }
            }
        }

        private void AlterarCorSituacao(string situacao)
        {
            txtSituacao.BackColor = situacao == "ATIVADO" ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
        }

        private void ExcluirCliente()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var cliente = db.Clientes.Where(c => c.ClienteId == this.cliente.ClienteId).FirstOrDefault();

                if (cliente != null)
                {
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }
        }

        private void ExcluirEndereco()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var enderecos = db.Enderecos.Where(e => e.ClienteId == this.cliente.ClienteId).ToList();

                if (enderecos != null)
                {
                    db.Enderecos.RemoveRange(enderecos);
                    db.SaveChanges();
                }
            }
        }


        private void ExcluirRestricoes()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var restricoes = db.Restricoes.Where(e => e.ClienteId == this.cliente.ClienteId).ToList();

                if (restricoes != null)
                {
                    db.Restricoes.RemoveRange(restricoes);
                    db.SaveChanges();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ConsultaClienteIsPedido() == false)
            {
                if (MessageBox.Show("Deseja excluir o cliente selecionado ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluirRestricoes();
                    ExcluirEndereco();
                    ExcluirCliente();

                    MessageBox.Show("Cliente excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cliente esta sendo ultilizado por uma ação no sistema!\nNão pode ser excluido", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private Boolean ConsultaClienteIsPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedido = db.Pedidos.Where(p => p.ClienteId == cliente.ClienteId).ToList();

                if (pedido.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                Salvar();
            }
            else
            {
                Alterar();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSituacao_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AlterarCorSituacao(txtSituacao.Text);
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length <= 42)
            {
                int nomeDigitadoTamanho = Convert.ToInt32(txtNome.Text.Length);

                int limitCharAtual = 42 - nomeDigitadoTamanho;

                lblCharNome.Text = limitCharAtual + " Digíto(s)";
            }
            else
            {
                MessageBox.Show("Nome cliente deve ser igual ou menor que 42 digítos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
        }

        private void btnZerarSaldo_Click(object sender, EventArgs e)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                if (lwMovimentacoes.Items.Count > 0)
                {
                    var movimentacao = db.MovimentacoesCliente.Where(m => m.ClienteId == this.cliente.ClienteId);

                    if (movimentacao != null)
                    {
                        if (MessageBox.Show("Tem certeza que deseja zerar o saldo deste cliente ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.MovimentacoesCliente.RemoveRange(movimentacao);
                            db.SaveChanges();

                            CarregaMovimentacoes(this.cliente.ClienteId);

                            MessageBox.Show("Saldo zerado com sucesso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (lwMovimentacoes.Items.Count == 0)
                        {
                            btnZerarSaldo.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnAdicionarCredito_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                frmAdicionarCredito frm = new frmAdicionarCredito();
                frm.clienteId = cliente.ClienteId;
                frm.ShowDialog();
                CarregaMovimentacoes(cliente.ClienteId);
            }
        }

        private void txtCeP_Leave(object sender, EventArgs e)
        {
            try
            {
                Thread t = new Thread(Util.ExibeLoadCep);
                t.Start();

                var ws = new WSCorreios.AtendeClienteClient();

                var resposta = ws.consultaCEP(txtCeP.Text);

                if (resposta != null)
                {
                    txtRua.Text = resposta.end;
                    txtComplemento.Text = resposta.complemento;
                    txtBairro.Text = resposta.bairro;
                    txtCidade.Text = resposta.cidade;
                    txtUF.Text = resposta.uf;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar busca: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lwRestricoesAlimentares.Items.Count > 0)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    int codigo = Convert.ToInt32(lwRestricoesAlimentares.FocusedItem.SubItems[0].Text);

                    var restricao = db.Restricoes.Find(codigo);

                    if (restricao != null)
                    {
                        if (MessageBox.Show("Deseja excluir a restrição alimentar abaixo ? \n\n" + restricao.Produto.Nome + "\n" + restricao.Descricao, "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Restricoes.Remove(restricao);
                            db.SaveChanges();

                            MessageBox.Show("Operação realizada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregaRestricoes(cliente.ClienteId);

                        }
                    }
                }
            }
        }

        private void btnRestricao_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                frmAddRestricoesAlimentares frm = new frmAddRestricoesAlimentares();
                frm.SelecionarRestricaoPorClienteId(cliente.ClienteId);
                frm.ShowDialog();
                CarregaRestricoes(cliente.ClienteId);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lwEnderecos.Items.Count > 0)
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    int codigo = Convert.ToInt32(lwEnderecos.FocusedItem.SubItems[0].Text);

                    var endereco = db.Enderecos.Find(codigo);

                    if (endereco != null)
                    {
                        if (MessageBox.Show("Deseja excluir o endereço abaixo ? \n\n" + "Rua: " + endereco.Rua + "\nNúmero: " + endereco.Numero + "\nBairro: " + endereco.Bairro, "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Enderecos.Remove(endereco);
                            db.SaveChanges();

                            MessageBox.Show("Operação realizada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregaEnderecos(cliente.ClienteId);
                            CarregaClienteSelecionado(cliente.ClienteId);

                        }
                    }
                }
            }
        }

        private void lwEnderecos_DoubleClick(object sender, EventArgs e)
        {
            if (lwEnderecos.Items.Count > 0)
            {
                int codigo = Convert.ToInt32(lwEnderecos.FocusedItem.SubItems[0].Text);

                frmAddEnderco frm = new frmAddEnderco();
                frm.SelecionarEnderecoPorEnderecoId(codigo);
                frm.ShowDialog();
                CarregaEnderecos(cliente.ClienteId);
                CarregaClienteSelecionado(cliente.ClienteId);
            }
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                frmAddEnderco frm = new frmAddEnderco();
                frm.SelecionarClienteId(cliente.ClienteId);
                frm.ShowDialog();
                CarregaEnderecos(cliente.ClienteId);
                CarregaClienteSelecionado(cliente.ClienteId);
            }
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            AlterarCamposPessoaFisica();
        }

        private void AlterarCamposPessoaFisica()
        {
            lblCliente.Text = "Nome completo:";
            lblDocument.Text = "Documento:";
            txtDocumento.Mask = "999,999,999-99";
            txtRG.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtRG.Enabled = true;
            txtNome.Focus();
        }

        private void AlterarCamposPessoaJuridica()
        {
            lblCliente.Text = "Razão Social:";
            lblDocument.Text = "CNPJ:";
            txtDocumento.Mask = "99,999,999/9999-99";
            txtRG.Clear();
            txtDataNascimento.Enabled = false;
            txtRG.Enabled = false;
            txtNome.Focus();
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            AlterarCamposPessoaJuridica();
        }
    }
}

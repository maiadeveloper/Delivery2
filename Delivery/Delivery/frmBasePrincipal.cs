using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBasePrincipal : Form
    {
        private Thread thread;
        MyDataContextConfiguration db;
        Operador operador = new Operador();
        bool validarSistema = true;

        public frmBasePrincipal(frmAutenticarUser frmUser)
        {
            InitializeComponent();

            foreach (ToolStripItem item in toolStripBarraMenus.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }

            operador = frmUser.operador;
            toolStripStatusUser.Text = string.Format("Usuário logado: {0}", frmUser.operador.Nome.ToString());

            frmBoasVindas frm = new frmBoasVindas(operador);
            frmAutenticarUser frmAutenticado = new frmAutenticarUser();

            frm.ShowDialog();
        }

        private void toolStripBtnSairSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBasePrincipal_Load(object sender, EventArgs e)
        {
            db = new MyDataContextConfiguration();

            CarregaLembrentesAniversariantes();

            ExibeMensagemAlertaVencimentoSistema();

            //RegistrarBuild();
            tsBuild.Text = tsBuild.Text + " - " + Util.CarregaBuildSistema();

            CarregaDadosEmpresa();

            ExibiLembreContasaPagar();
        }

        private void CarregaLembrentesAniversariantes()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                int diaAtual = DateTime.Now.Day;
                int mesAtual = DateTime.Now.Month;
    

                var clientes = db.Clientes.Where(c => c.DataNascimento.Value.Month == mesAtual && 
                c.DataNascimento.Value.Day == diaAtual && c.DataNascimento.Value.Year != 1).ToList();

                int contAniver = 0;
                listViewAniversariantes.Items.Clear();

                if (clientes.Count > 0)
                {
                    painelAniversariantes.Visible = true;
                    pNelTituloNiver.Visible = true;

                    foreach (var item in clientes)
                    {
                        listViewAniversariantes.Items.Add(item.Nome);
                        listViewAniversariantes.Items[contAniver].SubItems.Add(item.Celular);
                        contAniver++;
                    }
                }
                else
                {
                    painelAniversariantes.Visible = false;
                    pNelTituloNiver.Visible = false;
                }
   
            }
        }

        private void ExibeMensagemAlertaVencimentoSistema()
        {
            DateTime dataAtual = DateTime.Now;
            int dia = dataAtual.Day;
            string mensagem = string.Empty;

            if (Util.ValidarSistema() == false)
            {
                if (dia <= 10)
                {
                    lblMensagemSistema.ForeColor = System.Drawing.Color.DarkOrange;
                    dia = 10 - dia;
                    dfdfToolStripMenuItem.Visible = true;

                    if (dia == 10)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 9)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 8)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 7)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 6)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 5)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 4)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 3)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 2)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dias para expirar o uso do sistema.";
                    }
                    else if (dia == 1)
                    {
                        mensagem = "Atenção! \n\nFaltam apenas " + dia + " dia para expirar o uso do sistema.";
                    }
                    else if (dia == 0)
                    {
                        mensagem = "Atenção!          Os  10 dias  de  aviso  terminaram. \n                       O uso do sistema será interrompido.\n\nFavor, entrar em contato com o administrador do \nsistema e  solicitar uma   nova  chave  de  acesso.";
                    }
                }
                else
                {
                    validarSistema = Util.ValidarSistema();
                    lblMensagemSistema.ForeColor = System.Drawing.Color.DarkRed;
                    pictureBox2.Visible = true;
                    mensagem = "Atenção!        O  sistema  encontra-se   expirado. \n\nFavor, entrar em contato com o administrador do \nsistema e  solicitar  uma  nova  chave  de  acesso.";
                    toolStripBarraMenus.Enabled = false;
                }

                pMensagemSistema.Visible = true;
                paneLembreteSistema.Visible = true;
                lblMensagemSistema.Text = mensagem;
            }
            else
            {
                dfdfToolStripMenuItem.Visible = false;
            }
        }

        //Método usado para registrar a versão do software de acordo com cada compilação
        private void RegistrarBuild()
        {
            var getBuilSistema = (from s in db.Sistemas.OrderByDescending(s => s.SistemaId) select s.SistemaId).FirstOrDefault();

            var sistema = new Sistema()
            {
                DataBuild = DateTime.Now,
                VersaoBuild = string.Format("1.{0}", getBuilSistema.ToString() == null ? "1.0" : getBuilSistema.ToString())
            };

            db.Sistemas.Add(sistema);
            db.SaveChanges();
        }

        private void CarregaDadosEmpresa()
        {
            var empresa = db.Empresas.OrderByDescending(e => e.EmpresaId).FirstOrDefault();

            if (empresa != null)
            {
                tsRegistradoEmpresa.Text = string.Format("| Registrado para: {0} - CNPJ: {1}", empresa.Fantasia, empresa.CNPJ);
            }
        }

        private void tsNovoCliente_Click(object sender, EventArgs e)
        {
            frmTodosClientes frm = new frmTodosClientes();
            frm.ShowDialog();
        }

        private void tsNovoProduto_Click(object sender, EventArgs e)
        {

            frmTodosProdutos frm = new frmTodosProdutos();
            frm.ShowDialog();
        }

        private void frmBasePrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirma saida do Sistema ? ", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                if (db.ConfiguracoesSistema.FirstOrDefault().IsBackup == true)
                {
                    thread = new Thread(() =>
                    {
                        //Código que será executado em paralelo ao resto do código
                        Util.RealizarBackup();
                    });
 
                    //Inicia a execução da thread (em paralelo a esse código)
                    thread.Start();
                }
            }
        }

        private void toolsPedido_Click(object sender, EventArgs e)
        {
            frmTodosPedidos frm = new frmTodosPedidos(operador);
            frm.operador = operador;
            frm.ShowDialog();
        }

        private void tsFuncionarios_Click(object sender, EventArgs e)
        {
            frmTodosFuncionarios frm = new frmTodosFuncionarios();
            frm.ShowDialog();
        }

        private void tsEtiquetasPedidos_Click(object sender, EventArgs e)
        {
            frmTodosItensPedidos frm = new frmTodosItensPedidos();
            frm.ShowDialog();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroRelatorioMovimentacao frm = new frmFiltroRelatorioMovimentacao();
            frm.ShowDialog();
        }

        private void vendasGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroRelatorio frm = new frmFiltroRelatorio();
            frm.ShowDialog();
        }

        private void sangriaRetiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodasSangria frm = new frmBaseTodasSangria();
            frm.ShowDialog();
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacaoCaixaAbertoFechado frm = new frmRelacaoCaixaAbertoFechado();
            frm.ShowDialog();
        }

        private void vendasEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroPedidoClienteAbertoFechado frm = new frmFiltroPedidoClienteAbertoFechado();
            frm.ShowDialog();
        }

        private void frmBasePrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (validarSistema != false)
            {
                if (e.KeyCode == Keys.F2)
                {
                    frmTodosProdutos frm = new frmTodosProdutos();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F3)
                {
                    frmTodosClientes frm = new frmTodosClientes();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F4)
                {
                    frmTodosFuncionarios frm = new frmTodosFuncionarios();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F5)
                {
                    frmTodosPedidos frm = new frmTodosPedidos(operador);
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F6)
                {
                    frmTodosItensPedidos frm = new frmTodosItensPedidos();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F7)
                {
                    frmTodosLancamentos frm = new frmTodosLancamentos(operador);
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F8)
                {
                    frmPedidoPcte frm = new frmPedidoPcte(operador);
                    frm.ShowDialog();
                }
            }
        }

        private void tsAlterarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenhaUser frm = new frmAlterarSenhaUser(operador);
            frm.ShowDialog();
        }

        private void tsSuporteSobre_Click(object sender, EventArgs e)
        {
            frmSuporteTecnico frm = new frmSuporteTecnico();
            frm.ShowDialog();
        }

        private void tsLancamenos_Click(object sender, EventArgs e)
        {
            frmTodosLancamentos frm = new frmTodosLancamentos(operador);
            frm.ShowDialog();
        }

        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria uma nova thread, indicando qual método essa thread deverá executar
            thread = new Thread(() =>
            {
                //Código que será executado em paralelo ao resto do código
                Util.RealizarBackup();
            });

            thread.Start();
        }

        private void subclasseLançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTodasSubClassesLancamento frm = new frmTodasSubClassesLancamento();
            frm.ShowDialog();
        }

        private void classeLancamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTodasClassesLancamento frm = new frmTodasClassesLancamento();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTodosFornecedores frm = new frmTodosFornecedores();
            frm.ShowDialog();
        }

        private void ExibiLembreContasaPagar()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var lancamentos = db.Lancamentos.Where(l => l.Situacao.Equals("não pago")).ToList();

                if (lancamentos.Count > 0)
                {
                    foreach (var item in lancamentos)
                    {
                        if ((DiasAtraso(item.DataVencimento) <= 5) || (DateTime.Now >= item.DataVencimento))
                        {
                            frmLembrentesLancamentos frm = new frmLembrentesLancamentos();
                            frm.ShowDialog();
                            break;
                        }
                    }
                }
            }
        }

        public int DiasAtraso(DateTime dataVencimeto)
        {
            TimeSpan intervalo = DateTime.Now.Subtract(dataVencimeto);
            return -intervalo.Days;
        }

        private void tsFornecedor_Click(object sender, EventArgs e)
        {
            frmTodosFornecedores frm = new frmTodosFornecedores();
            frm.ShowDialog();
        }


        private void clientesComCréditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseRelatorioMovimentacaoCliente frm = new frmBaseRelatorioMovimentacaoCliente();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmConsultarClientesSaldo frm = new frmConsultarClientesSaldo();
            frm.ShowDialog();
        }

        private void toolStripBtnConfiguracoes_Click(object sender, EventArgs e)
        {
            frmConfiguracoesGerais frm = new frmConfiguracoesGerais();
            frm.ShowDialog();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco frm = new frmBanco();
            frm.ShowDialog();
        }

        private void contaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContaCorrente frm = new frmContaCorrente();
            frm.ShowDialog();
        }

        private void movimentaçaoEntradaSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoEntradaSaida frm = new frmMovimentacaoEntradaSaida();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPedidoPcte frm = new frmPedidoPcte(operador);
            frm.ShowDialog();
        }

        private void dfdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidarLicencaSistema frm = new frmValidarLicencaSistema();
            frm.ShowDialog();
        }

        private void toolFluxoCaixa_Click(object sender, EventArgs e)
        {
            frmBaseMovimentacaoGeral frm = new frmBaseMovimentacaoGeral();
            frm.ShowDialog();
        }

        private void restriçõesAlimentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRestricoesAlimentares frm = new frmAddRestricoesAlimentares();
            frm.ShowDialog();
            CarregaLembrentesAniversariantes();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEnderco frm = new frmAddEnderco();
            frm.ShowDialog();
            CarregaLembrentesAniversariantes();
        }

        private void pcBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aniversáriantesDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelAniversariantes.Visible = true;
            pNelTituloNiver.Visible = true;
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            painelAniversariantes.Visible = false;
            pNelTituloNiver.Visible = false;
        }

        private void pcBoxFechar_MouseHover_1(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pcBoxFechar_MouseLeave_1(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void pcBoxFecharLembrete(object sender, EventArgs e)
        {
            pMensagemSistema.Visible = false;
            paneLembreteSistema.Visible = false;
        }

        private void pictureBox4FEcharLembrente_MouseHover(object sender, EventArgs e)
        {
            pictureBox4FEcharLembrente.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pictureBox4FEcharLembrente_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4FEcharLembrente.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void exportarDadosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportarDadosCliente frm = new frmExportarDadosCliente();
            frm.ShowDialog();
        }

        private void lançamentosContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmPedidoPcte : Form
    {
        public frmPedidoPcte(Operador operador)
        {
            InitializeComponent();
            this.operador = operador;
        }

        private Thread thread;

        public Operador operador = new Operador();

        decimal valorTotal;

        int indexPosItem = 0;

        int qtdeItensGeral;
        int count = 0;
        int codigoProduto;

        bool btnSegundaIsAtivo = true;
        bool btnTercaIsAtivo = true;
        bool btnQuartaIsAtivo = true;
        bool btnQuintaIsAtivo = true;
        bool btnSextaIsAtivo = true;
        bool btnSabadoIsAtivo = false;
        bool btnDomingoIsAtivo = false;
        bool qtdeFocus = false;
        bool isFocusPrecoUnitario = false;

        decimal totalPagar;
        int? codigoPedido = null;
        int? codigoCliente = null;
        int? codigoFormaPgto = null;
        decimal? valorDesconto = null;
        decimal? valorTotalFinal = null;
        decimal? valorTaxaEntre = null;
        decimal? valorTroco = null;
        decimal? valorPagamento = null;
        string situacao = "não pago";
        bool editar = false;
        bool isCancelar = false;
        bool isFinalizado = false;
        bool isCredito = false;
        Produto produtoConsulta = new Produto();
        Produto produto = new Produto();


        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        private void AlterarCorBotoesSemana()
        {
            btnSegundaFeira.BackColor = System.Drawing.Color.LimeGreen;
            btnTerca.BackColor = System.Drawing.Color.LimeGreen;
            btnQuarta.BackColor = System.Drawing.Color.LimeGreen;
            btnQuinta.BackColor = System.Drawing.Color.LimeGreen;
            btnSexta.BackColor = System.Drawing.Color.LimeGreen;
            btnSabado.BackColor = System.Drawing.Color.OrangeRed;
            btnDomingo.BackColor = System.Drawing.Color.OrangeRed;
        }

        private void frmPedidoPcte_Load(object sender, EventArgs e)
        {
            AlterarCorBotoesSemana();

            if (codigoPedido == null)
            {
                IniciaNovoPedido();
            }
        }

        private void CarregaComboFuncionarioEntregador()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var funcionarios = db.Funcionarios.Where(f => f.Funcao.Nome.Equals("ENTREGADOR")).ToList(); ;
                var formaPgtos = db.FormaPagamentos.ToList();

                if (funcionarios.Count > 0)
                {
                    txtFuncionarioEntregador.DataSource = funcionarios.ToList();
                    txtFuncionarioEntregador.ValueMember = "FuncionarioId";
                    txtFuncionarioEntregador.DisplayMember = "Nome";
                    txtFuncionarioEntregador.SelectedIndex = 0;
                }
            }
        }

        private void IniciaNovoPedido()
        {
            GetUltimoPedido();
            CarregaComboFuncionarioEntregador();
            txtDataPacote.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtProduto.Clear();
            txtTipoPacote.Text = "Selecionar...";
            txtTipoPacote.Focus();
            txtQtde.Clear();
            txtCelular.Clear();
            txtNomeCliente.Clear();
            txtCodigo.Clear();
            txtQtdeTotalItens.Clear();
            txtQtdeItem.Clear();
            txtValorUnitProduto.Clear();
            txtTotalPacote.Clear();
            produtoConsulta = new Produto();

            btnSegundaIsAtivo = true;
            btnTercaIsAtivo = true;
            btnQuartaIsAtivo = true;
            btnQuintaIsAtivo = true;
            btnIncluirProduto.Enabled = false;
            btnPesquisarCliente.Enabled = false;
            btnPesquisarProduto.Enabled = false;
            btnSextaIsAtivo = true;
            btnSabadoIsAtivo = false;
            qtdeFocus = false;
            btnDomingoIsAtivo = false;
            AlterarCorBotoesSemana();
            btnFinalizarPedido.Enabled = false;
            txtDataInicioEntrega.Text = DateTime.Now.ToLongDateString();
            count = 0;
        }

        protected string AdicionaZero(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }

        private void GetUltimoPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedido = db.Pedidos.OrderByDescending(p => p.PedidoId).FirstOrDefault();

                if (pedido == null)
                {
                    txtNumeroPedido.Text = AdicionaZero("1");
                    codigoPedido = 1;
                }
                else
                {
                    codigoPedido = pedido.PedidoId + 1;
                    txtNumeroPedido.Text = AdicionaZero(codigoPedido.ToString());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            FinalizarPedido();
        }

        private string RetornaDiasEntrega()
        {
            StringBuilder diasEntrega = new StringBuilder();

            //Domingo
            if (btnDomingoIsAtivo == true)
            {
                diasEntrega.Append("domingo");
                diasEntrega.Append(",");
            }

            //Segunda
            if (btnSegundaIsAtivo == true)
            {
                diasEntrega.Append("segunda");
                diasEntrega.Append(",");
            }

            //Terça
            if (btnTercaIsAtivo == true)
            {
                diasEntrega.Append("terça");
                diasEntrega.Append(",");
            }

            //Quarta
            if (btnQuartaIsAtivo == true)
            {
                diasEntrega.Append("quarta");
                diasEntrega.Append(",");
            }

            //Quinta
            if (btnQuintaIsAtivo == true)
            {
                diasEntrega.Append("quinta");
                diasEntrega.Append(",");
            }

            //Sexta
            if (btnSextaIsAtivo == true)
            {
                diasEntrega.Append("sexta");
                diasEntrega.Append(",");
            }

            //Sabado
            if (btnSabadoIsAtivo == true)
            {
                diasEntrega.Append("sabado");
                diasEntrega.Append(",");
            }

            return diasEntrega.ToString();
        }

        private void FinalizarPedido()
        {
            try
            {
                if (codigoCliente == null)
                {
                    MessageBox.Show("Campo obrigatório! informe o nome do cliente.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (lwItensPedido.Items.Count == 0)
                {
                    MessageBox.Show("Para finalizar este pedido é necessario incluir ao menos um item a ao pedido.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Focus();
                    return;
                }

                if (txtFuncionarioEntregador.Text.Equals("Selecione..."))
                {
                    MessageBox.Show("Selecione o entregador por gentileza", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFuncionarioEntregador.Focus();
                    return;
                }

                pPrincipal.Visible = false;
                panel2.Visible = false;

                frmFinalizarPedido frm = new frmFinalizarPedido();

                totalPagar = Convert.ToDecimal(txtTotalPacote.Text.Substring(2));

                frm.CarregaDadosPedido(codigoPedido, totalPagar, codigoCliente, Convert.ToDateTime(txtDataPacote.Text), true, Convert.ToInt32(txtFuncionarioEntregador.SelectedValue));

                frm.ShowDialog();

                codigoFormaPgto = frm.returnCodFormaPgto;
                situacao = frm.situacao;
                isCancelar = frm.isCancel;
                valorTaxaEntre = frm.returnTaxaEntrega;
                valorTotalFinal = frm.returnTotalFinal;
                valorTroco = frm.returnTroco;
                isFinalizado = frm.isFinalizado;
                valorPagamento = frm.returnPagando;
                isCredito = frm.isCredito;
                valorDesconto = frm.returnDesconto;

                pPrincipal.Visible = true;
                panel2.Visible = true;

                if (editar == false)
                {
                    if (frm.isCancel != true)
                    {
                        SalvarPedido();
                    }
                }
                else
                {
                    if (frm.isCancel != true)
                    {
                        AlterarPedido();
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " Esta operação será finalizada\n Tente novamente em instantes.", "Erro causado pelo usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SalvarPedido()
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = new Pedido();

                    pedido.ClienteId = codigoCliente;
                    pedido.Hora = DateTime.Now.ToString("HH:mm:ss");
                    pedido.Data = Convert.ToDateTime(txtDataPacote.Text);
                    pedido.FormaPagamentoId = codigoFormaPgto;
                    pedido.FuncionarioId = Convert.ToInt32(txtFuncionarioEntregador.SelectedValue);
                    pedido.OperadorId = operador.OperadorId;
                    pedido.Situacao = situacao;
                    pedido.TaxaEntrega = valorTaxaEntre;
                    pedido.TipoPedido = codigoCliente == null ? "Pedido balcão" : "Pedido entrega";
                    pedido.VlrDesconto = valorDesconto;
                    pedido.VlrTotal = totalPagar;
                    pedido.VlrTotalFinal = valorTotalFinal;
                    pedido.IsExcluir = false;
                    pedido.IsPcte = true;
                    pedido.DataHoraInicio = Convert.ToDateTime(txtDataInicioEntrega.Text);
                    pedido.DiasEntrega = RetornaDiasEntrega();

                    if (situacao.Equals("pago"))
                    {
                        pedido.DataHoraPgto = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    }

                    if (isFinalizado == false)
                    {
                        if (MessageBox.Show("Deseja salvar este pedido ?", "Confirmação para salvar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Pedidos.Add(pedido);
                            db.SaveChanges();

                            SalvaItemsPedido();

                            MessageBox.Show("Pedido salvo com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        db.Pedidos.Add(pedido);
                        db.SaveChanges();

                        SalvaItemsPedido();

                        MessageBox.Show("Pedido finalizado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Util.GerarArquivoTxtComprovanteVenda("pacote", codigoPedido, codigoCliente, valorPagamento, valorTroco);

                        ImprimirComprovanteVenda();

                        ////Cria uma nova thread, indicando qual método essa thread deverá executar
                        thread = new Thread(() =>
                        {
                            //Código que será executado em paralelo ao resto do código

                            Util.AtualizarItensPedidosPcte(codigoPedido);//Atualiza pacote no ato da finalização
                        });

                        //Inicia a execução da thread (em paralelo a esse código)
                        thread.Start();
                    }

                    LimparCampos();

                    if (MessageBox.Show("Deseja iniciar um novo pedido ?", "Sistema pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IniciaNovoPedido();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " - Esta operação será finalizada\n tente novamente.", "Erro causado pelo usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AlterarPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedido = db.Pedidos.Find(codigoPedido);

                pedido.ClienteId = codigoCliente;
                pedido.ClienteId = codigoCliente;
                pedido.Hora = DateTime.Now.ToString("HH:mm:ss");
                pedido.Data = Convert.ToDateTime(txtDataPacote.Text);
                pedido.FormaPagamentoId = codigoFormaPgto;
                pedido.FuncionarioId = Convert.ToInt32(txtFuncionarioEntregador.SelectedValue);
                pedido.OperadorId = operador.OperadorId;
                pedido.Situacao = situacao;
                pedido.TaxaEntrega = valorTaxaEntre;
                pedido.TipoPedido = codigoCliente == null ? "Pedido balcão" : "Pedido entrega";
                pedido.VlrDesconto = valorDesconto;
                pedido.VlrTotal = totalPagar;
                pedido.VlrTotalFinal = valorTotalFinal;
                pedido.IsExcluir = false;
                pedido.IsPcte = true;
                pedido.DataHoraInicio = Convert.ToDateTime(txtDataInicioEntrega.Text);
                pedido.DiasEntrega = RetornaDiasEntrega();
                btnFinalizarPedido.Enabled = true;

                if (situacao.Equals("pago"))
                {
                    pedido.DataHoraPgto = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                }

                if (isFinalizado == false)
                {
                    if (MessageBox.Show("Deseja salvar alteração a este pedido ?", "Confirmação para salvar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.SaveChanges();
                        SalvaItemsPedido();
                        MessageBox.Show("Alterações realizada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    db.SaveChanges();

                    SalvaItemsPedido();

                    MessageBox.Show("Pedido finalizado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Util.GerarArquivoTxtComprovanteVenda("pacote", codigoPedido, codigoCliente, valorPagamento, valorTroco);

                    ImprimirComprovanteVenda();

                    //Cria uma nova thread, indicando qual método essa thread deverá executar
                    thread = new Thread(() =>
                    {
                        //Código que será executado em paralelo ao resto do código
                        Util.AtualizarItensPedidosPcte(codigoPedido);//Atualiza pacote no ato da finalização
                    });

                    //Inicia a execução da thread (em paralelo a esse código)
                    thread.Start();
                }

                LimparCampos();

                if (MessageBox.Show("Deseja iniciar um novo pedido ?", "Sistema pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IniciaNovoPedido();
                }
                else
                {
                    this.Close();
                }


                if (MessageBox.Show("Deseja iniciar um novo pedido ?", "Sistema pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IniciaNovoPedido();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void SalvaItemsPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                int countItem = 1;

                for (int i = 0; i < lwItensPedido.Items.Count; i++)
                {
                    for (int j = 0; j < int.Parse(lwItensPedido.Items[i].SubItems[3].Text); j++)
                    {
                        ItensPedido itensPedido = new ItensPedido();

                        itensPedido.Item = countItem;
                        itensPedido.PedidoId = codigoPedido;
                        itensPedido.ProdutoId = int.Parse(lwItensPedido.Items[i].SubItems[0].Text);
                        itensPedido.VlrUnitario = decimal.Parse(lwItensPedido.Items[i].SubItems[2].Text.Substring(2));
                        itensPedido.SubTotal = decimal.Parse(lwItensPedido.Items[i].SubItems[2].Text.Substring(2));
                        itensPedido.Qtde = 1;
                        itensPedido.DataConsumo = null;
                        itensPedido.IsConsumo = false;
                        itensPedido.IsPctItem = true;
                        itensPedido.IsChecked = false;

                        db.ItensPedidos.Add(itensPedido);
                        db.SaveChanges();

                        countItem++;
                    }
                }
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            pPrincipal.Visible = false;

            frmTodosClientes frm = new frmTodosClientes();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.cliente != null)
            {
                txtCPF.Text = frm.cliente.Documento;
                txtNomeCliente.Text = frm.cliente.Nome;
                txtCelular.Text = frm.cliente.Celular;
                txtCodigo.Text = frm.cliente.ClienteId.ToString();
                codigoCliente = frm.cliente.ClienteId;
            }
        }

        private void LimparCampos()
        {
            txtCPF.Clear();
            txtNomeCliente.Clear();
            txtNumeroPedido.Clear();
            codigoCliente = null;
            codigoFormaPgto = null;
            valorDesconto = null;
            valorTaxaEntre = null;
            valorTotalFinal = null;
            totalPagar = 0;
            editar = false;
            isCancelar = false;
            isFinalizado = false;
            situacao = "Aberto";
            txtValorUnitProduto.Clear();
            txtQtde.Clear();
            lwItensPedido.Items.Clear();
            txtTipoPacote.Focus();
            txtNomeCliente.Clear();
            indexPosItem = 0;
        }

        private void frmPedidoPcte_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)//Cancelar operação
                {
                    this.Close();
                }
                else if (e.KeyCode == Keys.F2)//Pesquisar produto
                {
                    btnPesquisarProduto_Click(this, e);
                }
                else if (e.KeyCode == Keys.F3)//Pesquiser cliente
                {
                    btnPesquisarCliente_Click(this, e);
                }
                else if (e.KeyCode == Keys.F5)//Finalizar pacote
                {
                    FinalizarPedido();
                }
                else if (e.KeyCode == Keys.F8)
                {
                    btnAplicarDesconto_Click(this, e);
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (isFocusPrecoUnitario == true)
                    {
                        txtQtde.Focus();
                    }
                    if (qtdeFocus == true)
                    {
                        if (!string.IsNullOrEmpty(txtQtde.Text) && txtQtde.Text != "0")
                        {
                            txtSubtotal.Text = (Convert.ToDecimal(txtValorUnitProduto.Text.Substring(2)) * Convert.ToInt32(txtQtde.Text)).ToString("C");
                            btnIncluirProduto.Focus();
                            qtdeFocus = false;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " \nFalha durante a operãção\n tente novamente.", "Erro causado pelo usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GerarArquivoTxtComprovanteVenda()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                //Carrega dados da empresa
                var empresa = db.Empresas.OrderByDescending(e => e.EmpresaId).FirstOrDefault();

                //Carrega dados do pedido
                var pedido = db.Pedidos.Find(codigoPedido);

                if (empresa != null)
                {

                    var cliente = db.Clientes.Where(c => c.ClienteId == pedido.ClienteId).FirstOrDefault();

                    string nomeCliente = codigoCliente == null ? "VENDA AVULSA" : cliente.Nome;

                    string nomeEntregador = codigoCliente == null ? string.Empty : pedido.Funcionario.Nome;
                    string lblCreditoTroco = isCredito != true ? "TROCO" : "CRÉDITO";

                    DateTime data = DateTime.Now;

                    //cria o arquivo txt para um determinado diretorio
                    FileInfo arquivo = new FileInfo(Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt");

                    using (FileStream fs = arquivo.Create()) { }

                    //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
                    string[] texto = {
                                 "                        COMPROVANTE DE VENDA PACOTE                       ",
                                 "============================================",
                                  "" + empresa.Razao,
                                  "" +"CNPJ: " + empresa.CNPJ,
                                 "============================================",
                                 "Data: " + data.ToString() +        "          Número pedido: " + txtNumeroPedido.Text,
                                 "Tipo de Pacote: " + txtTipoPacote.Text,
                                 "",
                                 "Cliente: " + nomeCliente,
                                 "============================================",
                                 "Entregador: " + nomeEntregador                                +"",
                                 "============================================",
                                 "============================================",
                                 "[Cod]  [Produto]                            [Qtde]    [Preço Unit]    [Total]",
                                 "============================================",
                                 IncluirItens(),
                                 "VALOR TOTAL PRODUTO(S)..: R$                                                 " + Convert.ToDecimal(pedido.VlrTotalFinal).ToString("N2"),
                                 "                                                                                 ======",
                                 "TOTAL A PAGAR..: R$                                                              " + Convert.ToDecimal(pedido.VlrTotalFinal).ToString("N2"),
                                 "DESCONTO......: R$                                                           - " + Convert.ToDecimal(pedido.VlrDesconto).ToString("N2"),
                                 "                                                                                 ======",
                                 "PAGANDO...: R$  " + "                                                                     " + Convert.ToDecimal(valorPagamento).ToString("N2"),
                                 ""+ lblCreditoTroco + ": R$ " + "                                                                         " + Convert.ToDecimal(valorTroco).ToString("N2"),
                                 "============================================",
                                 "FORMA PAGAMENTO: " + pedido.FormaPagamento.Nome.ToString() +"              ",

                                 "============================================",
                                 "Porto Velho - Ro: " + data.ToString(),
                                "============================================",
                             };

                    //Escreve as informações no arquivo txt, salvo no diretorio expecificado
                    File.WriteAllLines(Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt", texto);
                }
            }
        }

        public string IncluirItens()
        {
            StringBuilder sb = new StringBuilder();

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                string cod, produto, qtde, preco, total;

                for (int i = 0; i < lwItensPedido.Items.Count; i++)
                {
                    cod = lwItensPedido.Items[i].SubItems[0].Text;
                    produto = lwItensPedido.Items[i].SubItems[1].Text;
                    preco = lwItensPedido.Items[i].SubItems[2].Text;
                    qtde = lwItensPedido.Items[i].SubItems[3].Text;
                    total = lwItensPedido.Items[i].SubItems[4].Text;

                    sb.AppendLine(" " + cod + "    " + produto + "                            " + qtde + "         " + preco + "          " + total);
                }
            }
            return sb.ToString();
        }

        public void ImprimirComprovanteVenda()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                if (db.ConfiguracoesSistema.FirstOrDefault().IsImprimirEtiqueta != false)
                {
                    //Carrega dados da empresa
                    var empresa = db.Empresas.OrderByDescending(e => e.EmpresaId).FirstOrDefault();

                    if (empresa != null)
                    {
                        int copia = 1;

                        if (empresa.ConfirmaImpressao == true)
                        {
                            if (MessageBox.Show("Deseja imprimir comprovante da venda: " + AdicionaZero(codigoPedido.ToString()) + "", "Confirmação recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                while (copia <= empresa.QtdeImpressao)
                                {
                                    string path = Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt";
                                    frmPedido.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);

                                    copia++;
                                }
                            }
                        }
                        else
                        {
                            while (copia <= empresa.QtdeImpressao)
                            {
                                string path = Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt";
                                frmPedido.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);

                                copia++;
                            }
                        }
                    }
                }
            }
        }

        private void btnSegundaFeira_Click(object sender, EventArgs e)
        {
            if (btnSegundaIsAtivo == true)
            {
                btnSegundaIsAtivo = false;
                btnSegundaFeira.BackColor = System.Drawing.Color.OrangeRed;

            }
            else
            {
                btnSegundaIsAtivo = true;
                btnSegundaFeira.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void btnTerca_Click(object sender, EventArgs e)
        {
            if (btnTercaIsAtivo == true)
            {
                btnTercaIsAtivo = false;
                btnTerca.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                btnTercaIsAtivo = true;
                btnTerca.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void btnQuarta_Click(object sender, EventArgs e)
        {
            if (btnQuartaIsAtivo == true)
            {
                btnQuartaIsAtivo = false;
                btnQuarta.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                btnQuartaIsAtivo = true;
                btnQuarta.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void btnQuinta_Click(object sender, EventArgs e)
        {
            if (btnQuintaIsAtivo == true)
            {
                btnQuintaIsAtivo = false;
                btnQuinta.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                btnQuintaIsAtivo = true;
                btnQuinta.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void btnSexta_Click(object sender, EventArgs e)
        {
            if (btnSextaIsAtivo == true)
            {
                btnSextaIsAtivo = false;
                btnSexta.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                btnSextaIsAtivo = true;
                btnSexta.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            if (btnSabadoIsAtivo == true)
            {
                btnSabadoIsAtivo = false;
                btnSabado.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                btnSabadoIsAtivo = true;
                btnSabado.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void btnDomingo_Click(object sender, EventArgs e)
        {
            if (btnDomingoIsAtivo == true)
            {
                btnDomingoIsAtivo = false;
                btnDomingo.BackColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                btnDomingoIsAtivo = true;
                btnDomingo.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void txtDataInicioEntrega_Leave(object sender, EventArgs e)
        {
            DateTime dataInicioEntrega = Convert.ToDateTime(txtDataInicioEntrega.Text);

            if (Convert.ToDateTime(dataInicioEntrega.ToString("dd/MM/yyyy")) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                MessageBox.Show("Data para inicio da entrega não pode ser retroativa a data atual do pedido", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDataInicioEntrega.Focus();
            }
        }

        private void txtValorUnitProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotalPacote.Text = (Convert.ToDecimal(txtValorUnitProduto.Text.Substring(2)) * Convert.ToInt32(txtQtde.Text)).ToString("C");
            }
            catch (Exception error) { }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void BuscarProduto()
        {
            if (txtTipoPacote.SelectedIndex != 0)
            {
                pPrincipal.Visible = false;

                frmTodosProdutos frm = new frmTodosProdutos();
                frm.ShowDialog();

                pPrincipal.Visible = true;

                if (frm.produto != null)
                {
                    txtCodigoBarra.Text = frm.produto.CodigoBarra;
                    txtProduto.Text = frm.produto.Nome;
                    codigoProduto = frm.produto.ProdutoId;
                    txtQtde.Focus();
                    btnAplicarDesconto.Enabled = true;

                    switch (txtTipoPacote.Text)
                    {
                        case "SEMANAL":

                            txtValorUnitProduto.Text = Convert.ToDecimal(frm.produto.ValorPcteSemanal).ToString("C");
                            break;

                        case "MENSAL":
                            txtValorUnitProduto.Text = Convert.ToDecimal(frm.produto.ValorPcteMensal).ToString("C");
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione tipo de pacote antes de incluir um item no pedido", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoPacote.Focus();
            }
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            if (codigoProduto > 0)
            {
                InserirProdutoListViewTemp(codigoProduto, txtProduto.Text, txtValorUnitProduto.Text, int.Parse(txtQtde.Text), txtSubtotal.Text);
                RealizarSomatorioItensPedido();
                txtCodigoBarra.Focus();
                txtCodigoBarra.Clear();
                txtProduto.Clear();
                txtValorUnitProduto.Clear();
                txtQtde.Clear();
                txtSubtotal.Clear();
                btnAplicarDesconto.Enabled = false;

                if (lwItensPedido.Items.Count > 0)
                {
                    btnFinalizarPedido.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Informe um item ao pedido", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
            }
        }

        private void RealizarSomatorioItensPedido()
        {
            valorTotal = 0;
            qtdeItensGeral = 0;
            txtQtdeItem.Clear();
            txtSubtotal.Clear();
            txtTotalPacote.Clear();
            txtQtde.Clear();
            txtQtdeTotalItens.Clear();

            if (lwItensPedido.Items.Count > 0)
            {
                for (int i = 0; i < lwItensPedido.Items.Count; i++)
                {
                    valorTotal += decimal.Parse(lwItensPedido.Items[i].SubItems[4].Text.Substring(2));
                    qtdeItensGeral += Convert.ToInt32(lwItensPedido.Items[i].SubItems[3].Text);
                }

                txtQtdeTotalItens.Text = qtdeItensGeral.ToString();
                txtQtdeItem.Text = lwItensPedido.Items.Count.ToString();
                txtTotalPacote.Text = Convert.ToDecimal(valorTotal).ToString("C");
            }
            else
            {
                btnFinalizarPedido.Enabled = false;
            }
        }

        private void InserirProdutoListViewTemp(int codProduto, string nomeProduto, string vlrUnitario, int qtde, string subTotal)
        {
            try
            {
                lwItensPedido.Items.Add(codProduto.ToString());
                lwItensPedido.Items[count].SubItems.Add(nomeProduto);
                lwItensPedido.Items[count].SubItems.Add(vlrUnitario);
                lwItensPedido.Items[count].SubItems.Add(qtde.ToString());
                lwItensPedido.Items[count].SubItems.Add(subTotal);
                count++;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQtde_Enter_1(object sender, EventArgs e)
        {
            qtdeFocus = true;
        }

        private void txtTipoPacote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTipoPacote.SelectedIndex != 0)
                {
                    btnIncluirProduto.Enabled = true;
                    btnPesquisarProduto.Enabled = true;
                    btnPesquisarCliente.Enabled = true;
                    txtCodigoBarra.Focus();
                }
            }
            catch (Exception) { }
        }

        private void ctmenuStrip_Click(object sender, EventArgs e)
        {
            if (lwItensPedido.Items.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o item selecionado ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lwItensPedido.Items.RemoveAt(indexPosItem);
                    count--;

                    RealizarSomatorioItensPedido();

                    if (lwItensPedido.Items.Count == 0)
                    {
                        ctmenuItemExcluir.Visible = false;
                        count = 0;
                        btnFinalizarPedido.Enabled = false;
                    }
                }
            }
        }

        private void lwItensPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwItensPedido.Items.Count > 0)
            {
                indexPosItem = lwItensPedido.FocusedItem.Index;
            }
        }

        public void CarregaPedidoSelecioandoId(int pedidoId, bool isEdit)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedido = db.Pedidos.Find(pedidoId);

                if (pedido != null)
                {
                    this.editar = isEdit;
                    //Popula campos cabeçalho - pedido
                    this.codigoPedido = pedidoId;
                    codigoCliente = pedido.ClienteId;
                    txtCodigo.Text = pedido.ClienteId.ToString();
                    txtCelular.Text = pedido.Cliente.Celular;
                    txtCodigo.Text = pedido.Cliente.ClienteId.ToString();
                    txtDataPacote.Text = pedido.Data.ToString("dd/MM/yyyy");
                    txtCelular.Text = pedido.ClienteId != null ? pedido.Cliente.Celular : string.Empty;
                    txtCPF.Text = pedido.ClienteId != null ? pedido.Cliente.Documento : string.Empty;
                    txtNomeCliente.Text = pedido.ClienteId != null ? pedido.Cliente.Nome : "VENDA AVULSA";
                    txtNumeroPedido.Text = AdicionaZero(pedido.PedidoId.ToString());

                    //Busca itens do pedido
                    var itensPedido = db.ItensPedidos.Where(i => i.PedidoId == pedidoId).ToList();

                    if (itensPedido.Count > 0)
                    {
                        foreach (var item in itensPedido)
                        {
                            InserirProdutoListViewTemp(item.ProdutoId, item.Produto.Nome, item.VlrUnitario.ToString("C"), item.Qtde, item.SubTotal.ToString("C"));
                        }
                    }

                    //Realiza somatorio itens pedido
                    RealizarSomatorioItensPedido();
                }
            }
        }

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            txtValorUnitProduto.ReadOnly = false;
            txtValorUnitProduto.Focus();
        }

        private void txtValorUnitProduto_Leave_1(object sender, EventArgs e)
        {
            try
            {
                txtValorUnitProduto.Text = Convert.ToDecimal(txtValorUnitProduto.Text).ToString("C");
                btnAplicarDesconto.Enabled = false;
                txtValorUnitProduto.ReadOnly = true;
                txtQtde.Focus();
            }
            catch (Exception msg)
            {
            }
        }

        private void txtValorUnitProduto_Enter_1(object sender, EventArgs e)
        {
            isFocusPrecoUnitario = true;
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

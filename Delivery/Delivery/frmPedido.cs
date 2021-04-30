using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmPedido : Form
    {
        int countItem = 1;
        int indexPosItem = 0;
        int count = 0;
        int codigoProduto;
        int? codigoCliente = null;
        int? codigoFormaPgto = null;
        int? codigoPedido = null;
        decimal? valorDesconto = null;
        decimal valorTotal = 0;
        decimal? valorTotalFinal = null;
        decimal? valorTaxaEntre = null;
        decimal? valorTroco = null;
        decimal? valorPagamento = null;
        string situacao = "não pago";
        bool editar = false;
        bool isCancelar = false;
        bool isFinalizado = false;
        bool isCredito = false;
        bool isFocusPrecoUnitario = false;

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        public Operador operador = new Operador();

        public frmPedido(Operador operador)
        {
            InitializeComponent();
            this.operador = operador;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
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

            if (operador.TipoUsuario.Equals("ADMINISTRADOR"))
            {
                txtDataVenda.Enabled = true;
            }
            else
            {
                txtDataVenda.Enabled = false;
            }

 
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHoraPedido.Text = DateTime.Now.ToString("HH:mm:ss");
            btnFinalizarPedido.Enabled = false;
            txtCodigoBarra.Focus();
            CarregaComboFuncionarioEntregador();

            if (lwItensPedido.Items.Count == 0)
            {
                ctmenuItemExcluir.Visible = false;
            }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void SalvarPedido()
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = new Pedido();

                    pedido.ClienteId = codigoCliente;
                    pedido.ClienteId = codigoCliente;
                    pedido.Hora = txtHoraPedido.Text;
                    pedido.Data = Convert.ToDateTime(txtDataVenda.Text);
                    pedido.FormaPagamentoId = codigoFormaPgto;
                    pedido.FuncionarioId = Convert.ToInt32(txtFuncionarioEntregador.SelectedValue);
                    pedido.OperadorId = operador.OperadorId;
                    pedido.Situacao = situacao;
                    pedido.TaxaEntrega = valorTaxaEntre;
                    pedido.TipoPedido = codigoCliente == null ? "Pedido balcão" : "Pedido entrega";
                    pedido.VlrDesconto = valorDesconto;
                    pedido.VlrTotal = valorTotal;
                    pedido.VlrTotalFinal = valorTotalFinal;
                    pedido.IsExcluir = false;
                    pedido.IsPcte = false;
                    pedido.DataHoraInicio = Convert.ToDateTime(txtDataVenda.Text);

                    if (situacao.Equals("pago"))
                    {
                        pedido.DataHoraPgto = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        pedido.DataHoraPgto = null;
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

                        Util.GerarArquivoTxtComprovanteVenda("comum", codigoPedido, codigoCliente, valorPagamento, valorTroco);

                        ImprimirComprovanteVenda();
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
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message + ".\nOcorreru um erro inesperado na hora de salvar o pedido.\nTente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AlterarPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedido = db.Pedidos.Find(codigoPedido);

                pedido.ClienteId = codigoCliente;
                pedido.ClienteId = codigoCliente;
                pedido.Hora = txtHoraPedido.Text;
                pedido.Data = Convert.ToDateTime(txtDataVenda.Text);
                pedido.FormaPagamentoId = codigoFormaPgto;
                pedido.FuncionarioId = Convert.ToInt32(txtFuncionarioEntregador.SelectedValue);
                pedido.OperadorId = operador.OperadorId;
                pedido.Situacao = situacao;
                pedido.TaxaEntrega = valorTaxaEntre;
                pedido.TipoPedido = codigoCliente == null ? "Pedido balcão" : "Pedido entrega";
                pedido.VlrDesconto = valorDesconto;
                pedido.VlrTotal = valorTotal;
                pedido.VlrTotalFinal = valorTotalFinal;
                pedido.IsExcluir = false;
                pedido.IsPcte = false;

                if (isFinalizado == false)//<----parei aqui
                {
                    if (MessageBox.Show("Deseja salvar alterações a este pedido ?", "Confirmação para salvar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.SaveChanges();

                        //Excluir itens da lista, depois inclui novamente
                        var itensPedido = db.ItensPedidos.Where(p => p.PedidoId == codigoPedido).ToList();
                        db.ItensPedidos.RemoveRange(itensPedido);
                        db.SaveChanges();

                        SalvaItemsPedido();

                        MessageBox.Show("Pedido salvo com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    db.SaveChanges();

                    //Excluir itens da lista, depois inclui novamente
                    var itensPedido = db.ItensPedidos.Where(p => p.PedidoId == codigoPedido).ToList();
                    db.ItensPedidos.RemoveRange(itensPedido);
                    db.SaveChanges();

                    SalvaItemsPedido();

                    MessageBox.Show("Pedido finalizado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Util.GerarArquivoTxtComprovanteVenda("comum", codigoPedido, codigoCliente, valorPagamento, valorTroco);

                    ImprimirComprovanteVenda();
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

        private void SalvaItemsPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                for (int i = 0; i < lwItensPedido.Items.Count; i++)
                {
                    ItensPedido itensPedido = new ItensPedido();

                    itensPedido.Item = countItem;
                    itensPedido.PedidoId = codigoPedido;
                    itensPedido.ProdutoId = int.Parse(lwItensPedido.Items[i].SubItems[0].Text);
                    itensPedido.VlrUnitario = decimal.Parse(lwItensPedido.Items[i].SubItems[2].Text.Substring(2));
                    itensPedido.Qtde = int.Parse(lwItensPedido.Items[i].SubItems[3].Text);
                    itensPedido.SubTotal = decimal.Parse(lwItensPedido.Items[i].SubItems[4].Text.Substring(2));
                    itensPedido.DataConsumo = Convert.ToDateTime(txtDataVenda.Text);
                    itensPedido.IsConsumo = false;
                    itensPedido.IsPctItem = false;
                    itensPedido.IsChecked = true;

                    db.ItensPedidos.Add(itensPedido);
                    db.SaveChanges();

                    countItem++;
                }
            }
        }

        private void LimparCampos()
        {
            lwItensPedido.Items.Clear();
            txtHoraPedido.Clear();
            txtCelular.Clear();
            txtCodigoBarra.Clear();
            txtCPF.Clear();
            txtDescricaoProduto.Clear();
            txtNomeCliente.Clear();
            txtNumeroPedido.Clear();
            txtQtdeItem.Clear();
            txtPrecoUnit.Clear();
            txtQtde.Clear();
            txtSubtotal.Clear();
            txtCodigo.Clear();
            txtTotalSubtotal.Clear();
            count = 0;
            indexPosItem = 0;
            countItem = 1;
            codigoCliente = null;
            codigoFormaPgto = null;
            valorDesconto = null;
            valorTaxaEntre = null;
            valorTotalFinal = null;
            valorTotal = 0;
            editar = false;
            isCancelar = false;
            isFinalizado = false;
            isFocusPrecoUnitario = false;
            situacao = "Aberto";
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F2)
            {
                BuscarProduto();
            }
            else if (e.KeyCode == Keys.F3)
            {
                BuscarCliente();
            }
            else if (e.KeyCode == Keys.F5)
            {
                FinalizarPedido();
            }
            else if (e.KeyCode == Keys.F8)
            {
                btnAplicarDesconto_Click(this, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigoBarra.Text.Trim() != string.Empty)//Chama o método buscar produto
                {
                    if (isFocusPrecoUnitario != true)
                    {
                        GetProduto();
                    }
                    else
                    {
                        try
                        {
                            txtPrecoUnit.Text = Convert.ToDecimal(txtPrecoUnit.Text).ToString("C");
                            txtQtde.Focus();
                            btnAplicarDesconto.Enabled = false;
                            txtPrecoUnit.ReadOnly = true;
                        }
                        catch (Exception msg)
                        { }
                    }
                }
                if (txtQtde.Text.Trim() != string.Empty)//Realiza calculo subtotal
                {
                    decimal precoUnitario = Convert.ToDecimal(txtPrecoUnit.Text.Substring(2));
                    int qtde = Convert.ToInt32(txtQtde.Text);
                    decimal total = precoUnitario * qtde;

                    txtSubtotal.Text = total.ToString("C");

                    btnIncluirProduto.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BuscarCliente()
        {
            pPrincipal.Visible = false;

            frmTodosClientes frm = new frmTodosClientes();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.cliente != null)
            {
                txtCodigo.Text = frm.cliente.ClienteId.ToString();
                txtCPF.Text = frm.cliente.Documento;
                txtNomeCliente.Text = frm.cliente.Nome;
                txtCelular.Text = frm.cliente.Celular;
                codigoCliente = frm.cliente.ClienteId;
            }
        }

        private void BuscarProduto()
        {
            pPrincipal.Visible = false;

            frmTodosProdutos frm = new frmTodosProdutos();
            frm.ShowDialog();

            pPrincipal.Visible = true;

            if (frm.produto != null)
            {
                btnAplicarDesconto.Enabled = true;
                txtCodigoBarra.Text = frm.produto.CodigoBarra;
                txtDescricaoProduto.Text = frm.produto.Nome;
                txtPrecoUnit.Text = frm.produto.Valor.ToString("C");
                codigoProduto = frm.produto.ProdutoId;
                txtQtde.Focus();
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

        private void GetProduto()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var produto = db.Produtos.Where(p => p.CodigoBarra.Equals(txtCodigoBarra.Text)).FirstOrDefault();

                if (produto != null)
                {
                    txtDescricaoProduto.Text = produto.Nome;
                    txtPrecoUnit.Text = produto.Valor.ToString("C");
                    codigoProduto = produto.ProdutoId;
                    txtQtde.Focus();
                }
                else
                {
                    MessageBox.Show("Produto não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Focus();
                    txtCodigoBarra.Clear();
                }
            }
        }

        private void InserirProdutoListViewTemp(int codProduto, string nomeProduto, decimal vlrUnitario, int qtde, decimal subTotal)
        {
            try
            {
                lwItensPedido.Items.Add(codProduto.ToString());
                lwItensPedido.Items[count].SubItems.Add(nomeProduto);
                lwItensPedido.Items[count].SubItems.Add(vlrUnitario.ToString("C"));
                lwItensPedido.Items[count].SubItems.Add(qtde.ToString());
                lwItensPedido.Items[count].SubItems.Add(subTotal.ToString("C"));
                count++;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarSomatorioItensPedido()
        {
            valorTotal = 0;
            txtQtdeItem.Clear();
            txtSubtotal.Clear();

            if (lwItensPedido.Items.Count > 0)
            {
                for (int i = 0; i < lwItensPedido.Items.Count; i++)
                {
                    valorTotal += decimal.Parse(lwItensPedido.Items[i].SubItems[4].Text.Substring(2));
                    txtTotalSubtotal.Text = valorTotal.ToString("C");
                    txtQtdeItem.Text = lwItensPedido.Items.Count.ToString();
                }
            }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            FinalizarPedido();
        }

        private void FinalizarPedido()
        {
            if (Util.VerificarCaixaIsAbertoOperacoesDiversas(Convert.ToDateTime(txtDataVenda.Text)) == true)
            {
                try
                {
                    if (lwItensPedido.Items.Count > 0)
                    {
                        if(txtFuncionarioEntregador.Text.Equals("Selecione..."))
                        {
                            MessageBox.Show("Selecione o entregador por gentileza", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtFuncionarioEntregador.Focus();
                            return;
                        }

                        pPrincipal.Visible = false;
                        panel2.Visible = false;

                        frmFinalizarPedido frm = new frmFinalizarPedido();

                        frm.CarregaDadosPedido(codigoPedido, valorTotal, codigoCliente, Convert.ToDateTime(txtDataVenda.Text), false, Convert.ToInt32(txtFuncionarioEntregador.SelectedValue));

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
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message + ".\nVamos tentar novamente,caso erro volte a persitir, entre em contato com suporte ténico.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data " + Convert.ToDateTime(txtDataVenda.Text).ToString("dd/MM/yyyy") + " encontra-se fechado.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void CarregaPedidoSelecioandoId(int pedidoId, bool isEdit)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                CarregaComboFuncionarioEntregador();

                var pedido = db.Pedidos.Find(pedidoId);

                if (pedido != null)
                {
                    this.editar = isEdit;
                    //Popula campos cabeçalho - pedido
                    this.codigoPedido = pedidoId;
                    txtFuncionarioEntregador.SelectedItem = pedido.FuncionarioId.ToString();
                    codigoCliente = pedido.ClienteId;
                    txtCodigo.Text = pedido.ClienteId.ToString();
                    txtDataVenda.Text = pedido.Data.ToString("dd/MM/yyyy");
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
                            InserirProdutoListViewTemp(item.ProdutoId, item.Produto.Nome, item.VlrUnitario, item.Qtde, item.SubTotal);
                        }
                    }

                    //Realiza somatorio itens pedido
                    RealizarSomatorioItensPedido();
                }
            }
        }

        private void ctmenuItemExcluir_Click(object sender, EventArgs e)
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

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            txtPrecoUnit.ReadOnly = false;
            txtPrecoUnit.Focus();
        }

        private void pcBoxFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcBoxFechar_MouseHover_1(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pcBoxFechar_MouseLeave_1(object sender, EventArgs e)
        {
            pcBoxFechar.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void btnIncluirProduto_Click_1(object sender, EventArgs e)
        {
            InserirProdutoListViewTemp(codigoProduto, txtDescricaoProduto.Text, decimal.Parse(txtPrecoUnit.Text.Substring(2)), int.Parse(txtQtde.Text), decimal.Parse(txtSubtotal.Text.Substring(2)));
            RealizarSomatorioItensPedido();
            txtCodigoBarra.Focus();
            txtCodigoBarra.Clear();
            txtDescricaoProduto.Clear();
            txtPrecoUnit.Clear();
            txtQtde.Clear();
            txtSubtotal.Clear();

            if (lwItensPedido.Items.Count > 0)
            {
                ctmenuItemExcluir.Visible = true;
                btnFinalizarPedido.Enabled = true;
            }
        }

        private void lwItensPedido_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lwItensPedido.Items.Count > 0)
            {
                indexPosItem = lwItensPedido.FocusedItem.Index;
            }
        }

        private void txtPrecoUnit_Enter_1(object sender, EventArgs e)
        {
            isFocusPrecoUnitario = true;
        }

        private void txtPrecoUnit_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPrecoUnit.Text = Convert.ToDecimal(txtPrecoUnit.Text).ToString("C");
                txtQtde.Focus();
                btnAplicarDesconto.Enabled = false;
                txtPrecoUnit.ReadOnly = true;
            }
            catch (Exception msg)
            {

            }
        }
    }
}
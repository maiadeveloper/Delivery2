using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmTodosPedidos : Form
    {
        //private Thread thread;
        int count = 0;
        decimal valorTotal = 0;
        decimal valorTotalPago = 0;
        decimal valorTotalNaoPago = 0;
        int pedidoId;
        bool isCredito;
        bool isSomenteBloqueado = false;
        List<Pedido> pedidos = new List<Pedido>();
        string situacao;
        StringBuilder sbItemPedido = new StringBuilder();
        int cont = 1;

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        public Operador operador = new Operador();
        private Thread thread;

        public frmTodosPedidos(Operador operador)
        {
            InitializeComponent();
            this.operador = operador;
            ValidaTipoAcaoOperador(this.operador);
        }

        public void ValidaTipoAcaoOperador(Operador operador)
        {
            if (operador.OpIncluir == false)
            {
                btnNovo.Visible = false;
            }

            if (operador.OpExcluir == false)
            {
                cancelarPedidoToolStripMenuItem.Visible = false;
            }
            if (operador.OpEditar == false)
            {
                fecharPedidoToolStripMenuItem.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Util.VerificarCaixaIsAbertoOperacoesDiversas() == true)
            {
                pPrincipal.Visible = false;
                frmPedido frm = new frmPedido(operador);
                frm.operador = operador;
                frm.ShowDialog();
                CarregaListagemPedidos();
                pPrincipal.Visible = true;
            }
            else
            {
                if (MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data ainda não foi aberto ou ja  foi fechado. \nDeseja verificar", "Atenção usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmRelacaoCaixaAbertoFechado frm = new frmRelacaoCaixaAbertoFechado();
                    frm.ShowDialog();
                }
                return;
            }
        }

        private void CarregaListagemPedidos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                lwPedidos.Items.Clear();
                pedidos = null;
                count = 0;
                valorTotal = 0;
                valorTotalPago = 0;
                valorTotalNaoPago = 0;
                txtTotalPago.Clear();
                txtTotalNaoPago.Clear();
                txtTotalGeral.Clear();
                txtQtdeItem.Clear();
                lwPedidos.SmallImageList = imageList1;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                if (situacao.Equals("Todos"))
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false && p.IsBloquearEntrega == isSomenteBloqueado && p.Cliente.Nome.Contains(txtParametroBusca.Text) || p.ClienteId == null && p.IsExcluir == false).OrderBy(p => p.Data).ToList();
                    pedidos = lista;
                }
                else if (situacao.Equals("pacote"))
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false && p.IsBloquearEntrega == isSomenteBloqueado && p.IsPcte == true && p.Cliente.Nome.Contains(txtParametroBusca.Text) || p.ClienteId == null && p.IsExcluir == false).OrderBy(p => p.Data).ToList();
                    pedidos = lista;

                }
                else if (situacao != "Todos")
                {
                    var lista = db.Pedidos.Where(p => p.Data >= dtInicial && p.Data <= dtFinal && p.IsExcluir == false && p.IsBloquearEntrega == isSomenteBloqueado && p.Cliente.Nome.Contains(txtParametroBusca.Text) && p.Situacao.Equals(situacao) || p.ClienteId == null && p.IsExcluir == false).OrderBy(p => p.Data).ToList();
                    pedidos = lista;

                }
                if (pedidos.Count != 0)
                {
                    lwPedidos.Visible = true;
                    btnMensagem.Visible = false;
                    btnGerarRelatorio.Enabled = true;

                    foreach (var item in pedidos)
                    {
                        cont = 1;

                        if (item.IsPcte == true)
                        {
                            lwPedidos.Items.Add("", 0);
                        }
                        else
                        {
                            lwPedidos.Items.Add("", 1);
                        }

                        lwPedidos.Items[count].SubItems.Add(AdicionaZero(item.PedidoId.ToString()));
                        lwPedidos.Items[count].SubItems.Add(item.Data.ToString("dd/MM/yyyy"));
                        lwPedidos.Items[count].SubItems.Add(item.Hora);

                        lwPedidos.Items[count].SubItems.Add(item.ClienteId == null ? "000.000.000-00" : item.Cliente.Documento);
                        lwPedidos.Items[count].SubItems.Add(item.ClienteId == null ? "CLIENTE AVULSO" : item.Cliente.Nome);

                        var itensPedidos = db.ItensPedidos.Where(i => i.PedidoId == item.PedidoId).ToList();

                        //Adiciona o item do pedido                 
                        foreach (var itemPedido in itensPedidos)
                        {
                            sbItemPedido.Append("Item" + cont + ": " + itemPedido.Produto.Nome + "  ");
                            cont++;
                        }

                        lwPedidos.Items[count].SubItems.Add(sbItemPedido.ToString());

                        sbItemPedido.Clear();

                        lwPedidos.Items[count].SubItems.Add(item.TipoPedido);
                        lwPedidos.Items[count].SubItems.Add(item.FormaPagamentoId == null ? " " : item.FormaPagamento.Nome);
                        lwPedidos.Items[count].SubItems.Add(Convert.ToDecimal(item.VlrTotal).ToString("C"));
                        lwPedidos.Items[count].SubItems.Add(Convert.ToDecimal(item.TaxaEntrega).ToString("C"));
                        lwPedidos.Items[count].SubItems.Add(Convert.ToDecimal(item.VlrDesconto).ToString("C"));
                        lwPedidos.Items[count].SubItems.Add(Convert.ToDecimal(item.VlrTotalFinal).ToString("C"));
                        lwPedidos.Items[count].SubItems.Add(item.Situacao);

                        if (item.Situacao.Equals("pago"))
                        {
                            valorTotalPago += Convert.ToDecimal(item.VlrTotalFinal);
                            lwPedidos.Items[count].ForeColor = System.Drawing.Color.Green;
                        }

                        if (item.Situacao.Equals("não pago"))
                        {
                            valorTotalNaoPago += Convert.ToDecimal(item.VlrTotalFinal);
                            lwPedidos.Items[count].ForeColor = System.Drawing.Color.Red;
                        }


                        valorTotal += Convert.ToDecimal(item.VlrTotalFinal);

                        count++;
                    }

                    txtQtdeItem.Text = lwPedidos.Items.Count.ToString();
                    txtTotalGeral.Text = valorTotal.ToString("C");
                    txtTotalNaoPago.Text = valorTotalNaoPago.ToString("C");
                    txtTotalPago.Text = valorTotalPago.ToString("C");
                }
                else
                {
                    lwPedidos.Visible = false;
                    btnMensagem.Visible = true;
                    btnGerarRelatorio.Enabled = false;
                }
            }
        }


        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemPedidos();
        }

        private void frmTodosPedidos_Load(object sender, EventArgs e)
        {
            situacao = "Todos";
            btnNovo.Focus();
            CarregaListagemPedidos();

            //Função é chamada no loado do sistema agora 28/09/2020
            //Cria uma nova thread, indicando qual método essa thread deverá executar
            //thread = new Thread(() =>
            //{
            //    //Código que será executado em paralelo ao resto do código
            //    Util.AtualizarItensPedidosPcte();
            //});

            ////Inicia a execução da thread (em paralelo a esse código)
            //thread.Start();
        }

        protected string AdicionaZero(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaListagemPedidos();
        }

        private void ctmenuItemExcluir_Click(object sender, EventArgs e)
        {
            if (lwPedidos.Items.Count > 0)
            {
                pedidoId = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = db.Pedidos.Find(pedidoId);

                    Util.GerarArquivoTxtComprovanteVenda(pedido.IsPcte == true ? "pacote" : "comum",
                        pedido.PedidoId, pedido.ClienteId, pedido.VlrTotalFinal, Convert.ToDecimal("0,00"));

                    ImprimirComprovanteVenda(pedidoId);
                }
            }
        }

        public void GerarArquivoTxtComprovanteVenda()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                //Carrega dados da empresa
                var empresa = db.Empresas.OrderByDescending(e => e.EmpresaId).FirstOrDefault();

                //Carrega dados do pedido
                var pedido = db.Pedidos.Find(pedidoId);

                if (empresa != null)
                {
                    var cliente = db.Clientes.Where(c => c.ClienteId == pedido.ClienteId).FirstOrDefault();


                    string nomeCliente = pedido.ClienteId == null ? "VENDA AVULSA" : cliente.Nome;
                    string nomeEntregador = pedido.ClienteId == null ? string.Empty : pedido.Funcionario.Nome;
                    string lblCreditoTroco = isCredito != true ? "TROCO" : "CRÉDITO";

                    DateTime data = Convert.ToDateTime(pedido.Data.ToString("dd/MM/yyyy"));

                    //cria o arquivo txt para um determinado diretorio
                    FileInfo arquivo = new FileInfo(Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt");

                    using (FileStream fs = arquivo.Create()) { }

                    //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
                    string[] texto = {
                                 "                            COMPROVANTE DE VENDA                            ",
                                 "============================================",
                                  "" + empresa.Razao,
                                  "" +"CNPJ: " + empresa.CNPJ,
                                 "============================================",
                                 "Data: " + data.ToString() +        "          Número pedido: " + pedidoId,
                                 "Cliente: " + nomeCliente,
                                 "============================================",
                                 "Entregador: " + nomeEntregador                               +"",
                                 "============================================",
                                 "============================================",
                                 "Cod   Produto                                        Qtde   Preço   Total",
                                 "============================================",
                                 IncluirItens(),
                                 "VALOR TOTAL PRODUTO(S)..: R$                                          " + pedido.VlrTotalFinal,
                                 "                                                                      ======",
                                 "TOTAL PAGAR..: R$                                                      " + pedido.VlrTotalFinal,
                                 "DESCONTO......: R$                                                   - " + pedido.VlrDesconto,
                                 "                                                                      ======",
                                 "PAGANDO...: R$  " + "                                                      " + pedido.VlrTotalFinal,
                                 ""+ lblCreditoTroco + ": R$" + "                                                             " + Convert.ToDecimal("0.00").ToString("N2"),
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

                var itensPedido = db.ItensPedidos.Where(i => i.PedidoId == pedidoId).ToList();

                foreach (var item in itensPedido)
                {
                    string cod, produto, qtde, preco, total;

                    cod = item.ProdutoId.ToString();
                    produto = item.Produto.Nome;
                    qtde = item.Qtde.ToString();
                    preco = item.VlrUnitario.ToString("C");
                    total = item.SubTotal.ToString("C");

                    sb.AppendLine(" " + cod + "    " + produto + "                   " + qtde + "        " + preco + "        " + total);
                }
            }
            return sb.ToString();
        }

        public void ImprimirComprovanteVenda(int pedidoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                //Carrega dados da empresa
                var empresa = db.Empresas.OrderByDescending(e => e.EmpresaId).FirstOrDefault();

                if (empresa != null)
                {
                    int copia = 1;

                    if (empresa.ConfirmaImpressao == true)
                    {
                        if (MessageBox.Show("Deseja imprimir comprovante da venda: " + AdicionaZero(pedidoId.ToString()) + "", "Confirmação recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void frmTodosPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaListagemPedidos();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnNovo_Click(this, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                btnPedidoPacote_Click(this, e);
            }
            if (e.KeyCode == Keys.Add)
            {
                pPrincipal.Visible = false;
                frmPedido frm = new frmPedido(operador);
                frm.ShowDialog();
                CarregaListagemPedidos();
                pPrincipal.Visible = true;
            }
        }

        private void cancelarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirPedido();
        }

        private void ExcluirPedido()
        {
            if (lwPedidos.Items.Count > 0)
            {
                int codigoPedido = Convert.ToInt32(lwPedidos.FocusedItem.SubItems[1].Text);

                if (MessageBox.Show("Deseja excluir o pedido: " + codigoPedido + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        var pedido = db.Pedidos.Find(codigoPedido);

                        if (pedido != null)
                        {
                            //Altera o status para excluido
                            pedido.IsExcluir = true;
                            db.SaveChanges();

                            var movimentacao = db.MovimentacoesCliente.Where(m => m.PedidoId == pedido.PedidoId).FirstOrDefault();

                            if (movimentacao != null)
                            {
                                //Exclui movimentação
                                db.MovimentacoesCliente.Remove(movimentacao);
                                db.SaveChanges();
                            }

                            MessageBox.Show("Pedido excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregaListagemPedidos();
                        }
                    }
                }
            }
        }

        private void fecharPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lwPedidos.Items.Count > 0)
                {
                    int codPedido = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                    string situacao = lwPedidos.FocusedItem.SubItems[12].Text;

                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        var pedido = db.Pedidos.Find(codPedido);

                        if (pedido != null)
                        {
                            if (situacao.Equals("pago"))
                            {
                                pedido.Situacao = "não pago";
                                pedido.DataHoraPgto = null;
                            }
                            else
                            {
                                pedido.Situacao = "pago";
                                pedido.DataHoraPgto = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                            }

                            string cliente = pedido.Cliente != null ? pedido.Cliente.Nome : "CLIENTE AVULSO";

                            if (MessageBox.Show("Confirma alterar situação do pedido " + codPedido + "\n\nCliente: " + cliente + "\n\nde " + lwPedidos.FocusedItem.SubItems[12].Text.ToString().ToUpper() + " para " + pedido.Situacao.ToString().ToUpper() + " ?\n\nAPÓS ISSO O PEDIDO PODERÁ SER\n EDITADO NOVAMENTE.", "Confirmação alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                db.SaveChanges();

                                MessageBox.Show("situação do pedido alterado com sucesso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CarregaListagemPedidos();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo de errado aconteceu (" + erro.Message + ")", "Mensagem sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Todos";
            CarregaListagemPedidos();
        }

        private void rbAberto_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "não pago";
            CarregaListagemPedidos();
        }

        private void rbFechado_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "pago";
            CarregaListagemPedidos();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (pedidos.Count > 0)
            {
                frmBaseRletorioGeralPedidosProduto frm = new frmBaseRletorioGeralPedidosProduto();
                frm.CarregaListaPedido(pedidos);
                frm.ShowDialog();
            }
        }

        private void btnPedidoPacote_Click(object sender, EventArgs e)
        {
            if (Util.VerificarCaixaIsAbertoOperacoesDiversas() == true)
            {
                pPrincipal.Visible = false;
                frmPedidoPcte frm = new frmPedidoPcte(operador);
                frm.operador = operador;
                frm.ShowDialog();
                CarregaListagemPedidos();
                pPrincipal.Visible = true;
            }
            else
            {
                if (MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data ainda não foi aberto ou ja  foi fechado. \nDeseja verificar", "Atenção usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmRelacaoCaixaAbertoFechado frm = new frmRelacaoCaixaAbertoFechado();
                    frm.ShowDialog();
                }
                return;
            }
        }

        private void detalharPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwPedidos.Items.Count > 0)
            {
                int pedidoId = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = db.Pedidos.Find(pedidoId);

                    if (pedido != null)
                    {
                        pPrincipal.Visible = false;

                        frmDetalharPedido frm = new frmDetalharPedido();

                        frm.CarregaPedidoSelecioandoId(pedidoId);

                        frm.ShowDialog();

                        pPrincipal.Visible = true;

                        CarregaListagemPedidos();
                    }
                }
            }
        }

        private void rbPcte_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "pacote";
            CarregaListagemPedidos();
        }


        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwPedidos.Items.Count > 0)
            {
                int pedidoId = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = db.Pedidos.Find(pedidoId);

                    if (pedido != null)
                    {
                        if (pedido.IsBloquearEntrega == true)
                        {
                            MessageBox.Show("Este pedido ja encontra-se pausado para entrega", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (MessageBox.Show("Confirma pausar a entrega do pedido: " + Util.AdicionaZero(pedido.PedidoId.ToString()) + "\n\nCliente: " + pedido.Cliente.Nome, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                pedido.IsBloquearEntrega = true;
                                pedido.DataRetornoEntregaPacote = null;

                                db.SaveChanges();

                                MessageBox.Show("Este pedido foi pausado para entrega até a confirmação do cliente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CarregaListagemPedidos();
                            }
                        }
                    }
                }
            }
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwPedidos.Items.Count > 0)
            {
                int pedidoId = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = db.Pedidos.Find(pedidoId);

                    if (pedido != null)
                    {
                        if (pedido.IsBloquearEntrega == false)
                        {
                            MessageBox.Show("Este pedido ja encontra-se habilitado para entrega", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (MessageBox.Show("Confirma desativar a pausa é dar continuidade na entrega do pedido: " + Util.AdicionaZero(pedido.PedidoId.ToString()) + "\n\nCliente: " + pedido.Cliente.Nome, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                pedido.IsBloquearEntrega = false;

                                pedido.DataRetornoEntregaPacote = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                                db.SaveChanges();

                                MessageBox.Show("Este pedido foi dado continuidade para entrega", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CarregaListagemPedidos();

                                thread = new Thread(() =>
                                {
                                    //Código que será executado em paralelo ao resto do código
                                    Util.AtualizarItensPedidosPcte(null);
                                });

                                //Inicia a execução da thread (em paralelo a esse código)
                                thread.Start();
                            }
                        }
                    }
                }
            }
        }

        private void editarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwPedidos.Items.Count > 0)
            {
                int pedidoId = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var pedido = db.Pedidos.Find(pedidoId);

                    if (pedido != null)
                    {
                        if (lwPedidos.FocusedItem.SubItems[12].Text.Equals("pago"))
                        {
                            MessageBox.Show("Pedido encontra-se fechado. Não é possivel edita-lo", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        //Carrega pedido pacote para editar
                        if (pedido.IsPcte == true)
                        {
                            pPrincipal.Visible = false;
                            frmPedidoPcte frm = new frmPedidoPcte(operador);
                            frm.operador = operador;
                            frm.CarregaPedidoSelecioandoId(pedidoId, true);
                            frm.ShowDialog();
                        }
                        //Carrega pedido normal  para editar
                        else
                        {
                            pPrincipal.Visible = false;
                            frmPedido frm = new frmPedido(operador);
                            frm.CarregaPedidoSelecioandoId(pedidoId, true);
                            frm.ShowDialog();
                        }
                        pPrincipal.Visible = true;
                        CarregaListagemPedidos();
                    }
                }
            }
        }

        private void visualizarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwPedidos.Items.Count > 0)
            {
                pedidoId = int.Parse(lwPedidos.FocusedItem.SubItems[1].Text);

                frmBaseReciboVenda frmReciboVenda = new frmBaseReciboVenda();
                frmReciboVenda.CarregaReciboVenda(pedidoId);
                frmReciboVenda.ShowDialog();
            }
        }

        private void ckBoxSomenteBloqueado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxSomenteBloqueado.Checked)
            {
                isSomenteBloqueado = true;
            }
            else
            {
                isSomenteBloqueado = false;
            }
            CarregaListagemPedidos();
        }
    }
}

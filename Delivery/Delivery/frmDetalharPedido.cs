using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmDetalharPedido : Form
    {
        public frmDetalharPedido()
        {
            InitializeComponent();
        }

        Pedido pedido = new Pedido();
        private Thread thread;

        public void CarregaPedidoSelecioandoId(int id)
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    int countItemConsumido = 0;
                    int countItemNaoConsumido = 0;
                    int countItemTodos = 0;

                    var pedido = db.Pedidos.Find(id);

                    lwItensPedidoNaoConsumido.Items.Clear();
                    lwItensPedidoConsumido.Items.Clear();
                    lwItensPedidoTodos.Items.Clear();

                    if (pedido != null)
                    {
                        this.pedido = pedido;

                        txtTipoPedido.Text = pedido.IsPcte == true ? "Pedido em Pacote" : "Pedido Normal";

                        txtNPedido.Text = Util.AdicionaZero(pedido.PedidoId.ToString());
                        txtCpf.Text = pedido.Cliente == null ? "000.000.000-00" : pedido.Cliente.Documento;
                        txtNomeCliente.Text = pedido.Cliente == null ? "Cliente Avulso" : pedido.Cliente.Nome;
                        txtDataPcote.Text = pedido.Data.ToString("dd/MM/yyyy");
                        txtDataInicioEntrega.Text = Convert.ToDateTime(pedido.DataHoraInicio).ToString("dd/MM/yyyy");
                        txtValorPacote.Text = Convert.ToDecimal(pedido.VlrTotalFinal).ToString("C");
                        txtObservacoesGeraies.Text = pedido.IsBloquearEntrega == true ? "Bloqueado para entrega até confirmação do cliente" : "";

                        txtDiasEntrega.Text = pedido.DiasEntrega == null ? Convert.ToDateTime(pedido.Data).ToString("dd/MM/yyyy dddddddddddddd") : pedido.DiasEntrega.ToUpper();

                        var itensPedido = db.ItensPedidos.Where(i => i.PedidoId == pedido.PedidoId).OrderBy(i => i.DataConsumo).ToList();

                        if (itensPedido.Count > 0)
                        {
                            foreach (var item in itensPedido)
                            {
                                lwItensPedidoTodos.Items.Add(item.ItensPedidoId.ToString());
                                lwItensPedidoTodos.Items[countItemTodos].SubItems.Add(item.Item.ToString());
                                lwItensPedidoTodos.Items[countItemTodos].SubItems.Add(item.Produto.Nome);
                                lwItensPedidoTodos.Items[countItemTodos].SubItems.Add(item.VlrUnitario.ToString("C"));

                                if (item.DataConsumo != null)
                                {
                                    lwItensPedidoTodos.Items[countItemTodos].SubItems.Add(Convert.ToDateTime(item.DataConsumo).ToString("dd/MM/yyyy dddddddddddddd"));
                                }

                                lwItensPedidoTodos.Items[countItemTodos].SubItems.Add("");

                                countItemTodos++;

                                if (item.IsConsumo == true)
                                {
                                    lwItensPedidoConsumido.Items.Add(item.ItensPedidoId.ToString());
                                    lwItensPedidoConsumido.Items[countItemConsumido].SubItems.Add(item.Item.ToString());
                                    lwItensPedidoConsumido.Items[countItemConsumido].SubItems.Add(item.Produto.Nome);
                                    lwItensPedidoConsumido.Items[countItemConsumido].SubItems.Add(item.VlrUnitario.ToString("C"));
                                    lwItensPedidoConsumido.Items[countItemConsumido].SubItems.Add(Convert.ToDateTime(item.DataConsumo).ToString("dd/MM/yyyy dddddddddddddd"));
                                    countItemConsumido++;
                                }
                                else
                                {
                                    lwItensPedidoNaoConsumido.Items.Add(item.ItensPedidoId.ToString());
                                    lwItensPedidoNaoConsumido.Items[countItemNaoConsumido].SubItems.Add(item.Item.ToString());
                                    lwItensPedidoNaoConsumido.Items[countItemNaoConsumido].SubItems.Add(item.Produto.Nome);
                                    lwItensPedidoNaoConsumido.Items[countItemNaoConsumido].SubItems.Add(item.VlrUnitario.ToString("C"));

                                    if (item.DataConsumo != null)
                                    {
                                        lwItensPedidoNaoConsumido.Items[countItemNaoConsumido].SubItems.Add(Convert.ToDateTime(item.DataConsumo).ToString("dd/MM/yyyy dddddddddddddd"));
                                    }
                                    else
                                    {
                                        lwItensPedidoNaoConsumido.Items[countItemNaoConsumido].SubItems.Add("");
                                    }
                                    countItemNaoConsumido++;
                                }
                            }

                            lblTotalItens.Text = "Total de item(s)  " + countItemTodos.ToString();
                            lblTotalItensConsumido.Text = "Total de item(s)  " + countItemConsumido.ToString();
                            lblTotalItensNaoConsumido.Text = "Total de item(s)  " + countItemNaoConsumido.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo de errado aconteceu (" + e.Message + ")", "Mensagem sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDetalharPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void alterarDataConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lwItensPedidoNaoConsumido.Items.Count > 0)
                {
                    int codigoItem = int.Parse(lwItensPedidoNaoConsumido.FocusedItem.SubItems[0].Text);

                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        var itemPedido = db.ItensPedidos.Find(codigoItem);

                        if (itemPedido != null)
                        {
                            if (itemPedido.IsConsumo != true)
                            {
                                frmEditarDataConsumoItemPedidoPcte frm = new frmEditarDataConsumoItemPedidoPcte();

                                frm.CarregaItemPedidoPacoteIditar(codigoItem);
                                frm.ShowDialog();
                                CarregaPedidoSelecioandoId(Convert.ToInt32(itemPedido.PedidoId));
                            }
                            else
                            {
                                MessageBox.Show("Data de consumo não pode ser alterada, uma vez \nque o mesmo já tenha sido consumido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data de consumo não pode ser alterada, uma vez \nque o mesmo já tenha sido consumido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fecharPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lwItensPedidoConsumido.Items.Count > 0)
                {
                    int codigoItem = int.Parse(lwItensPedidoConsumido.FocusedItem.SubItems[0].Text);

                    string situacaoAntiga, situacaoNova;

                    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                    {
                        var itemPedido = db.ItensPedidos.Find(codigoItem);

                        if (itemPedido != null)
                        {
                            if (itemPedido.DataConsumo != null)
                            {
                                if (itemPedido.IsConsumo == true)
                                {
                                    itemPedido.IsConsumo = false;
                                    situacaoAntiga = "Consumido";
                                    situacaoNova = "Não consumido";
                                }
                                else
                                {
                                    itemPedido.IsConsumo = true;
                                    situacaoAntiga = "Não consumido";
                                    situacaoNova = "Consumido";
                                }

                                if (MessageBox.Show("Confirma alterar situação do Pedido:  " + itemPedido.PedidoId + ", Item: " + codigoItem + "\n\nCliente: " + itemPedido.Pedido.Cliente.Nome + "\n\nde " + situacaoAntiga + " para " + situacaoNova + " ?", "Confirmação alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    db.SaveChanges();

                                    MessageBox.Show("situação do pedido alterado com sucesso", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    CarregaPedidoSelecioandoId(Convert.ToInt32(itemPedido.PedidoId));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Esta operação só pode ser realizado uma vez\nque o item já tenha sido consumido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esta operação só pode ser realizada uma vez\nque o item  não  tenha sido consumido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var pedido = db.Pedidos.Find(this.pedido.PedidoId);

                if (pedido.IsBloquearEntrega == true)
                {
                    if (MessageBox.Show("Confirma desativar a pausa é dar continuidade na entrega do pedido: " + Util.AdicionaZero(pedido.PedidoId.ToString()) + "\n\nCliente: " + pedido.Cliente.Nome, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pedido.IsBloquearEntrega = false;

                        pedido.DataRetornoEntregaPacote = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                        db.SaveChanges();

                        MessageBox.Show("Este pedido foi dado continuidade para entrega", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnPausar.Text = "Pausar entrega";

                        gbReativar.Visible = true;

                        thread = new Thread(() =>
                        {
                            //Código que será executado em paralelo ao resto do código
                            Util.AtualizarItensPedidosPcte(null);
                        });

                        //Inicia a execução da thread (em paralelo a esse código)
                        thread.Start();
                    }
                }
                else
                {
                    if (MessageBox.Show("Confirma pausar a entrega do pedido: " + Util.AdicionaZero(pedido.PedidoId.ToString()) + "\n\nCliente: " + pedido.Cliente.Nome, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pedido.IsBloquearEntrega = true;

                        if (ckReativar.Checked == true)
                        {
                            pedido.DataRetornoEntregaPacote = Convert.ToDateTime(txtDataRetorno.Value.ToString("dd/MM/yyyy"));
                        }
                        else
                        {
                            pedido.DataRetornoEntregaPacote = null;
                        }

                        db.SaveChanges();

                        MessageBox.Show("Este pedido foi pausado para entrega até a confirmação do cliente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnPausar.Text = "Ativar entrega";

                        gbReativar.Visible = false;
                    }
                }
            }

            CarregaPedidoSelecioandoId(this.pedido.PedidoId);
        }

        private void frmDetalharPedido_Load(object sender, EventArgs e)
        {
            if (pedido.IsBloquearEntrega == true)
            {
                btnPausar.Text = "Ativar entrega";
                gbReativar.Visible = false;
            }
            else
            {
                btnPausar.Text = "Pausar entrega";
                gbReativar.Visible = true;
            }
        }

        private void ckReativar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckReativar.Checked == true)
            {
                txtDataRetorno.Enabled = true;
                txtDataRetorno.Focus();
            }
            else
            {
                txtDataRetorno.Enabled = false;
            }
        }
    }
}




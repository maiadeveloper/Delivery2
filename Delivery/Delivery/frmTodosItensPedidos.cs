using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmTodosItensPedidos : Form
    {
        //private Thread thread;
        int count = 0;
        decimal valorTotal = 0;

        public frmTodosItensPedidos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaListagemPedidos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                List<ItensPedido> itensPedidos = new List<ItensPedido>();

                lwItensPedidos.Items.Clear();
                ckSelecionar.Checked = false;
                count = 0;
                valorTotal = 0;
                lwItensPedidos.SmallImageList = imageList1;
                txtTotalConsumido.Clear();
                txtTotalGeral.Clear();
                txtTotalNaoConsumido.Clear();
                decimal totalNaoConsumido = 0;
                decimal totalConsumido = 0;

                DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
                DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

                if (cbProdutos.Text.Equals("TODOS"))
                {
                    if (txtSituacaoIsConsumido.Text.Equals("CONSUMIDO"))//Somente consumido
                    {
                        itensPedidos = db.ItensPedidos.AsNoTracking().Where(i => i.DataConsumo >= dtInicial
                                                                               && i.DataConsumo <= dtFinal
                                                                               && i.Pedido.IsExcluir == false
                                                                               && i.IsConsumo == true
                                                                               && i.Pedido.IsBloquearEntrega == false
                                                                               && i.Pedido.Cliente.Nome.Contains(txtParametroBusca.Text)).OrderBy(i => i.DataConsumo).OrderBy(i => i.ProdutoId).ToList();
                    }
                    else if (txtSituacaoIsConsumido.Text.Equals("NÃO CONSUMIDO"))//Não consumido
                    {
                        itensPedidos = db.ItensPedidos.AsNoTracking().Where(i => i.DataConsumo >= dtInicial
                                                          && i.DataConsumo <= dtFinal
                                                          && i.IsConsumo == false
                                                          && i.Pedido.IsExcluir == false
                                                          && i.Pedido.IsBloquearEntrega == false
                                                          && i.Pedido.Cliente.Nome.Contains(txtParametroBusca.Text)).OrderBy(i => i.DataConsumo).OrderBy(i => i.ProdutoId).ToList();
                    }
                    else//Todos, consumido, nao consumido
                    {
                        itensPedidos = db.ItensPedidos.AsNoTracking().Where(i => i.DataConsumo >= dtInicial
                                                          && i.DataConsumo <= dtFinal
                                                          && i.Pedido.IsExcluir == false
                                                          && i.Pedido.IsBloquearEntrega == false
                                                          && i.Pedido.Cliente.Nome.Contains(txtParametroBusca.Text)).OrderBy(i => i.DataConsumo).OrderBy(i => i.ProdutoId).ToList();
                    }

                    if (itensPedidos.Count != 0)
                    {
                        lwItensPedidos.Visible = true;
                        btnMensagem.Visible = false;

                        foreach (var itemPedido in itensPedidos)
                        {

                            if (itemPedido.Pedido.IsPcte == true)
                            {
                                lwItensPedidos.Items.Add("", 0);
                            }
                            else
                            {
                                lwItensPedidos.Items.Add("", 1);
                            }

                            if (itemPedido.IsConsumo == true)
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.Red;
                                totalConsumido += itemPedido.SubTotal;
                            }
                            else if (itemPedido.IsPctItem == true)
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.Green;
                                totalNaoConsumido += itemPedido.SubTotal;
                            }

                            lwItensPedidos.Items[count].SubItems.Add(AdicionaZero(itemPedido.PedidoId.ToString()));
                            lwItensPedidos.Items[count].SubItems.Add(Convert.ToDateTime(itemPedido.Pedido.Data).ToString("dd/MM/yyyy dddddddddddddd"));
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.ItensPedidoId.ToString());
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Item.ToString());
                            lwItensPedidos.Items[count].SubItems.Add(Convert.ToDateTime(itemPedido.DataConsumo).ToString("dd/MM/yyyy dddddddddddddd"));

                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Pedido.ClienteId == null ? "000.000.000-00" : itemPedido.Pedido.Cliente.Documento);
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Pedido.ClienteId == null ? "CLIENTE AVULSO" : itemPedido.Pedido.Cliente.Nome);


                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.ProdutoId.ToString());
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Produto.Nome.ToString());

                            if (itemPedido.Pedido.ClienteId != null)
                            {
                                var restricoes = db.Restricoes.Where(r => r.ClienteId == itemPedido.Pedido.Cliente.ClienteId && r.ProdutoId == itemPedido.ProdutoId).FirstOrDefault();
                                lwItensPedidos.Items[count].SubItems.Add(restricoes != null ? restricoes.Descricao : "");
                            }

                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.SubTotal.ToString("C"));

                            if (Util.AlertaUltimoItemPacote(Convert.ToInt32(itemPedido.PedidoId), itemPedido.ProdutoId))
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.DarkOrange;
                            }

                            valorTotal += Convert.ToDecimal(itemPedido.SubTotal);
                            count++;
                        }

                        txtQtdeItem.Text = lwItensPedidos.Items.Count.ToString();
                        txtTotalGeral.Text = valorTotal.ToString("C");
                        txtTotalNaoConsumido.Text = totalNaoConsumido.ToString("C");
                        txtTotalConsumido.Text = totalConsumido.ToString("C");
                    }

                    else
                    {
                        lwItensPedidos.Visible = false;
                        btnMensagem.Visible = true;
                    }
                }
                else
                {
                    int codProdutoSelecinado = Convert.ToInt32(cbProdutos.SelectedValue);

                    if (txtSituacaoIsConsumido.Text.Equals("CONSUMIDO"))//Somente consumido
                    {
                        itensPedidos = db.ItensPedidos.AsNoTracking().Where(i => i.DataConsumo >= dtInicial
                                                                               && i.DataConsumo <= dtFinal
                                                                               && i.Pedido.IsExcluir == false
                                                                               && i.IsConsumo == true
                                                                               && i.Pedido.IsBloquearEntrega == false
                                                                               && i.ProdutoId == codProdutoSelecinado
                                                                               && i.Pedido.Cliente.Nome.Contains(txtParametroBusca.Text) || i.PedidoId.ToString() == txtParametroBusca.Text).OrderBy(i => i.DataConsumo).OrderBy(i => i.ProdutoId).ToList();
                    }
                    else if (txtSituacaoIsConsumido.Text.Equals("NÃO CONSUMIDO"))//Não consumido
                    {
                        itensPedidos = db.ItensPedidos.AsNoTracking().Where(i => i.DataConsumo >= dtInicial
                                                           && i.DataConsumo <= dtFinal
                                                           && i.IsConsumo == false
                                                           && i.Pedido.IsBloquearEntrega == false
                                                           && i.ProdutoId == codProdutoSelecinado
                                                           && i.Pedido.IsExcluir == false
                                                           && i.Pedido.Cliente.Nome.Contains(txtParametroBusca.Text) || i.PedidoId.ToString() == txtParametroBusca.Text).OrderBy(i => i.DataConsumo).OrderBy(i => i.ProdutoId).ToList();
                    }
                    else//Todos, consumido, nao consumido
                    {
                        itensPedidos = db.ItensPedidos.AsNoTracking().Where(i => i.DataConsumo >= dtInicial
                                                           && i.DataConsumo <= dtFinal
                                                           && i.ProdutoId == codProdutoSelecinado
                                                           && i.Pedido.IsBloquearEntrega == false
                                                           && i.Pedido.IsExcluir == false
                                                           && i.Pedido.Cliente.Nome.Contains(txtParametroBusca.Text) || i.PedidoId.ToString() == txtParametroBusca.Text).OrderBy(i => i.DataConsumo).OrderBy(i => i.ProdutoId).ToList();
                    }

                    if (itensPedidos.Count != 0)
                    {
                        lwItensPedidos.Visible = true;
                        btnMensagem.Visible = false;

                        foreach (var itemPedido in itensPedidos)
                        {

                            if (itemPedido.Pedido.IsPcte == true)
                            {
                                lwItensPedidos.Items.Add("", 0);
                            }
                            else
                            {
                                lwItensPedidos.Items.Add("", 1);
                            }


                            if (itemPedido.IsConsumo == true)
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.Red;
                                totalConsumido += itemPedido.VlrUnitario;
                            }
                            else if (itemPedido.IsPctItem == true)
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                lwItensPedidos.Items[count].ForeColor = System.Drawing.Color.Green;
                                totalNaoConsumido += itemPedido.VlrUnitario;
                            }


                            lwItensPedidos.Items[count].SubItems.Add(AdicionaZero(itemPedido.PedidoId.ToString()));
                            lwItensPedidos.Items[count].SubItems.Add(Convert.ToDateTime(itemPedido.Pedido.Data).ToString("dd/MM/yyyy dddddddddddddd"));
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.ItensPedidoId.ToString());
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Item.ToString());
                            lwItensPedidos.Items[count].SubItems.Add(Convert.ToDateTime(itemPedido.DataConsumo).ToString("dd/MM/yyyy dddddddddddddd"));
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Pedido.ClienteId == null ? "000.000.000-00" : itemPedido.Pedido.Cliente.Documento);
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Pedido.ClienteId == null ? "CLIENTE AVULSO" : itemPedido.Pedido.Cliente.Nome);
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.ProdutoId.ToString());
                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.Produto.Nome.ToString());

                            var restricoes = db.Restricoes.Where(r => r.ClienteId == itemPedido.Pedido.Cliente.ClienteId && r.ProdutoId == itemPedido.ProdutoId).FirstOrDefault();

                            lwItensPedidos.Items[count].SubItems.Add(restricoes != null ? restricoes.Descricao : "");

                            lwItensPedidos.Items[count].SubItems.Add(itemPedido.SubTotal.ToString("C"));

                            valorTotal += Convert.ToDecimal(itemPedido.VlrUnitario);
                            count++;
                        }

                        txtQtdeItem.Text = lwItensPedidos.Items.Count.ToString();
                        txtTotalGeral.Text = valorTotal.ToString("C");
                        txtTotalNaoConsumido.Text = totalNaoConsumido.ToString("C");
                        txtTotalConsumido.Text = totalConsumido.ToString("C");
                    }

                    else
                    {
                        lwItensPedidos.Visible = false;
                        btnMensagem.Visible = true;
                    }
                }
            }
        }

        private void txtParametroBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaListagemPedidos();
        }

        private void frmTodosItensPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                txtParametroBusca.Focus();
                txtSituacaoIsConsumido.SelectedIndex = 0;
                CarregaListagemPedidos();
                CarregaComboProdutos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção usuário!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ckSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (lwItensPedidos.Items.Count > 0)
            {
                if (ckSelecionar.Checked == true)
                {
                    for (int i = 0; i < lwItensPedidos.Items.Count; i++)
                    {
                        lwItensPedidos.Items[i].Checked = true;
                    }
                }
                else
                {
                    for (int i = 0; i < lwItensPedidos.Items.Count; i++)
                    {
                        lwItensPedidos.Items[i].Checked = false;
                    }
                }
            }
        }

        private void btnGerarEtiquetas_Click(object sender, EventArgs e)
        {
            if (lwItensPedidos.Items.Count > 0)
            {
                List<int> pedidos = new List<int>();

                int contador = 0;
                int linha = 0;

                for (int i = 0; i < lwItensPedidos.Items.Count; i++)
                {
                    if (lwItensPedidos.Items[contador].Checked == true)
                    {
                        if (lwItensPedidos.Items[contador].SubItems[4].Text.Trim() != "CLIENTE AVULSO".Trim())
                        {
                            pedidos.Add(Convert.ToInt32(lwItensPedidos.Items[contador].SubItems[3].Text));
                            linha++;
                        }
                    }
                    contador++;
                }

                if (pedidos.Count != 0)
                {
                    if (MessageBox.Show("Confirma a confecção da(s) etiqueta(s) referente ao(s) item(s) selecionado(s)?\n\nNúmero de etiqueta(s) a confeccionar:  " + linha, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (frmBaseEtiquetas frm = new frmBaseEtiquetas())
                        {
                            Thread t = new Thread(Util.ExibeLoadCep);
                            t.Start();

                            AlterarStatusItemsConsumido(pedidos);
                            //FinalizaEntregaPedidoPacote(pedidos);
                            frm.ElaborarEtiquetas(pedidos);
                            frm.ShowDialog();
                            CarregaListagemPedidos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione ao menos um pedido", "Atenção usuário!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaListagemPedidos();
            CarregaComboProdutos();
        }

        private void AlterarStatusItemsConsumido(List<int> pedidos)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                if (pedidos.Count > 0)
                {
                    foreach (var idItemPedido in pedidos)
                    {
                        var itemPedido = db.ItensPedidos.Find(idItemPedido);

                        if (itemPedido != null)
                        {
                            if (itemPedido.IsConsumo != true)
                            {
                                itemPedido.IsConsumo = true;
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
        }

        //Método esta em observação 02/11/2020
        //private void FinalizaEntregaPedidoPacote(List<int> pedidos)
        //{
        //    using (MyDataContextConfiguration db = new MyDataContextConfiguration())
        //    {
        //        foreach (var item in pedidos)
        //        {
        //            var itemPedido = db.ItensPedidos.Find(item);

        //            if (Util.RetornaUltimoItemPacote(Convert.ToInt32(itemPedido.PedidoId)) == 0)
        //            {
        //                var pedido = db.Pedidos.Find(itemPedido.PedidoId);

        //                pedido.IsBloquearEntrega = true;

        //                db.SaveChanges();
        //            }
        //        }
        //    }
        //}

        private void frmTodosItensPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaListagemPedidos();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtSituacaoIsConsumido_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaListagemPedidos();
        }

        private void fecharPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwItensPedidos.Items.Count > 0)
            {
                int codigoItem = int.Parse(lwItensPedidos.FocusedItem.SubItems[3].Text);
                string situacaoAntiga, situacaoNova;

                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var itemPedido = db.ItensPedidos.Find(codigoItem);

                    if (itemPedido != null)
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

                            CarregaListagemPedidos();
                        }
                    }
                }
            }
        }

        private void alterarDataConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwItensPedidos.Items.Count > 0)
            {
                int codigoItem = int.Parse(lwItensPedidos.FocusedItem.SubItems[3].Text);

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

                            CarregaListagemPedidos();
                        }
                        else
                        {
                            MessageBox.Show("Data de consumo não pode ser alterada, uma vez \nque o mesmo já tenha sido consumido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


        private void CarregaComboProdutos()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var produtos = db.Produtos.ToList();

                if (produtos.Count > 0)
                {
                    cbProdutos.DataSource = produtos.ToList();
                    cbProdutos.ValueMember = "ProdutoId";
                    cbProdutos.DisplayMember = "Nome";
                    cbProdutos.Text = "TODOS";
                }
            }
        }
    }
}

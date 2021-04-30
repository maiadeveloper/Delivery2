using Delivery.DataContext;
using Delivery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public static class GenericDelivery
    {
        public static int? IsBancoContaCorrenteExist()
        {
            int? contaCorrenteId = null;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var banco = db.Bancos.Where(b => b.Descricao.Equals("CAIXA EMPRESA")).FirstOrDefault();

                if (banco != null)
                {
                    var contaCorrente = db.ContaCorrentes.Where(c => c.BancoId.Equals(banco.BancoId)).FirstOrDefault();

                    if (contaCorrente != null)
                    {
                        contaCorrenteId = contaCorrente.ContaCorrenteId;
                    }
                    else
                    {
                        contaCorrenteId = null;
                    }
                }

                return contaCorrenteId;
            }
        }


        public static bool VerificarCaixaIsAbertoOperacoesDiversas(DateTime data)
        {
            bool situacao = false;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                DateTime dataAtual = Convert.ToDateTime(data.ToString("dd/MM/yyyy"));

                var caixa = db.Caixa.Where(c => c.DataAbertura == dataAtual).FirstOrDefault();

                if (caixa != null)
                {
                    if (caixa.Situacao == true)
                    {
                        situacao = true;
                    }
                }
            }

            return situacao;
        }


        public static bool VerificarCaixaIsAbertoOperacoesDiversas()
        {
            bool situacao = false;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                var caixa = db.Caixa.Where(c => c.DataAbertura == dataAtual).FirstOrDefault();

                if (caixa != null)
                {
                    if (caixa.Situacao == true)
                    {
                        situacao = true;
                    }
                }
            }

            return situacao;
        }

        public static bool VerificarCaixaIsAberto()
        {
            bool situacao = false;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                var caixa = db.Caixa.Where(c => c.DataAbertura == dataAtual).FirstOrDefault();

                if (caixa != null)
                {
                    MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data ja foi aberto.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    situacao = true;
                }
            }

            return situacao;
        }

        public static void RealizarMovimentacaoContaCorrenteAtualizarSaldoContaCorrente(int? contaCorrenteId, DateTime dataMov, decimal valor, string tipoMov)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                MovimentacaoContaCorrente mc = new MovimentacaoContaCorrente();

                mc.DataHoraMovimentacao = dataMov;
                mc.ContaCorrenteId = contaCorrenteId;
                mc.Valor = valor;
                mc.TipoMovimentacao = tipoMov;

                db.MovimentacoesContaCorrentes.Add(mc);

                var movimentacao = db.ContaCorrentes.Find(contaCorrenteId);

                if (movimentacao != null)
                {
                    if (tipoMov.Equals("CREDITO"))
                    {
                        movimentacao.Saldo += valor;
                    }
                    else
                    {
                        movimentacao.Saldo -= valor;
                    }
                }

                db.SaveChanges();
            }
        }

        public static bool VerificarCaixaAbertoOrFechadoDataAtual()
        {
            bool situacao = false;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                var caixa = db.Caixa.Where(c => c.DataAbertura == dataAtual).FirstOrDefault();

                if (caixa != null)
                {
                    if (caixa.Situacao == true)
                    {
                        MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data encontra-se aberto.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        situacao = true;
                    }
                    else
                    {
                        MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data encontra-se fechado.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        situacao = false;
                    }
                }
            }

            return situacao;
        }

        public static bool VerificarCaixaAbertoOrFechado(int caixaId)
        {
            bool situacao = false;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {

                var caixa = db.Caixa.Where(c => c.CaixaId == caixaId).FirstOrDefault();

                if (caixa != null)
                {
                    if (caixa.Situacao == true)
                    {
                        MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data encontra-se aberto.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        situacao = true;
                    }
                    else
                    {
                        MessageBox.Show(" Operação não pode ser realizada. O caixa para\n esta data encontra-se fechado.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        situacao = false;
                    }
                }
            }

            return situacao;
        }

        public static bool VerificarCaixaAbertoDiaAnterior()
        {
            bool situacao = false;

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {

                var caixa = db.Caixa.Where(c => c.Situacao == true).FirstOrDefault(); ;

                if (caixa != null)
                {
                    if (caixa.Situacao == true)
                    {
                        MessageBox.Show(" Operação não pode ser realizada. O caixa referente ao dia " + Convert.ToDateTime(caixa.DataAbertura).ToString("dd/MM/yyyy") + " encontra-se aberto.\n\nFavor fechar o caixa antes de abrir um novo caixa.", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        situacao = true;
                    }
                }
            }

            return situacao;
        }

        public static String RetornaDiaAtual(string dias)
        {
            string resultado = string.Empty;

            switch (dias)
            {
                case "domingo":
                    resultado = "Sunday";
                    break;
                case "segunda":
                    resultado = "Monday";
                    break;
                case "terça":
                    resultado = "Tuesday";
                    break;
                case "quarta":
                    resultado = "Wednesday";
                    break;
                case "quinta":
                    resultado = "Thursday";
                    break;
                case "sexta":
                    resultado = "Friday";
                    break;
                case "sabado":
                    resultado = "Saturday";
                    break;
            }

            return resultado;
        }

        //Método carrega informações referente ao versão - build do sistema
        public static string CarregaBuildSistema()
        {
            Sistema sistema = new Sistema();

            sistema.VersaoBuild = "12.05.2020";
            sistema.DataBuild = Convert.ToDateTime("12-05-2020");

            return string.Format("Data atualização: {0} | Build: {1}", sistema.DataBuild, sistema.VersaoBuild);
        }

        public static string AdicionaZero(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }

        public static int AlertaUltimoItemPacote(int pedidoId)
        {
            int qtdeAtual = 0;

            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    var itemPedido = db.ItensPedidos.AsNoTracking().Where(item => item.PedidoId == pedidoId && item.Pedido.IsPcte == true).ToList();

                    if (itemPedido.Count > 0)
                    {
                        var itemPedidoConsumido = db.ItensPedidos.AsNoTracking().Where(item => item.PedidoId == pedidoId && item.IsConsumo == true && item.Pedido.IsPcte == true).ToList();

                        qtdeAtual = itemPedido.Count - itemPedidoConsumido.Count;
                    }
                }
            }
            catch (Exception error)
            {
                string mensagem = error.Message;
            }

            return qtdeAtual;
        }

        public static void AtualizarItensPedidosPcte()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                //Armazena codigo do produto selecionado para comparação futura
                int codProdutoSelecionado = 0;
                
                //Pega data atual
                DateTime dtHoje = DateTime.Now;

                //Usado para receber data de entrega vindo do banco
                string diaEntrega = string.Empty;

                //Usado para identificar se item sera atualizad
                bool atualiza = false;

                //Pega todos os pedidos que forem relacionado a pcte
                var listaPedidos = db.Pedidos.AsNoTracking().Where(p => 
                                                        p.IsPcte == true && 
                                                        p.DiasEntrega != null && 
                                                        p.IsBloquearEntrega == false).ToList();

                //Verifica se a lista de pedidos e maior que 0
                if (listaPedidos.Count > 0)
                {
                    //Percorrer lista de PEDIDOS pcte
                    foreach (var pedido in listaPedidos)
                    {
                        if ((pedido.DataHoraInicio == dtHoje) || (pedido.DataHoraInicio < dtHoje))
                        {
                            //Separa os dias de entrega para comparar com data atual
                            string[] diasEntrega = pedido.DiasEntrega.ToString().Split(',');

                            //Pecorrer os dias de entrega ate encontrar o dia atual
                            for (int i = 0; i < diasEntrega.Count(); i++)
                            {
                                //Retorna data atual no formato americano para ser usado na comparação com data do sistema
                                diaEntrega = GenericDelivery.RetornaDiaAtual(diasEntrega[i]);

                                //Verifica dia da semana e igual a dia de entrega selecionado para o dia corrente
                                if (dtHoje.DayOfWeek.ToString() == diaEntrega)
                                {
                                    //Lista todos os itens relacionado ao pedido pcte 
                                    var listaItensPedido = db.ItensPedidos.AsNoTracking().Where(it => it.PedidoId == pedido.PedidoId).ToList();

                                    //Percorrer lista de itens pedido referente ao PEDIDO
                                    //Caso encontre algum item que ja tenha sido alterado nessa data ele -
                                    //Nao atualiza a variavel -atualizar-
                                    foreach (var item in listaItensPedido)
                                    {
                                        DateTime dtConsumo = Convert.ToDateTime(item.DataConsumo);

                                        if (dtHoje.ToString("dd/MM/yyyy") == dtConsumo.ToString("dd/MM/yyyy"))
                                        {
                                            atualiza = false;
                                            break;
                                        }
                                        else
                                        {
                                            atualiza = true;
                                        }
                                    }

                                    //Caso seja igual a verdadeiro percorre novamente a lista
                                    if (atualiza == true)
                                    {
                                        foreach (var itemPedido in listaItensPedido)
                                        {
                                            //Caso ainda não tenha sido atualizado
                                            if ((codProdutoSelecionado == 0) || (codProdutoSelecionado != itemPedido.ProdutoId))
                                            {
                                                if (itemPedido.IsChecked != true)
                                                {
                                                    var atualizaItemPedido = db.ItensPedidos.Find(itemPedido.ItensPedidoId);

                                                    atualizaItemPedido.IsChecked = true;
                                                    atualizaItemPedido.DataConsumo = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                                                    db.SaveChanges();
                                                }
                                            }
                                            codProdutoSelecionado = itemPedido.ProdutoId;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

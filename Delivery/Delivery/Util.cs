using Delivery.DataContext;
using Delivery.Model;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Delivery
{
    public static class Util
    {
        public static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        public static string FormatarDocumento(string tipo, string documento)
        {
            return tipo.Equals("cpf") ? Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00") : Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00");
        }

        public static void RealizarBackup()
        {
            var filePath = (@"C:\Backups\DBDelivery.bak");

            try
            {
                var sc = new ServerConnection(RetornaServidorBanco(), "sa", RetornaSenhaBancoBackup());
                var server = new Server(sc);

                if (server.Databases["DBDelivery"] != null)
                {
                    //Criando o diretorio do Backup
                    if (!Directory.Exists(@"C:\Backups"))
                    {
                        Directory.CreateDirectory(@"C:\Backups");
                    }

                    // Criando o objeto Backup
                    var bak = new Backup();
                    bak.Incremental = false;

                    bak.Action = BackupActionType.Database;
                    string data = DateTime.Now.Date.ToString("dd-MM-yyyy");
                    bak.BackupSetName = "DBDelivery" + data;

                    // Definindo o banco de dados a ser salvo
                    bak.Database = "DBDelivery";

                    bak.Checksum = true;

                    // Adcionando um destino para o backup
                    bak.Devices.Add(new BackupDeviceItem(filePath, DeviceType.File));

                    // Executando o backup
                    bak.SqlBackup(server);

                    if (MessageBox.Show("Backup da base de dados foi gerado com sucesso.\nCaso queira salvar o arquivo em uma mídia diferente, basta\n acessar o caminho abaixo.\n\n\n" + filePath + "\n\n\nDeseja acessar agora ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(@"C:\Backups\");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n\n Favor entrar em contato com o administrador do sistema.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RealizarBackupSMO()
        {
            try
            {
                var servidor = new ServerConnection(RetornaServidorBanco(), "sa", RetornaSenhaBancoBackup());
                //string servidor = "LUISMAIA";
                string baseDados = "DBDelivery";
                string nomeArquivoBackup = string.Format("C:\\backup\\{0}_{1:yyyyMMdd_HHmmss}.bak", baseDados, DateTime.Now);

                var server = new Microsoft.SqlServer.Management.Smo.Server(servidor);
                var backup = new Microsoft.SqlServer.Management.Smo.Backup();
                backup.Database = baseDados;
                backup.Incremental = false;

                backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
                backup.SqlBackup(server);

                MessageBox.Show(string.Format("Backup '{0}' concluído com sucesso.", nomeArquivoBackup), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception msg)
            {
                MessageBox.Show("Atenção! " + msg.Message + "", "Mensagem de Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ZiparBackup()
        {
            string diretorio = @"C:\Backups";//Caminho do diretório
            string arquivo = @"C:\Backups\DBDelivery.rar";//Caminho do arquivo zip a ser criado
            ZipFile.CreateFromDirectory(diretorio, arquivo);
        }

        public static void ExibeLoadCep()
        {
            frmLoadGeral frm = new frmLoadGeral();
            frm.ShowDialog();
        }

        public static string GerarMD5(string chave)
        {
            // Cria uma nova intância do objeto que implementa o algoritmo para
            // criptografia MD5
            MD5 md5Hasher = MD5.Create();

            // Criptografa o valor passado
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(chave));

            // Cria um StringBuilder para passarmos os bytes gerados para ele
            StringBuilder strBuilder = new StringBuilder();

            // Converte cada byte em um valor hexadecimal e adiciona ao
            // string builder
            // and format each one as a hexadecimal string.
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));
            }

            // retorna o valor criptografado como string
            return strBuilder.ToString();
        }

        public static Boolean ValidarSistema()
        {
            bool result = false;

            int counter = 0;
            string line;
            DateTime mesAtual = DateTime.Now;
            DateTime anoAtual = DateTime.Now;

            string chaveAcesso = mesAtual.Month + ";" + anoAtual.Year;
            chaveAcesso = GerarMD5(chaveAcesso);
            string nomeArquivo = "71460912916787b3efe7ef82308f85a5";

            System.IO.StreamReader file = new System.IO.StreamReader(exeLocation + @"\" + nomeArquivo + ".txt");

            while ((line = file.ReadLine()) != null)
            {
                if (chaveAcesso == line)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }

                counter++;
            }

            file.Close();
            return result;
        }

        public static string RetornaSenhaBancoBackup()
        {
            string result = string.Empty;
            string line;
            string nomeArquivo = "81460912916787b3efe7ef82308f85a5";

            System.IO.StreamReader file = new System.IO.StreamReader(exeLocation + @"\" + nomeArquivo + ".txt");

            while ((line = file.ReadLine()) != null)
            {
                result = line;
                break;
            }

            file.Close();
            return result;
        }

        public static string RetornaServidorBanco()
        {
            string result = string.Empty;
            string line;
            string nomeArquivo = "91460912916787b3efe7ef82308f85a5";

            System.IO.StreamReader file = new System.IO.StreamReader(exeLocation + @"\" + nomeArquivo + ".txt");

            while ((line = file.ReadLine()) != null)
            {
                result = line;
                break;
            }

            file.Close();
            return result;
        }

        public static void EscreverChaveLicenca(string chave)
        {
            //cria o arquivo txt para um determinado diretorio
            string nomeArquivo = "71460912916787b3efe7ef82308f85a5";
            FileInfo arquivo = new FileInfo(Util.exeLocation + @"\" + nomeArquivo + ".txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = { chave };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(Util.exeLocation + @"\" + nomeArquivo + ".txt", texto);
        }

        public static void ExportarDadosClientes(bool nome, bool celular, bool email)
        {
            try
            {
                using (MyDataContextConfiguration db = new MyDataContextConfiguration())
                {
                    //cria o arquivo txt para um determinado diretorio
                    FileInfo arquivo = new FileInfo(Util.exeLocation + "\\Exportar\\ExportarDadosCliente.csv");

                    using (FileStream fs = arquivo.Create()) { }

                    StringBuilder conteudo = new StringBuilder();

                    var clientes = db.Clientes.OrderBy(c => c.Nome).ToList();

                    foreach (var cliente in clientes)
                    {
                        if (nome == true && celular == true && email == true)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Nome;Celular;Email" : cliente.Nome + ";" + cliente.Celular + ";" + cliente.Email);
                        }

                        else if (nome == true && celular == true && email == false)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Nome;Celular" : cliente.Nome + ";" + cliente.Celular);
                        }

                        else if (nome == true && celular == false && email == true)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Nome;Email" : cliente.Nome + ";" + cliente.Email);
                        }

                        else if (nome == true && celular == false && email == false)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Nome" : cliente.Nome);
                        }

                        else if (nome == false && celular == true && email == true)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Celular;Email" : cliente.Celular + ";" + cliente.Email);
                        }

                        else if (nome == false && celular == false && email == true)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Email" : cliente.Email);
                        }

                        else if (nome == false && celular == true && email == false)
                        {
                            conteudo.AppendLine(conteudo.Length == 0 ? "Celular" : cliente.Celular);
                        }
                    }

                    //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
                    string[] texto = { conteudo.ToString() };

                    //Escreve as informações no arquivo txt, salvo no diretorio expecificado
                    File.WriteAllLines(Util.exeLocation + "\\Exportar\\ExportarDadosCliente.csv", texto);

                    MessageBox.Show("Exportação realizada com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(Util.exeLocation + "\\Exportar\\ExportarDadosCliente.csv");

                    conteudo.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Feche o arquivo anterior antes de gera um novo", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static void EnviarEmail()
        {
            //Enviar email para conta
            MailMessage mail = new MailMessage();

            mail.To.Add("luisantoniopvh@hotmail.com");//Quem vai receber o e-mail
            mail.From = new MailAddress("luismaia.pvh@gmail.com");//Quem esta enviando o e-mail
            mail.Subject = "Confirmação de backup-delivery";//Assunto do e-mail
            StringBuilder body = new StringBuilder();

            body.Append("<br />");
            body.Append("Um backup foi realizado!");
            body.Append("Data e hora do backup: " + DateTime.Now);
            body.Append("<br />");
            body.Append("<br />");

            mail.Body = body.ToString();

            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("luismaia.pvh@gmail.com", "rmaienroimtddvkm");
            smtp.EnableSsl = true;

            //Anexo arquivo
            //Attachment anexo = new Attachment(@"C:\Backups\Anexo.txt");
            //mail.Attachments.Add(anexo);

            smtp.Send(mail);
        }

        public static List<string> ExibirListagemImpressoras()
        {
            List<string> impressoras = new List<string>();

            impressoras.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                impressoras.Add(printer.ToString());
            }

            return impressoras;
        }

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

            //versão Maior(MAJOR): quando fizer mudanças incompatíveis na API,
            int major = 3;

            //versão Menor(MINOR): quando adicionar funcionalidades mantendo compatibilidade, e
            int minor = 10;

            //versão de Correção(PATCH): quando corrigir falhas mantendo compatibilidade.
            int patch = 17;

            sistema.VersaoBuild = major.ToString() + "." + minor.ToString() + "." + patch.ToString();

            sistema.DataBuild = Convert.ToDateTime("20-11-2021");

            return string.Format("Última atualização: {0} | Versão: {1} ", sistema.DataBuild.ToString("dd/MM/yyyy"), sistema.VersaoBuild);
        }

        public static string AdicionaZero(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }


        public static bool AlertaUltimoItemPacote(int pedidoId, int produtoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var resultado = db.ItensPedidos.AsNoTracking().Where(item => item.PedidoId == pedidoId
                                                                            && item.Pedido.IsPcte == true
                                                                            && item.ProdutoId == produtoId
                                                                            && item.IsConsumo == false).Count();
                return resultado == 1 ? true : false;
            }
        }

        public static int RetornaUltimoItemPacote(int pedidoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var resultado = db.ItensPedidos.AsNoTracking().Where(item =>
                                                                     item.PedidoId == pedidoId &&
                                                                     item.Pedido.IsPcte == true &&
                                                                     item.IsConsumo == false).Count();
                return resultado;
            }
        }

        public static void AtualizarItensPedidosPcte(int? pedidoId)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                //Pega data atual
                DateTime dtHoje = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                //Usado para receber data de entrega vindo do banco
                string diaEntrega = string.Empty;

                //Pega todos os pedidos que forem relacionado a pcte
                List<Pedido> listaPedidos = new List<Pedido>();

                if (pedidoId == null)
                {
                    listaPedidos = db.Pedidos.AsNoTracking().Where(p => p.IsPcte == true && p.DiasEntrega != null && p.IsBloquearEntrega == false).ToList();
                }
                else
                {
                    listaPedidos = db.Pedidos.AsNoTracking().Where(p => p.IsPcte == true && p.DiasEntrega != null && p.IsBloquearEntrega == false && p.PedidoId == pedidoId).ToList();
                }

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
                                diaEntrega = RetornaDiaAtual(diasEntrega[i]);

                                //Verifica dia da semana e igual a dia de entrega selecionado para o dia corrente
                                if (dtHoje.DayOfWeek.ToString() == diaEntrega)
                                {
                                    //Lista todos os itens relacionado ao pedido pcte 
                                    var listaItensPedido = db.ItensPedidos.AsNoTracking().Where(it => it.PedidoId == pedido.PedidoId &&
                                                                                                                        it.DataConsumo == dtHoje).ToList();
                                    if (listaItensPedido.Count == 0)
                                    {
                                        //Lista todos os itens relacionado ao pedido pcte 
                                        var listaItensPedidoAtualizar = db.ItensPedidos.AsNoTracking().Where(it => it.PedidoId == pedido.PedidoId
                                                                                                  && it.IsConsumo == false && it.IsChecked == false).ToList();

                                        //Variável utilizada pra controlar qual item já foi atualizado.
                                        int? produtoId = null;

                                        //Percorrer lista de itens pedido referente ao PEDIDO
                                        //Caso encontre algum item que ja tenha sido alterado nessa data ele -
                                        //Nao atualiza a variavel -atualizar-
                                        foreach (var item in listaItensPedidoAtualizar)
                                        {
                                            DateTime dtConsumo = Convert.ToDateTime(item.DataConsumo);

                                            if ((dtHoje != dtConsumo && item.ProdutoId != produtoId))
                                            {
                                                var atualizaItemPedido = db.ItensPedidos.Find(item.ItensPedidoId);

                                                atualizaItemPedido.IsChecked = true;
                                                atualizaItemPedido.DataConsumo = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                                                db.SaveChanges();
                                            }
                                            produtoId = item.ProdutoId;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void GerarArquivoTxtComprovanteVenda(string tipoPcte, int? codigoPedido, int? codigoCliente, decimal? valorPagamento, decimal? valorTroco)
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                //Carrega dados da empresa
                var empresa = db.Empresas.OrderByDescending(e => e.EmpresaId).FirstOrDefault();

                //Carrega dados do pedido
                var pedido = db.Pedidos.Find(codigoPedido);

                var endereco = db.Enderecos.Where(e => e.ClienteId == pedido.ClienteId && e.IsEnderecoEntrega == true).FirstOrDefault();

                tipoPcte = tipoPcte == "comum" ? "COMUM" : "PACOTE";

                if (empresa != null)
                {
                    var cliente = db.Clientes.Where(c => c.ClienteId == pedido.ClienteId).FirstOrDefault();

                    string nomeCliente = codigoCliente == null ? "VENDA AVULSA" : cliente.Nome;

                    string documentoCliente = codigoCliente == null ? "" : cliente.Documento;

                    string celular = codigoCliente == null ? "" : cliente.Celular;

                    string nomeEntregador = codigoCliente == null ? string.Empty : pedido.Funcionario.Nome;

                    DateTime data = Convert.ToDateTime(pedido.Data.ToString("dd/MM/yyyy"));

                    //cria o arquivo txt para um determinado diretorio
                    FileInfo arquivo = new FileInfo(Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt");

                    using (FileStream fs = arquivo.Create()) { }

                    //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
                    string[] texto = {
                                 "---------------------------------------------",
                                 "        RECIBO DE VENDA ( " + tipoPcte + " )",
                                 "---------------------------------------------",
                                 "Razão Social: " + empresa.Fantasia,
                                 "CNPJ: " + Util.FormatarDocumento("cnpj", empresa.CNPJ),
                                 "---------------------------------------------",
                                 "Nº.Pedido: " + AdicionaZero(pedido.PedidoId.ToString()) + " Data:" + data.ToString("dd/MM/yyyy") + " Hora:" + pedido.Hora,
                                 "Forma de Pag: " + pedido.FormaPagamento.Nome,
                                 "Cliente - Documento: " +documentoCliente,
                                 "" + nomeCliente,
                                 "Celular: " + celular,
                                 IncluirEnderecoEntrega(endereco),
                                 "---------------------------------------------",
                                 "Entregador: " + nomeEntregador,
                                 "=============================================",
                                 "[Cod] [Produto]      [Qtde] [Preço] [Total]",
                                 "---------------------------------------------",
                                 IncluirItens(codigoPedido, pedido.IsPcte),
                                 "---------------------------------------------",
                                 "TOTAL PEDIDO....................  :  R$ " + Convert.ToDecimal(pedido.VlrTotal).ToString("N2"),
                                 "TAXA DE ENTREGA (+).....  :  R$ " + Convert.ToDecimal(pedido.TaxaEntrega).ToString("N2"),
                                 "DESCONTO (-).....................  :  R$ " + Convert.ToDecimal(pedido.VlrDesconto).ToString("N2"),
                                 "TOTAL A PAGAR..................  :  R$ " +   Convert.ToDecimal(pedido.VlrTotalFinal).ToString("N2"),
                                 //"PAGANDO............................  :  R$ "  + Convert.ToDecimal(valorPagamento).ToString("N2"),
                                 "TROCO................................... :  R$ " + Convert.ToDecimal(valorTroco).ToString("N2"),
                                 "---------------------------------------------",
                                 "    Porto Velho - Ro: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                                 "        *Não possui valor fiscal        ",
                                 "---------------------------------------------",
                             };
                    //Escreve as informações no arquivo txt, salvo no diretorio expecificado
                    File.WriteAllLines(Util.exeLocation + "\\Cupom\\ComprovanteVenda.txt", texto);
                }
            }
        }

        private static string IncluirEnderecoEntrega(Endereco endereco)
        {
            StringBuilder sb = new StringBuilder();

            if (IsIncluirEnderecoEntrega() && endereco != null)
            {
                sb.AppendLine("--------------------------------------------");
                sb.AppendLine("Endereço para entrega:");
                sb.AppendLine(" ");
                sb.AppendLine("Bairro: " + endereco.Bairro);
                sb.AppendLine("Rua: " + endereco.Rua + "  Nº: " + endereco.Numero);
                sb.AppendLine("Complemento: " + endereco.Complemento);
            }

            return sb.ToString();
        }

        public static bool IsIncluirEnderecoEntrega()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                return db.ConfiguracoesSistema.Take(1).FirstOrDefault().IsEnderecoRodapeRecibo;
            }
        }

        public static string IncluirItens(int? codigoPedido, bool isPcte)
        {
            StringBuilder sb = new StringBuilder();

            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                var itensPedido = db.ItensPedidos.Where(i => i.PedidoId == codigoPedido).ToList();
                string produto, qtde, preco, total;

                if (isPcte)
                {
                    string cod = string.Empty;

                    foreach (var item in itensPedido)
                    {
                        produto = item.Produto.Nome;
                        qtde = itensPedido.Where(i => i.ProdutoId == item.ProdutoId).Count().ToString();
                        preco = item.VlrUnitario.ToString("C");
                        total = (Convert.ToDecimal(item.VlrUnitario) * Convert.ToInt32(qtde)).ToString("C");

                        if (cod != item.ProdutoId.ToString())
                        {
                            sb.AppendLine(" " + item.ProdutoId.ToString() + "    " + produto + "              " + qtde + "        " + preco + "        " + total);
                        }

                        cod = item.ProdutoId.ToString();
                    }
                }
                else
                {
                    foreach (var item in itensPedido)
                    {
                        produto = item.Produto.Nome;
                        qtde = item.Qtde.ToString();
                        preco = item.VlrUnitario.ToString("C");
                        total = (Convert.ToDecimal(item.VlrUnitario) * Convert.ToInt32(qtde)).ToString("C");
                        sb.AppendLine(" " + item.ProdutoId.ToString() + "    " + produto + "              " + qtde + "        " + preco + "        " + total);
                    }
                }
                return sb.ToString();
            }
        }

        public static void VerificarDataRetornoEntregaPedido()
        {
            using (MyDataContextConfiguration db = new MyDataContextConfiguration())
            {
                DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                var pedidos = db.Pedidos.Where(p =>
                                               p.IsPcte == true &&
                                               p.IsBloquearEntrega == true &&
                                               p.DataRetornoEntregaPacote != null &&
                                               p.DataRetornoEntregaPacote >= dataAtual &&
                                               p.DataRetornoEntregaPacote <= dataAtual).ToList();
                if (pedidos.Count() > 0)
                {
                    foreach (var item in pedidos)
                    {
                        var pedido = db.Pedidos.Find(item.PedidoId);
                        pedido.IsBloquearEntrega = false;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}

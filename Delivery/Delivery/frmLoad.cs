using Delivery.DataContext;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        int valor = 10;
        int valor2 = 0;
        private Thread thread;

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarraProgressoApresentacao.Value = valor2;//ProgressBar recebe o valor da variavel valor = 0

            lblMensagem.ForeColor = System.Drawing.Color.Green;

            if (valor > 0)//Enquanto Valor for < 10 faz o incremento 
            {
                lblTempo.Text = valor.ToString();//Atribui valor a mensagem incrementando no forms

                if (valor >= 7)
                {
                    lblMensagem.Text = "Atualizando pacotes de vendas";
                }

                else if (valor >= 5)
                {
                    lblMensagem.Text = "Verificando integridade do banco de dados";
                }
                else if (valor >= 3)
                {
                    lblMensagem.Text = "Iniciando banco de dados";
                }
                else if (valor >= 1)
                {
                    lblMensagem.Text = "Carregando informações padrão";
                }

                valor -= 1;//Incremento de 1 em 1
                valor2++;
            }
            else//Caso valor seja > desabilita o timer e fechar o forms
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void CarregaBuildSistema()
        {
            lblSobre.Text = "Sistema para Gerenciamento de Delivery |" + Util.CarregaBuildSistema();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            CarregaBuildSistema();

            Util.VerificarDataRetornoEntregaPedido();

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

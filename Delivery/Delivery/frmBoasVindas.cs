using Delivery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmBoasVindas : Form
    {
        int valor;//Cria uma variavel
        SoundPlayer som = new SoundPlayer();//Cria um objeto da classe SoundPlayer
        frmAutenticarUser frm = new frmAutenticarUser();

        public frmBoasVindas(Operador operador)
        {
            InitializeComponent();
            txtNomeUsuario.Text = operador.Nome;
        }

        public void boasVindas()//Método criado para verificar hora do sistema e atribuir resultado como mensagem para boas vindas
        {
            if (DateTime.Now <= DateTime.Parse("12:00:00"))
            {
                som.Play();
                lblMensagemBoasVindas.Text = ("BOM DIA ! ");
            }
            else if (DateTime.Now <= DateTime.Parse("18:00:00"))
            {
                som.Play();
                lblMensagemBoasVindas.Text = ("BOA TARDE  ! ");
            }
            else
            {
                som.Play();
                lblMensagemBoasVindas.Text = ("BOA NOITE ! ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (valor < 3)//Enquanto Valor for < 10 faz o incremento 
            {
                valor += 1;//Incremento de 10 em 10
            }
            else//Caso valor seja > desabilita o timer e fechar o forms
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void frmBoasVindas_Load(object sender, EventArgs e)
        {
            boasVindas();
            timer1.Enabled = true;
        }
    }
}

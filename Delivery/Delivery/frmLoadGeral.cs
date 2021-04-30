using System;
using System.Windows.Forms;

namespace Delivery
{
    public partial class frmLoadGeral : Form
    {
        public frmLoadGeral()
        {
            InitializeComponent();
        }

        int valor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (valor < 1)//Enquanto Valor for < 10 faz o incremento 
            {
                valor += 1;//Incremento de 1 em 1
            }
            else//Caso valor seja > desabilita o timer e fechar o forms
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}

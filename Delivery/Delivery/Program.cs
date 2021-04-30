using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmAutenticarUser frmAUser = new frmAutenticarUser();

            frmLoad frmL = new frmLoad();

            frmL.ShowDialog();

            if(frmAUser.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new frmBasePrincipal(frmAUser));
            }
        }
    }
}

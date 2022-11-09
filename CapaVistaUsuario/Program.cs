using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaUsuario
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CapaVistaUsuario.frmLoguin frm = new CapaVistaUsuario.frmLoguin();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
                Application.Run(new frmPrincipal());
        }
    }
}

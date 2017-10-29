using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.Login;
using PagoAgilFrba.Rendiciones;

namespace PagoAgilFrba
{
    static class PagoAgilFrbaInit
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ABMFacturaForm());
            
        }
    }
}

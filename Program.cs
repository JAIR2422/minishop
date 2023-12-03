using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy_u4
{
    internal static class Program
    {
        public static frmLogin F1 = null;
        public static frmMenu F2 = null;
        public static frmVentas F3 = null;
        public static frmProducto F4 = null;
        public static frmHistorialVentas F5 = null;
        public static frmUsuarios F6 = null;
        public static frmAgregarProd F7 = null;
        public static frmFactura F8 = null;
        public static frmPresentacion F9= null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPresentacion());
        }
    }
}

using proy_u4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy_u4
{
    public partial class frmFactura : Form
    {
        

        public static Venta venta;
        public frmFactura(Venta v)
        {
            venta = v;
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            String cant = "", prod = "", sub = "";
            lblsrbNoFolio.Text = venta.IdVenta.ToString();
            lblsrbNomC.Text = venta.NomCliente;
            lblsrbRFCCliente.Text = venta.RFC;
            lblsrbUsuario.Text = venta.Usuario.Nombre+" "+venta.Usuario.Apellido;
            lblsrbFecha.Text = venta.FechaRegistro;


           // conectar();

            
            cant = venta.listaDetalles(1);
            prod = venta.listaDetalles(2);
            sub = venta.listaDetalles(3);

            lblsrbCant.Text = cant;
            lblsrbProd.Text = prod;
            lblsrbSub.Text = sub;



            lblsrbTotal.Text = venta.MontoTotal.ToString();
            lblsrbPago.Text = venta.MontoPago.ToString();
            lblsrbCambio.Text = venta.MontoCambio.ToString();
        }


        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.F8 = null;
        }
    }
}

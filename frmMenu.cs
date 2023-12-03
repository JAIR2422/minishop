using proy_u4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proy_u4
{
    public partial class frmMenu : Form
    {
        public static Usuario uActual;
        public frmMenu(Usuario objUser)
        {
            uActual = objUser;

            InitializeComponent();
        }

        private void misrbVentas_Click(object sender, EventArgs e)
        {
            if (Program.F3 == null)
            {
                Program.F3 = new frmVentas(uActual);
            }
            this.Hide();
            Program.F3.Show();
        }

        private void misrbHistorial_Click(object sender, EventArgs e)
        {
            if (Program.F5 == null)
            {
                Program.F5 = new frmHistorialVentas(uActual);
            }
            this.Hide();
            Program.F5.Show();
        }

        private void misrbProductos_Click(object sender, EventArgs e)
        {
            if (Program.F4 == null)
            {
                Program.F4 = new frmProducto(uActual);
            }
            this.Hide();
            Program.F4.Show();
        }

        private void misrbUsuarios_Click(object sender, EventArgs e)
        {
            if (Program.F6 == null)
            {
                Program.F6 = new frmUsuarios(uActual);
            }
            this.Hide();
            Program.F6.Show();
        }

        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
            String resp = MessageBox.Show("¿Desea salir de la aplicación?", "Saliendo", MessageBoxButtons.YesNo).ToString();
            if (resp == "Yes")
            {
                Application.Exit();
            }
        }

        private void llsrbSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String resp = MessageBox.Show("¿Desea cerrar sesión?", "Saliendo", MessageBoxButtons.YesNo).ToString();
            if (resp == "Yes")
            {
                this.Close();
                Program.F1 = new frmLogin();
                Program.F1.Show();  
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblsrbFecha.Text = DateTime.Now.Date.ToShortDateString();
            lblsrbNomUser.Text = uActual.Nombre+" "+uActual.Apellido;
        }
    }
}

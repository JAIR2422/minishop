using proy_u4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proy_u4
{
    public partial class frmLogin : Form
    {
        Usuario uSrb = new Usuario();
        bool encontrado = false;

        int contador = 0;
        static string archivodb = "server=localhost;uid=root;" + "pwd= ;database=minishop";

        MySqlConnection conector = new MySqlConnection(archivodb);
        MySqlDataAdapter adaptador;
        MySqlCommand cmd;
        DataTable tablaUsers = new DataTable();


        public frmLogin()
        {
            //Program.F1 = this;
            InitializeComponent();
        }

        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsrbIngresar_Click(object sender, EventArgs e)
        {

            comprueba();
        }

        private void ingresar(Usuario u)
        {
            Program.F2 = new frmMenu(u);
            Program.F2.Show();
            Program.F1.Hide();
        }


        public void conectar()
        {
            try
            {
                conector.Open();

                cmd = new MySqlCommand("Select * From Usuarios where activo = 1 AND (usuario = @U) ", conector);
                cmd.Parameters.AddWithValue("@U", txtsrbUser.Text);

                adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tablaUsers);
                conector.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("archivo no encontrado");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No hay registros en la base de datos");
            }
        }
        public void comprueba()
        {
            if (txtsrbUser.Text != "" && txtsrbContra.Text != "")
            {
                conectar();
                foreach (DataRow row in tablaUsers.Rows)
                {
                    if (row["Usuario"].ToString() == txtsrbUser.Text)
                    {
                        encontrado = true;
                        if (row["Contrasena"].ToString() == txtsrbContra.Text)
                        {
                            txtsrbContra.Clear();
                            txtsrbUser.Clear();
                            contador = 0;

                            Usuario u = new Usuario(int.Parse(row["idUsuario"].ToString()), row["Nombre"].ToString(),
                                row["Apellido"].ToString(), row["Usuario"].ToString(),
                                row["Contrasena"].ToString(), row["Rol"].ToString());
                            ingresar(u);
                        }
                        else
                        {
                            contador++;
                            if (contador <= 3)
                            {
                                txtsrbContra.Clear();
                                txtsrbContra.Focus();

                                lblError.Visible = true;
                                lblError.Text = "Contraseña incorrecta";
                            }
                            else
                            {
                                MessageBox.Show("Limite de fallas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }
                        }

                    }
                }
                if (encontrado == false)
                {
                    txtsrbUser.Clear();
                    txtsrbContra.Clear();
                    txtsrbUser.Focus();

                    lblError.Visible = true;
                    lblError.Text = "Usuario no encontrado";
                }
            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Campos Vacios", MessageBoxButtons.OK);
            }
            encontrado = false;
        }

        private void pbsrbLogo_DoubleClick(object sender, EventArgs e)
        {
            ingresar(uSrb);
        }

        private void txtsrbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                comprueba();
                e.SuppressKeyPress = true;
            }
        }

        private void txtsrbContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                comprueba();
                e.SuppressKeyPress = true;
            }
        }
    }
}

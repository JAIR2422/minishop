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
using proy_u4.Clases;

namespace proy_u4
{
    public partial class frmUsuarios : Form
    {
        Usuario uActual;
        string rolUser = "Empleado";

        static string archivodb = "server=localhost;uid=root;" + "pwd= ;database=minishop";

        MySqlConnection conector = new MySqlConnection(archivodb);
        
        public frmUsuarios(Usuario objUser)
        {
            uActual = objUser;

            InitializeComponent();


            try
            {
                dgsrbUsuarios.DataSource = llenarGrid();

                dgsrbUsuarios.Columns[0].HeaderText = "ID";
                dgsrbUsuarios.Columns[1].HeaderText = "Nombre";
                dgsrbUsuarios.Columns[2].HeaderText = "Apellido";
                dgsrbUsuarios.Columns[3].HeaderText = "Usuario";
                dgsrbUsuarios.Columns[4].Visible = false;
                dgsrbUsuarios.Columns[5].Visible = false;

                
                //conectar();

                foreach (DataGridViewColumn column in dgsrbUsuarios.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12);
                    column.HeaderCell.Style.ForeColor = Color.White;
                    column.HeaderCell.Style.BackColor = Color.Black;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;

                }
                if (dgsrbUsuarios.Rows.Count > 0)
                {
                    dgsrbUsuarios.Rows[0].Selected = true;

                    MostrarUsuarios();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No se pudo cargar los usuarios", "Error");


            }

            if (uActual.Rol == "Admin")
            {
                btnsrbAgregar.Visible=true;
                btnsrbEliminr.Visible=true;
                btnsrbGuardar.Visible=true;
                dgsrbUsuarios.Columns[6].Visible = true;
            }
            else
            {
                btnsrbAgregar.Visible = false;
                btnsrbEliminr.Visible = false;
                btnsrbGuardar.Visible = false;
                dgsrbUsuarios.Columns[6].Visible = false;
            }

        }

        public frmUsuarios()
        {
            InitializeComponent();

        }


        public DataTable llenarGrid()
        {
            DataTable dt = new DataTable();
            try
            {
                conector.Open();


                String llenar = "Select * from Usuarios where Activo =1";
                MySqlCommand cmd = new MySqlCommand(llenar, conector);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conector.Close();


            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Xampp no esta activado", "Error", MessageBoxButtons.OK);
            }
            return dt;
        }

        public void MostrarUsuarios()
        {
            if (dgsrbUsuarios.Rows.Count > 0)
            {
                
                    int index = dgsrbUsuarios.SelectedRows[0].Index;

                    txtsrbUId.Text = dgsrbUsuarios.Rows[index].Cells[0].Value.ToString();
                    txtsrbUNom.Text = dgsrbUsuarios.Rows[index].Cells[1].Value.ToString();
                    txtsrbUAp.Text = dgsrbUsuarios.Rows[index].Cells[2].Value.ToString();
                    txtsrbUUsuario.Text = dgsrbUsuarios.Rows[index].Cells[3].Value.ToString();
                    txtsrbUContra.Text = dgsrbUsuarios.Rows[index].Cells[4].Value.ToString();

                    if(dgsrbUsuarios.Rows[index].Cells[5].Value.ToString() == "Admin")
                    {
                        rbAdmin.Checked = true;
                    }
                    else
                    {
                        rbEmpleado.Checked = true;
                    }

            }
            else
            {
                txtsrbUId.Text = "";
                txtsrbUNom.Text = "";
                txtsrbUUsuario.Text = "";
                txtsrbUAp.Text = "";
                txtsrbUContra.Text = "";
                rbEmpleado.Checked = true;
            }
        }
       
        private void btnsrbAgregar_Click(object sender, EventArgs e)
        {
           
            btnsrbCancelar.Visible = true;
            btnsrbGNuevo.Visible = true;
            gbRol.Visible= true;
            dgsrbUsuarios.Enabled = false;
            btnsrbAgregar.Visible = false;
            btnsrbEliminr.Visible = false;
            btnsrbGuardar.Visible = false;

            cbsrbConfirmar.Visible = true;
            txtsrbUContra.Visible= true;
            lblsrbUContra.Visible=true;

            lblsrbUId.Visible=false;
            txtsrbUId.Visible=false;

            
            limpiar();

        }

        private void limpiar()
        {
            txtsrbUId.Text = "";
            txtsrbUNom.Text = "";
            txtsrbUAp.Text = "";
            txtsrbUUsuario.Text = "";
            txtsrbUContra.Text = "";
            rbEmpleado.Checked = true;

        }
        private void cerrar()
        { 
           
            limpiar();

            btnsrbCancelar.Visible = false;
            gbRol.Visible = false;
            btnsrbGNuevo.Visible = false;
            btnsrbAgregar.Visible = true;
            btnsrbEliminr.Visible = true;
            btnsrbGuardar.Visible = true;

            cbsrbConfirmar.Visible = false;
            txtsrbUContra.Visible = false;
            lblsrbUContra.Visible = false;


            txtsrbUId.Visible = true;
            lblsrbUId.Visible = true;
        }

           

       


        private void btnsrbGNuevo_Click(object sender, EventArgs e)
        {
            if ( txtsrbUNom.Text == "" || txtsrbUAp.Text == "" ||
                txtsrbUUsuario.Text == "" || txtsrbUContra.Text == "" )
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (rbAdmin.Checked == true)
                    {
                        rolUser = "Admin";
                    }

                    conector.Open();

                    string insertar = "Insert into Usuarios ( Nombre,Apellido,Usuario,Contrasena,Rol,Activo) " +
                        "Values (@Nom,@Ap,@U,@C,@R,@A) ";

                    MySqlCommand comando = new MySqlCommand(insertar, conector);

                    comando.Parameters.AddWithValue("@Nom", txtsrbUNom.Text);
                    comando.Parameters.AddWithValue("@Ap", txtsrbUAp.Text);
                    comando.Parameters.AddWithValue("@U", txtsrbUUsuario.Text);
                    comando.Parameters.AddWithValue("@C", txtsrbUContra.Text);
                    comando.Parameters.AddWithValue("@R", rolUser);
                    comando.Parameters.AddWithValue("@A", 1);

                    comando.ExecuteNonQuery();
                    conector.Close();

                    MessageBox.Show("Usuario agregado");
                    dgsrbUsuarios.DataSource = llenarGrid();

                    MostrarUsuarios();

                    limpiar();

                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("cadena demasiado grande");
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("El nombre de usuario ya esta en uso");
                    txtsrbUUsuario.Select();
                    conector.Close();
                }               

            }

            //conectar();

        }

        private void btnsrbCancelar_Click(object sender, EventArgs e)
        {
            btnsrbCancelar.Visible = false;
            btnsrbGNuevo.Visible = false;
            btnsrbAgregar.Visible = true;
            btnsrbEliminr.Visible = true;
            btnsrbGuardar.Visible = true;
            dgsrbUsuarios.Enabled= true;
            cbsrbConfirmar.Visible = false;
            txtsrbUContra.Visible = false;
            lblsrbUContra.Visible = false;
            cerrar();
            MostrarUsuarios();
        }

        private void cbsrbConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsrbConfirmar.Checked)
            {
                txtsrbUContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtsrbUContra.UseSystemPasswordChar = true;
            }
        }

        private void dgsrbUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarUsuarios();
        }


        private void btnsrbGuardar_Click(object sender, EventArgs e)
        {
            if ( txtsrbUNom.Text == "" || txtsrbUAp.Text == "" ||
                txtsrbUUsuario.Text == "" || txtsrbUContra.Text == "" )
            {

                MessageBox.Show("Por favor, rellena todos los campos", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                conector.Open();
                try
                {

                    string actualizar = "UPDATE Usuarios SET idUsuario = @id, Nombre=@Nom, Apellido= @Ap, Usuario= @U, Contrasena = @C WHERE idUsuario =@id";


                    MySqlCommand comando = new MySqlCommand(actualizar, conector);

                    comando.Parameters.AddWithValue("@id", txtsrbUId.Text);
                    comando.Parameters.AddWithValue("@Nom", txtsrbUNom.Text);
                    comando.Parameters.AddWithValue("@Ap", txtsrbUAp.Text);
                    comando.Parameters.AddWithValue("@U", txtsrbUUsuario.Text);
                    comando.Parameters.AddWithValue("@C", txtsrbUContra.Text);

                    comando.ExecuteNonQuery();
                    conector.Close();
                    dgsrbUsuarios.DataSource = llenarGrid();
                    


                }
                catch (OleDbException)
                {
                    MessageBox.Show("cadena demasiado grande");
                }

            }
        }

        private void btnsrbEliminr_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgsrbUsuarios.Rows.Count != 0)
                {
                    String resp = MessageBox.Show("Eliminar al usuario " + txtsrbUNom.Text + "?", "Eliminar", MessageBoxButtons.YesNo).ToString();
                    if (resp == "Yes")
                    {
                       /* conector.Open();
                        string eliminar = "Delete from Usuarios where idUsuario = @id";
                        MySqlCommand comando = new MySqlCommand(eliminar, conector);

                        comando.Parameters.AddWithValue("@id", txtsrbUId.Text);

                        comando.ExecuteNonQuery();
                        conector.Close();*/

                        conector.Open();

                        string eliminar = "UPDATE Usuarios SET idUsuario = @id, Nombre=@Nom, Apellido= @Ap, Usuario= @U, Contrasena = @C, Activo =@A WHERE idUsuario =@id";


                        MySqlCommand comando = new MySqlCommand(eliminar, conector);

                        comando.Parameters.AddWithValue("@id", txtsrbUId.Text);
                        comando.Parameters.AddWithValue("@Nom", txtsrbUNom.Text);
                        comando.Parameters.AddWithValue("@Ap", txtsrbUAp.Text);
                        comando.Parameters.AddWithValue("@U", txtsrbUUsuario.Text);
                        comando.Parameters.AddWithValue("@C", txtsrbUContra.Text);
                        comando.Parameters.AddWithValue("@A", 0);

                        comando.ExecuteNonQuery();
                        conector.Close();

                        dgsrbUsuarios.DataSource = llenarGrid();
                        MostrarUsuarios();
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                limpiar();
            }
        }

        private void btnsrbSalir_Click(object sender, EventArgs e)
        {

            this.Close();
            Program.F6 = null;
            Program.F2.Show();
        }

        private void dgsrbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarUsuarios();
        }
    }
}

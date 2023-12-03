using MySql.Data.MySqlClient;
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
using System.Windows.Markup;


namespace proy_u4
{
    public partial class frmAgregarProd : Form
    {
        Usuario uActual;

        string archivodb = "server=localhost;uid=root;" + "pwd= ;database=minishop";


        MySqlConnection conector;
        MySqlDataAdapter adaptador;
        MySqlCommandBuilder actualizardb;
        DataTable tabla;
        DataRow renglontabla;
        public frmAgregarProd(Usuario objUser)
        {
            InitializeComponent();
            uActual = objUser;
            conectar();
        }



        /// <summary>Conectars this instance.</summary>
        public void conectar()
        {
                try
                {
                    conector = new MySql.Data.MySqlClient.MySqlConnection();
                    conector.ConnectionString = archivodb;
                    conector.Open();

                    adaptador = new MySqlDataAdapter("Select * From Productos order by idProducto ", conector);
                    actualizardb = new MySqlCommandBuilder(adaptador);
                    tabla = new DataTable();
                    adaptador.Fill(tabla);
                    conector.Close();
                }
            //muestra la ex y el error
                catch (MySql.Data.MySqlClient.MySqlException ex)
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

        /// <summary>Handles the Click event of the btnsrbSalir control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
           // cambiarCodigo();
            this.Close();
            Program.F7 = null;
            Program.F4 = new frmProducto(uActual);
            Program.F4.Show();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog af = new OpenFileDialog();
            //af.ShowDialog();
            af.Title = "Seleccionar imagen";
            af.Filter = "Image Files | *.jpg; *.jpeg; *.png;";

            //txtsrbNAFoto.Text = Path.GetFileName(af.FileName);

            if (af.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //copia el archivo al debug
                    String fileName = af.FileName;
                    String directory = @"" + Directory.GetCurrentDirectory() + "\\FotosProd\\" + fileName.Substring(fileName.LastIndexOf(@"\"));
                    File.Copy(fileName, directory);
                    txtsrbfoto.Text = Directory.GetCurrentDirectory() + "\\FotosProd\\" + Path.GetFileName(af.FileName);
                    pbsrbFoto.Image = Image.FromFile(txtsrbfoto.Text);

                }
                catch (System.IO.IOException)
                {
                    //MessageBox.Show("Imagen ya seleccionada anteriormente");

                    //si ya estaba gusrdada la img se copia la ubi y se pone la img 
                    txtsrbfoto.Text = Directory.GetCurrentDirectory() + "\\FotosProd\\" + Path.GetFileName(af.FileName);
                    pbsrbFoto.Image = Image.FromFile(txtsrbfoto.Text);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Ninguna imagen seleccionada");
                }
            }
        }

        private void btnsrbGuardar_Click(object sender, EventArgs e)
        {
            if ( txtsrbPDesc.Text == "" || txtsrbPPrecio.Text == "" || txtsrbPPVenta.Text == ""
                 || txtsrbPStock.Text == "" || cbsrbPCat.Text == "" || txtsrbfoto.Text == "")
            //  || txtsrbPCodigo.Text == "" ||
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                try
                {/*
                    Producto prod = new Producto(noCodigo, txtsrbPDesc.Text, cbsrbPCat.Text, int.Parse(txtsrbPStock.Text),
                        double.Parse(txtsrbPPrecio.Text), double.Parse(txtsrbPPVenta.Text), txtsrbfoto.Text);

                    */
                    conector.Open();
                    string insertar = "Insert into Productos ( Descripcion,Categoria,Stock,Precio,PrecioVenta,Foto,Activo) " +
                        "Values (@Desc,@Cat,@S,@P,@Pv,@F,@A) ";


                    MySqlCommand comando = new MySqlCommand(insertar, conector);

                   // comando.Parameters.AddWithValue("@id", txtsrbPCodigo.Text);
                    comando.Parameters.AddWithValue("@Desc", txtsrbPDesc.Text);
                    comando.Parameters.AddWithValue("@Cat", cbsrbPCat.Text);
                    comando.Parameters.AddWithValue("@S", txtsrbPStock.Text);
                    comando.Parameters.AddWithValue("@P", txtsrbPPrecio.Text);
                    comando.Parameters.AddWithValue("@Pv", txtsrbPPVenta.Text);
                    comando.Parameters.AddWithValue("@F", txtsrbfoto.Text);
                    comando.Parameters.AddWithValue("@A", 1);

                    comando.ExecuteNonQuery();
                    conector.Close();

                    MessageBox.Show("Producto agregado");

                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("cadena demasiado grande");
                    
                }
              


                txtsrbPCodigo.Text = "";
                txtsrbPDesc.Text = "";
                txtsrbPPrecio.Text = "";
                txtsrbPPVenta.Text = "";
                txtsrbPStock.Text = "";
                cbsrbPCat.Text = "";
                pbsrbFoto.Image = null;
                txtsrbfoto.Text = "";
                //cambiarCodigo();
            }

        }

        private void txtsrbPStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsrbPPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //solo permite poner el . una vez
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtsrbPPVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //solo permite poner el . una vez
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        
    }
}

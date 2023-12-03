using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using proy_u4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace proy_u4
{
    public partial class frmProducto : Form
    {
        Usuario uActual;

        static string archivodb = "server=localhost;uid=root;" + "pwd= ;database=minishop ";


        MySqlConnection conector = new MySqlConnection(archivodb);
        MySqlDataAdapter adaptador;
        MySqlCommand comandoDB;
        DataTable tabla;

        String llenar = "Select * from Productos where Activo = 1";


        public frmProducto(Usuario objUser)
        {
            uActual = objUser;

            InitializeComponent();

            try
            {
                dgsrbProductos.DataSource = llenarGrid();
                dgsrbProductos.Columns[0].HeaderText = "Código";
                dgsrbProductos.Columns[1].HeaderText = "Descripción";
                dgsrbProductos.Columns[2].HeaderText = "Categoría";
                dgsrbProductos.Columns[3].HeaderText = "Stock";
                dgsrbProductos.Columns[4].HeaderText = "Precio";
                dgsrbProductos.Columns[5].HeaderText = "P. Venta";
                dgsrbProductos.Columns[6].Visible = false;

                foreach (DataGridViewColumn column in dgsrbProductos.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12);

                    column.HeaderCell.Style.ForeColor = Color.White;
                    column.HeaderCell.Style.BackColor = Color.Black;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;


                }
                if (dgsrbProductos.Rows.Count > 0)
                {
                    dgsrbProductos.Rows[0].Selected = true;

                    MostrarDetallesProducto();
                }
                if (objUser.Rol == "Admin")
                {
                    btnsrbGuardar.Visible = true;
                    btnsrbAgregar.Visible = true;
                    btnsrbEliminr.Visible = true;
                    dgsrbProductos.Columns[7].Visible = true;
                }
                else
                {
                    btnsrbGuardar.Visible = false;
                    btnsrbAgregar.Visible = false;
                    btnsrbEliminr.Visible = false;
                    dgsrbProductos.Columns[7].Visible = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No se pudo cargar los productos", "Error");
            }

            
        }

        public DataTable llenarGrid()
        {
            DataTable dt = new DataTable();
            try
            {
                conector.Open();

                MySqlCommand cmd = new MySqlCommand(llenar, conector);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conector.Close();


            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Xampp no está activado", "Error", MessageBoxButtons.OK);
            }
            return dt;
        }



        private void btnsrbAgregar_Click(object sender, EventArgs e)
        {
            if (Program.F7 == null)
            {
                Program.F7 = new frmAgregarProd(uActual);
            }
            this.Hide();
            Program.F7.Show();
        }


        private void pbsrbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog af = new OpenFileDialog();
            af.Title = "Seleccionar imagen";
            af.Filter = "Image Files | *.jpg; *.jpeg; *.png;";

            if (af.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Ruta del directorio FotosProd en el directorio de depuración (debug)
                    string directorio = Path.Combine(Directory.GetCurrentDirectory(), "FotosProd");

                    if (!Directory.Exists(directorio))
                    {
                        Directory.CreateDirectory(directorio);
                    }

                    string destino = Path.Combine(directorio, Path.GetFileName(af.FileName));
                    File.Copy(af.FileName, destino, true);
                    txtsrbfoto.Text = destino;
                    pbsrbFoto.Image = Image.FromFile(destino);
                }
                catch (System.IO.IOException)
                {
                    try
                    {
                        string directorio = Path.Combine(Directory.GetCurrentDirectory(), "FotosProd");

                        txtsrbfoto.Text = directorio + Path.GetFileName(af.FileName);
                        pbsrbFoto.Image = Image.FromFile(txtsrbfoto.Text);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Archivo no encontrado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }

        private void btnsrbGuardar_Click(object sender, EventArgs e)
        {
            if (txtsrbPCodigo.Text == "" || txtsrbPDesc.Text == "" || txtsrbPPrecio.Text == "" || txtsrbPPVenta.Text == ""
                || txtsrbPStock.Text == "" || cbsrbPCat.Text == "" || txtsrbfoto.Text == "")
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                conector.Open();

                string actualizar = "UPDATE Productos SET idProducto = @id, Descripcion=@Desc, Categoria= @Cat, Stock= @S, Precio = @P, PrecioVenta= @Pv, Foto= @F WHERE idProducto =@id";


                MySqlCommand comando = new MySqlCommand(actualizar, conector);

                comando.Parameters.AddWithValue("@id", txtsrbPCodigo.Text);
                comando.Parameters.AddWithValue("@Desc", txtsrbPDesc.Text);
                comando.Parameters.AddWithValue("@Cat", cbsrbPCat.Text);
                comando.Parameters.AddWithValue("@S", txtsrbPStock.Text);
                comando.Parameters.AddWithValue("@P", txtsrbPPrecio.Text);
                comando.Parameters.AddWithValue("@Pv", txtsrbPPVenta.Text);
                comando.Parameters.AddWithValue("@F", txtsrbfoto.Text);

                comando.ExecuteNonQuery();
                conector.Close();
                dgsrbProductos.DataSource = llenarGrid();


            }

        }
        private void MostrarDetallesProducto()
        {
            //tabla vacia ArgumentOutOfRangeException
            if (dgsrbProductos.Rows.Count > 0)
            {
                try
                {
                    int index = dgsrbProductos.SelectedRows[0].Index;

                    txtsrbPCodigo.Text = dgsrbProductos.Rows[index].Cells[0].Value.ToString();
                    txtsrbPDesc.Text = dgsrbProductos.Rows[index].Cells[1].Value.ToString();
                    cbsrbPCat.Text = dgsrbProductos.Rows[index].Cells[2].Value.ToString();
                    txtsrbPStock.Text = dgsrbProductos.Rows[index].Cells[3].Value.ToString();
                    txtsrbPPrecio.Text = dgsrbProductos.Rows[index].Cells[4].Value.ToString();
                    txtsrbPPVenta.Text = dgsrbProductos.Rows[index].Cells[5].Value.ToString();
                    txtsrbfoto.Text = dgsrbProductos.Rows[index].Cells[6].Value.ToString();
                    pbsrbFoto.Image = Image.FromFile(txtsrbfoto.Text);
                }
                catch (FileNotFoundException)
                {
                    pbsrbFoto.Image = null;
                }


            }
            else
            {
                txtsrbPCodigo.Text = "";
                txtsrbPDesc.Text = "";
                txtsrbPPrecio.Text = "";
                txtsrbPPVenta.Text = "";
                txtsrbPStock.Text = "";
                cbsrbPCat.Text = "";
                pbsrbFoto.Image = null;
                txtsrbfoto.Text = "";
            }
        }


        private void dgsrbProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MostrarDetallesProducto();
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

        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.F4 = null;
            Program.F2.Show();
        }

        private void btnsrbEliminr_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgsrbProductos.Rows.Count != 0)
                {
                    String resp = MessageBox.Show("Eliminar " + txtsrbPDesc.Text + "?", "Eliminar", MessageBoxButtons.YesNo).ToString();
                    if (resp == "Yes")
                    {/*
                        conector.Open();
                        string eliminar = "Delete from Productos where idProducto = @id";
                        MySqlCommand comando = new MySqlCommand(eliminar, conector);

                        comando.Parameters.AddWithValue("@id", txtsrbPCodigo.Text);

                        comando.ExecuteNonQuery();
                        conector.Close();

                        dgsrbProductos.DataSource = llenarGrid();

                        MostrarDetallesProducto();

                        */
                        conector.Open();

                        string actualizar = "UPDATE Productos SET idProducto = @id, Descripcion=@Desc, Categoria= @Cat, Stock= @S, Precio = @P, PrecioVenta= @Pv, Foto= @F, Activo =@A WHERE idProducto =@id";


                        MySqlCommand comando = new MySqlCommand(actualizar, conector);

                        comando.Parameters.AddWithValue("@id", txtsrbPCodigo.Text);
                        comando.Parameters.AddWithValue("@Desc", txtsrbPDesc.Text);
                        comando.Parameters.AddWithValue("@Cat", cbsrbPCat.Text);
                        comando.Parameters.AddWithValue("@S", txtsrbPStock.Text);
                        comando.Parameters.AddWithValue("@P", txtsrbPPrecio.Text);
                        comando.Parameters.AddWithValue("@Pv", txtsrbPPVenta.Text);
                        comando.Parameters.AddWithValue("@F", txtsrbfoto.Text);
                        comando.Parameters.AddWithValue("@A", 0);

                        comando.ExecuteNonQuery();
                        conector.Close();

                        dgsrbProductos.DataSource = llenarGrid();
                        MostrarDetallesProducto();

                        //MySql.Data.MySqlClient.MySqlException
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                txtsrbPCodigo.Text = "";
                txtsrbPDesc.Text = "";
                txtsrbPPrecio.Text = "";
                txtsrbPPVenta.Text = "";
                txtsrbPStock.Text = "";
                cbsrbPCat.Text = "";
                pbsrbFoto.Image = null;
                txtsrbfoto.Text = "";
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            if (!txtBuscar.Text.Equals(""))
            {
                llenar = "Select * from productos where Activo = 1 and (idProducto like '%" + txtBuscar.Text + "%'" +
                    "or Descripcion like '%" + txtBuscar.Text + "%' " +
                    "or Categoria like '%" + txtBuscar.Text + "%')";
            }
            else
            {
                llenar = "Select * from Productos where Activo = 1";
            }
            dgsrbProductos.DataSource = llenarGrid();
            MostrarDetallesProducto();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Buscar();
                e.SuppressKeyPress = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("")) { Buscar(); }

        }
    }
}

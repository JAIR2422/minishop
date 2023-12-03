using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using proy_u4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy_u4
{
    public partial class frmVentas : Form
    {
        List<DetalleVenta> detalles = new List<DetalleVenta>();
        Usuario uActual;
        double subtotal, total, iva, cambio, pago;
        int stock, cant;

        static string archivodb = "server=localhost;uid=root;" + "pwd= ;database=minishop";


        String query = "Select * from Productos where Activo = 1";

        MySqlConnection conector = new MySqlConnection(archivodb);
        MySqlDataAdapter adaptador;
        MySqlCommandBuilder actualizardb;
        DataTable tablaProd;


        public frmVentas(Usuario objUser)
        {
            uActual = objUser;

            InitializeComponent();
            // cargarLista();
        }
        public DataTable ConectarProd()
        {
            DataTable dt = new DataTable();
            try
            {
                conector.Open();

                MySqlCommand cmd = new MySqlCommand(query, conector);
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

        private void MostrarProd()
        {
            if (dgsrbProductos.Rows.Count > 0)
            {
                try
                {
                    int index = dgsrbProductos.SelectedRows[0].Index;

                    txtsrbDesc.Text = dgsrbProductos.Rows[index].Cells[1].Value.ToString();
                    txtsrbCat.Text = dgsrbProductos.Rows[index].Cells[2].Value.ToString();
                    txtsrbCant.Text = "1";
                    txtsrbStock.Text = dgsrbProductos.Rows[index].Cells[3].Value.ToString();
                    txtsrbPVenta.Text = dgsrbProductos.Rows[index].Cells[5].Value.ToString();
                    pbsrbFoto.Image = Image.FromFile(dgsrbProductos.Rows[index].Cells[6].Value.ToString());

                }
                catch (FileNotFoundException)
                {
                    pbsrbFoto.Image = null;
                }


            }
            else
            {

                txtsrbDesc.Text = "";
                txtsrbCat.Text = "";
                txtsrbCant.Text = "";
                txtsrbPVenta.Text = "";
                txtsrbStock.Text = "";
                pbsrbFoto.Image = null;
            }
        }







        public void cargarLista()
        {
            tablaProd = ConectarProd();
            dgsrbProductos.DataSource = tablaProd;

            // dgsrbProductos.DataSource = ConectarProd();

            dgsrbProductos.Columns[0].HeaderText = "Código";
            dgsrbProductos.Columns[1].HeaderText = "Descripción";
            dgsrbProductos.Columns[2].Visible = false;
            dgsrbProductos.Columns[3].Visible = false;
            dgsrbProductos.Columns[4].Visible = false;
            dgsrbProductos.Columns[5].Visible = false;
            dgsrbProductos.Columns[6].Visible = false;
            dgsrbProductos.Columns[7].Visible = false;



            foreach (DataGridViewColumn column in dgsrbProductos.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12);

                column.HeaderCell.Style.ForeColor = Color.White;
                column.HeaderCell.Style.BackColor = Color.Black;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            foreach (DataGridViewColumn column in dgsrbDetalles.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12);

                column.HeaderCell.Style.ForeColor = Color.White;
                column.HeaderCell.Style.BackColor = Color.Black;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            if (dgsrbProductos.Rows.Count > 0)
            {
                dgsrbProductos.Rows[0].Selected = true;

                MostrarProd();
            }



            //tablaProd = ConectarProd();

        }
        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.F3 = new frmVentas(uActual);
            Program.F2.Show();
        }

        private void txtsrbPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtsrbPago_TextChanged(object sender, EventArgs e)
        {
            if (txtsrbPago.Text != "")
            {
                pago = double.Parse(txtsrbPago.Text);
                cambio = double.Parse(txtsrbPago.Text) - total;
                txtsrbCambio.Text = cambio.ToString("0.##");
                if (cambio >= 0)
                    btnsrbTerminarVenta.Enabled = true;
                else
                {
                    btnsrbTerminarVenta.Enabled = false;
                }
            }
            else
            {
                pago = 0;
                cambio = 0;
                txtsrbCambio.Text = cambio.ToString("0.##");
            }
        }

        private void btnsrbAgregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtsrbStock.Text) > 0)
            {
                if (txtsrbCant.Text == "" || txtsrbPVenta.Text == "")
                {
                    MessageBox.Show("Por favor, rellena todos los campos", "Campos Vacios", MessageBoxButtons.OK);
                }
                else
                {
                    if (dgsrbProductos.Rows.Count != 0)
                    {
                        verificarStock();
                        double totalprd = int.Parse(txtsrbCant.Text) * double.Parse(txtsrbPVenta.Text);

                        DetalleVenta detalle;
                        Producto temp = new Producto();

                        int index = dgsrbProductos.SelectedRows[0].Index;
                        int id = int.Parse(dgsrbProductos.Rows[index].Cells[0].Value.ToString());

                        int stockNuevo = 0;

                        foreach (DataRow p in tablaProd.Rows)
                        {
                            if (id == int.Parse(p["idProducto"].ToString()))
                            {
                                temp.IdProd = int.Parse(p["idProducto"].ToString());
                                temp.Desc = p["Descripcion"].ToString();
                                temp.Categoria = p["Categoria"].ToString();
;
                                temp.Precio = double.Parse(p["Precio"].ToString());
                                temp.PrecioVenta = double.Parse(p["PrecioVenta"].ToString());
                                temp.Foto = p["Foto"].ToString();

                                stock = int.Parse(p["Stock"].ToString());

                                cant = int.Parse(txtsrbCant.Text);
                                stockNuevo = stock - cant;
                                p["Stock"] = stockNuevo;

                                temp.Stock = int.Parse(p["Stock"].ToString());

                                tablaProd.AcceptChanges();
                                p.SetModified();
                                break;
                            }
                        }
                        dgsrbProductos.Refresh();

                        detalle = new DetalleVenta(temp, double.Parse(txtsrbPVenta.Text), int.Parse(txtsrbCant.Text), totalprd);
                        detalles.Add(detalle);

                        int rowEscribir;
                        dgsrbDetalles.Rows.Add();
                        if (dgsrbDetalles.Rows.Count == 0)
                        {
                            rowEscribir = dgsrbDetalles.Rows.Count;
                        }
                        else
                        {
                            rowEscribir = dgsrbDetalles.Rows.Count - 1;
                        }

                        dgsrbDetalles.Rows[rowEscribir].Cells[0].Value = temp.Desc;
                        dgsrbDetalles.Rows[rowEscribir].Cells[1].Value = detalle.Cantidad;
                        dgsrbDetalles.Rows[rowEscribir].Cells[2].Value = detalle.PrecioVenta;
                        dgsrbDetalles.Rows[rowEscribir].Cells[3].Value = detalle.SubTotal;

                        txtsrbPago.Text = "";
                        CalcularTotal();

                        gbsrbTotales.Enabled = true;

                        dgsrbDetalles.Refresh();
                        MostrarProd();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione otro producto", "Producto Agotado", MessageBoxButtons.OK);
            }
            btnsrbAgregar.Enabled = true;
        }
        private void CalcularTotal()
        {
            foreach (DataGridViewRow row in dgsrbDetalles.Rows)
            {
                subtotal += double.Parse(Convert.ToString(row.Cells[3].Value));
            }

            iva = subtotal * .08;
            String ivaFormato = Math.Round(iva, 2).ToString("#.#0");
            iva = double.Parse(ivaFormato);
            total = subtotal + iva;

            String totalFormato = Math.Round(total, 2).ToString("#.#0");
            total = double.Parse(totalFormato);

            txtsrbIVA.Text = iva.ToString();
            txtsrbSub.Text = subtotal.ToString();
            txtsrbTotal.Text = total.ToString();
            txtsrbStock.Text = stock.ToString();
            txtsrbCant.Text = "1";

            subtotal = 0;
        }


        private void btnsrbTerminarVenta_Click(object sender, EventArgs e)
        {
            if (cbCliente.Checked == true && (txtsrbCorreoC.Text == "" || txtsrbTelC.Text == "" || txtsrbNomC.Text == ""))
            {
                MessageBox.Show("Por favor, rellena todos los campos del Cliente", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                if (txtsrbCambio.Text != "")
                {
                    Venta vNew = new Venta(uActual, txtsrbNomC.Text, txtsrbTelC.Text, txtsrbCorreoC.Text,
                        pago, cambio, total, detalles);


                    conector.Open();
                    string insertar = "Insert into Venta ( idUsuario,NomCliente,RFCCliente," +
                        "CorreoCliente,MontoPago,MontoCambio,MontoTotal,FechaRegistro) " +
                        "Values (@idU,@NomC,@RFC,@CC,@MP,@MC,@MT,@FR) ";


                    MySqlCommand comando = new MySqlCommand(insertar, conector);
                    comando.Parameters.AddWithValue("@idU", vNew.Usuario.Id);
                    comando.Parameters.AddWithValue("@NomC", vNew.NomCliente);
                    comando.Parameters.AddWithValue("@RFC", vNew.RFC);
                    comando.Parameters.AddWithValue("@CC", vNew.CorreoCliente);
                    comando.Parameters.AddWithValue("@MP", vNew.MontoPago);
                    comando.Parameters.AddWithValue("@MC", vNew.MontoCambio);
                    comando.Parameters.AddWithValue("@MT", vNew.MontoTotal);
                    comando.Parameters.AddWithValue("@FR", DateTime.Now);

                    comando.ExecuteNonQuery();
                    long id = comando.LastInsertedId;
                    int ultimaID = (int)id;

                    vNew.IdVenta = ultimaID;

                    //varibles para cambiar el stock del producto en la base de datos
                    int idProducto = 0;
                    int CantProducto = 0;


                    foreach (var det in detalles)
                    {
                        string insertarDet = "Insert into DetalleVenta (idProducto,idVenta,PrecioVenta,Cantidad,Subtotal) " +
                        "Values (@idP,@idV,@PV,@C,@S) ";

                        MySqlCommand comandoDet = new MySqlCommand(insertarDet, conector);

                        comandoDet.Parameters.AddWithValue("@idP", det.Prod.IdProd);
                        comandoDet.Parameters.AddWithValue("@idV", ultimaID);
                        comandoDet.Parameters.AddWithValue("@PV", det.PrecioVenta);
                        comandoDet.Parameters.AddWithValue("@C", det.Cantidad);
                        comandoDet.Parameters.AddWithValue("@S", det.SubTotal);

                        idProducto = det.Prod.IdProd;
                        CantProducto = det.Prod.Stock;

                        comandoDet.ExecuteNonQuery();


                        string actualizarProd = "UPDATE Productos SET idProducto = @id,Stock= @S WHERE idProducto =@id";

                        MySqlCommand cmdActualizarProd = new MySqlCommand(actualizarProd, conector);

                        cmdActualizarProd.Parameters.AddWithValue("@id", idProducto);
                        cmdActualizarProd.Parameters.AddWithValue("@S", CantProducto);

                        cmdActualizarProd.ExecuteNonQuery();
                    }
                    conector.Close();
                    MessageBox.Show("Venta realizada correctamente");
                    limpiar();

                }
            }
        }
        private void limpiar()
        {
            txtBuscar.Text = "";
            dgsrbDetalles.Rows.Clear();
            dgsrbDetalles.Refresh();
            detalles = new List<DetalleVenta>();
            txtsrbSub.Text = "";
            txtsrbIVA.Text = "";
            txtsrbTotal.Text = "";
            txtsrbPago.Text = "";
            txtsrbCambio.Text = "";

            MostrarProd();


        }

        private void txtsrbNomC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;

            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            if (!txtBuscar.Text.Equals(""))
            {
                query = "Select * from productos where Activo = 1 and (idProducto like '%" + txtBuscar.Text + "%'" +
                    "or Descripcion like '%" + txtBuscar.Text + "%' " +
                    "or Categoria like '%" + txtBuscar.Text + "%')";
            }
            else
            {
                query = "Select * from Productos where Activo = 1";
            }
            tablaProd = ConectarProd();
            dgsrbProductos.DataSource = tablaProd;
            MostrarProd();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnsrbEliminar_Click(object sender, EventArgs e)
        {//se necesit devolver l cntidad a la tbl prod y se mnececita actualizar lo d calculo pago
            //cuando se eliminan todos d la liya el cambio no se actualiza 
            if (dgsrbDetalles.Rows.Count > 0)
            {
                int index = dgsrbDetalles.SelectedRows[0].Index;

                string desc = dgsrbDetalles.Rows[index].Cells[0].Value.ToString();
                int cantidad = int.Parse(dgsrbDetalles.Rows[index].Cells[1].Value.ToString());
                int stk;
                foreach (DataRow row in tablaProd.Rows)
                {
                    if (row["Descripcion"].ToString().Equals(desc))
                    {
                        stk = int.Parse(row["Stock"].ToString());
                        stk += cantidad;
                        row["Stock"] = stk;
                        tablaProd.AcceptChanges();
                        row.SetModified();
                        break;
                    }
                }
                detalles.RemoveAt(index);
                dgsrbDetalles.Rows.RemoveAt(index);


            }
            txtsrbPago.Text = "";
            CalcularTotal();
            MostrarProd();
        }

        private void cbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCliente.Checked == true)
            {
                gbsrbDatosCliente.Enabled = true;
            }
            else
            {
                gbsrbDatosCliente.Enabled = false;
            }

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Buscar();
                e.SuppressKeyPress = true;
            }
        }

        private void dgsrbProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarProd();

        }

        private void txtsrbCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsrbPVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsrbCant_Leave(object sender, EventArgs e)
        {
            verificarStock();
        }
        private void verificarStock()
        {
            if (txtsrbCant.Text != "" && txtsrbStock.Text != "")
            {
                //conectarProd();
                String temp = "1";
                cant = int.Parse(txtsrbCant.Text);
                stock = int.Parse(txtsrbStock.Text);
                if (cant <= stock)
                {
                    temp = txtsrbCant.Text;
                }
                txtsrbCant.Text = temp;
            }

        }
    }
}

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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proy_u4
{
    public partial class frmHistorialVentas : Form
    {
        

       static string archivodb = "server=localhost;uid=root;" + "pwd= ;database=minishop; convert zero datetime=True";


        MySqlConnection conector = new MySqlConnection(archivodb);

        int idVenta = 0;
        Usuario uActual;

        int dia =0;
        int mes =0;
        int year = 0;
        DataTable dt = new DataTable();

        public frmHistorialVentas(Usuario u)
        {
            uActual = u;
            InitializeComponent();
            dtFechaFinal.Value = DateTime.Now;
            llenarHistorial();
            
            dgsrbHistorial.Columns[0].HeaderText = "No. Factura";
            dgsrbHistorial.Columns[1].Visible = false;
            dgsrbHistorial.Columns[2].HeaderText = "Cliente";
            dgsrbHistorial.Columns[3].HeaderText = "RFC Cliente";
            dgsrbHistorial.Columns[4].HeaderText = "Correo Cliente";
            dgsrbHistorial.Columns[5].HeaderText = "Pago";
            dgsrbHistorial.Columns[6].HeaderText = "Cambio";
            dgsrbHistorial.Columns[7].HeaderText = "Total";
            dgsrbHistorial.Columns[8].HeaderText = "Fecha";

            foreach (DataGridViewColumn column in dgsrbHistorial.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12);

                column.HeaderCell.Style.ForeColor = Color.White;
                column.HeaderCell.Style.BackColor = Color.Black;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            

        }
        private void btnsrbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.F5 = null;
            Program.F2.Show();
        }

        

        public void llenarHistorial()
        {
            try
            {
                dt.Rows.Clear();
                conector.Open();


                String llenar = "Select * from Venta where FechaRegistro between @FI and @FF ";
                MySqlCommand cmd = new MySqlCommand(llenar, conector);
                cmd.Parameters.AddWithValue("@FI", dtFechaInicial.Value);
                cmd.Parameters.AddWithValue("@FF", dtFechaFinal.Value);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conector.Close();

                dgsrbHistorial.DataSource=dt;
                //dgsrbHistorial.Refresh();

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Xampp no esta activado", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if (dgsrbHistorial.Rows.Count > 0)
            {
                int index = dgsrbHistorial.SelectedRows[0].Index;

                idVenta = int.Parse(dgsrbHistorial.Rows[index].Cells[0].Value.ToString());
                
                List<DetalleVenta> detallesLista = new List<DetalleVenta>();

                DataTable tabla = buscarDetalles();
                Venta v;
                DetalleVenta detalle;
                Producto prod ;
                Usuario u;

                if (tabla.Rows.Count > 0)
                {
                    string nomC = tabla.Rows[0].ItemArray[1].ToString();
                    string rfcC = tabla.Rows[0].ItemArray[2].ToString();
                    string correoC = tabla.Rows[0].ItemArray[3].ToString();
                    double pago = double.Parse(tabla.Rows[0].ItemArray[4].ToString());
                    double cambio = double.Parse(tabla.Rows[0].ItemArray[5].ToString());
                    double total = double.Parse(tabla.Rows[0].ItemArray[6].ToString());
                    string fecha = tabla.Rows[0].ItemArray[7].ToString();
                    
                    string nombre = tabla.Rows[0].ItemArray[8].ToString();
                    string apellido = tabla.Rows[0].ItemArray[9].ToString();

                    string formatoF = fecha.Substring(0, fecha.IndexOf(' '));

                    u = new Usuario(nombre, apellido);

                    foreach (DataRow d in tabla.Rows)
                    {
                        //para el prod
                        string desc = d["Descripcion"].ToString();

                        //para el detalle
                        double pv = double.Parse(d["PrecioVenta"].ToString());
                        int cant = int.Parse(d["Cantidad"].ToString());
                        double subtotal = double.Parse(d["Subtotal"].ToString());

                        prod = new Producto(desc);
                        detalle = new DetalleVenta(prod, pv, cant, subtotal);
                        detallesLista.Add(detalle);
                    }

                    v = new Venta(idVenta, u, nomC, rfcC, correoC, pago, cambio, total, detallesLista, formatoF);

                    Program.F8 = new frmFactura(v);
                    Program.F8.Show();
                }
            }
        }
            public DataTable buscarDetalles()
            {
                DataTable dt = new DataTable();
                try
                {
                    conector.Open();
                    String llenar = "SELECT v.idVenta,v.NomCliente,v.RFCCliente,v.CorreoCliente,v.MontoPago,v.MontoCambio," +
                    "v.MontoTotal,v.FechaRegistro,u.Nombre,u.Apellido,dt.PrecioVenta,dt.Cantidad,dt.Subtotal," +
                    "p.Descripcion from venta as v " +
                    "INNER JOIN usuarios as u on v.idUsuario = u.idUsuario " +
                    "INNER JOIN detalleventa as dt on v.idVenta = dt.idVenta " +
                    "INNER JOIN productos as p on dt.idProducto= p.idProducto " +
                    "WHERE v.idVenta= " + idVenta;
                    MySqlCommand cmd = new MySqlCommand(llenar, conector);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    conector.Close();


                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Xampp no esta activado", "Error", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                MessageBox.Show($"Error: {ex.Message}");
             }
            return dt;
            }

        private void ConseguirFechaInicial(int f)
        {
            switch (f)
            {
                case 1:
                    dia = int.Parse(dtFechaInicial.Value.Day.ToString());
                    mes = int.Parse(dtFechaInicial.Value.Month.ToString());
                    year = int.Parse(dtFechaInicial.Value.Year.ToString());
                    break;
                case 2:
                    dia = int.Parse(dtFechaFinal.Value.Day.ToString());
                    mes = int.Parse(dtFechaFinal.Value.Month.ToString());
                    year = int.Parse(dtFechaFinal.Value.Year.ToString());
                    break;
                default:
                    dia = 1;
                    mes = 1;
                    year = 0001;
                    break;
            }
        }

        private void btnInAtras_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(1);
            if (dia <= 1)
            {
                if (mes <= 1)
                {
                    year--;
                    mes = 12;
                    dia = DateTime.DaysInMonth(year, mes);
                }
                else
                {
                    mes--;
                    dia = DateTime.DaysInMonth(year, mes);
                }
            }
            else
            {
                dia--;
            }
            dtFechaInicial.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }
       
        private void btnInSemAtras_Click(object sender, EventArgs e)
        {
           ConseguirFechaInicial(1);
            if (mes <= 1)
            {
                    year--;
                    mes = 12;
                   
             }
            else
            {
                    mes--;
                    
            }
            
            dtFechaInicial.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }

        private void btnInAdelante_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(1);
            if (dia >= DateTime.DaysInMonth(year, mes))
            {
                if (mes >= 12)
                {
                    year++;
                    mes = 1;
                    dia = 1;
                }
                else
                {
                    mes++;
                    dia = 1;
                }
            }
            else
            {
                dia++;
            }
            dtFechaInicial.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }

        private void btnInSemAdelante_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(1);
            if (mes >= 12)
            {
                year++;
                mes = 1;

            }
            else
            {
                mes++;

            }

            dtFechaInicial.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }

        private void btnFinSemAtras_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(2);
            if (mes <= 1)
            {
                year--;
                mes = 12;

            }
            else
            {
                mes--;

            }

            dtFechaFinal.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }

        private void btnFinAtras_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(2);
            if (dia <= 1)
            {
                if (mes <= 1)
                {
                    year--;
                    mes = 12;
                    dia = DateTime.DaysInMonth(year, mes);
                }
                else
                {
                    mes--;
                    dia = DateTime.DaysInMonth(year, mes);
                }
            }
            else
            {
                dia--;
            }
            dtFechaFinal.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }

        private void btnFinAdelante_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(2);
            if (dia >= DateTime.DaysInMonth(year, mes))
            {
                if (mes >= 12)
                {
                    year++;
                    mes = 1;
                    dia = 1;
                }
                else
                {
                    mes++;
                    dia = 1;
                }
            }
            else
            {
                dia++;
            }
            dtFechaFinal.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }

        private void btnFinSemAdelante_Click(object sender, EventArgs e)
        {
            ConseguirFechaInicial(2);
            if (mes >= 12)
            {
                year++;
                mes = 1;

            }
            else
            {
                mes++;

            }

            dtFechaFinal.Value = new DateTime(year, mes, dia);
            llenarHistorial();
        }


       
        private void dtFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            llenarHistorial(); 
        }

        private void dtFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            llenarHistorial();
        }
    }
}


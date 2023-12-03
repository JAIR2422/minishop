using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy_u4.Clases
{
    public class Venta
    {
        private int idVenta;
        private Usuario usuario;
        private string nomCliente;
        private string rfc;
        private string correoC;
        private double montoPago;
        private double montoCambio;
        private double montoTotal;
        private List<DetalleVenta> detalleV;
        private string fechaRegistro;

        

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string RFC { get => rfc; set => rfc = value; }
        public string CorreoCliente { get => correoC; set => correoC = value; }

        public double MontoPago { get => montoPago; set => montoPago = value; }
        public double MontoCambio { get => montoCambio; set => montoCambio = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public List<DetalleVenta> DetalleV { get => detalleV; set => detalleV = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }



        //public static Venta test = new Venta();
       // public static List<Venta> ventas = new List<Venta>() { test };

       // DetalleVenta d = new DetalleVenta();
        

        public Venta(int id,Usuario usuario, string nomCliente, string rfc, string correoC,
            double montoPago, double montoCambio, double montoTotal,
            List<DetalleVenta> detalleV,string fecha)
        {
            this.idVenta = id;
            this.usuario = usuario;
            this.nomCliente = nomCliente;
            this.rfc = rfc;
            this.correoC = correoC;
            this.montoPago = montoPago;
            this.montoCambio = montoCambio;
            this.montoTotal = montoTotal;
            this.detalleV = detalleV;
            this.fechaRegistro = fecha; 
        }
        public Venta( Usuario usuario, string nomCliente, string rfc, string correoC,
            double montoPago, double montoCambio, double montoTotal,
            List<DetalleVenta> detalleV)
        {
            this.usuario = usuario;
            this.nomCliente = nomCliente;
            this.rfc = rfc;
            this.correoC = correoC;
            this.montoPago = montoPago;
            this.montoCambio = montoCambio;
            this.montoTotal = montoTotal;
            this.detalleV = detalleV;
            fechaRegistro = DateTime.Now.Date.ToShortDateString(); 
        }

        public string listaDetalles(int i)
        {
            string s = "";
            switch (i)
            {
                case 1:
                    foreach (var u in detalleV)
                    {
                        s += u.Cantidad + "\n";
                    }
                    break;
                case 2:
                    foreach (var u in detalleV)
                    {
                        s += u.Prod.Desc + "\n";
                    }
                    break;
                case 3:
                    foreach (var u in detalleV)
                    {
                        s += u.SubTotal + "\n";
                    }
                    break;
            }

            return s;
        }

    }
}

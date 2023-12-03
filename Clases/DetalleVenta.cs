using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proy_u4.Clases
{
    public class DetalleVenta
    {
        private int idDetalle;
        private Venta idVenta;
        private Producto prod;
        private double precioVenta;
        private int cantidad;
        private double subTotal;

        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public Venta Venta { get => idVenta; set => idVenta = value; }
        public Producto Prod { get => prod; set => prod = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }

        //public static List<DetalleVenta> detalles = new List<DetalleVenta>();

        public DetalleVenta()
        {
            prod = new Producto();
            precioVenta = 22;
            cantidad = 1;
            subTotal = 22;
        }
        public DetalleVenta(int idDetalle,Venta venta, Producto prod, double precioVenta, int cantidad, double subTotal)
        {
            this.idDetalle= idDetalle;
            this.Venta= venta;
            this.prod = prod;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.subTotal = subTotal;
        }

        public DetalleVenta( Venta venta, Producto prod, double precioVenta, int cantidad, double subTotal)
        {
            this.Venta = venta;
            this.prod = prod;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.subTotal = subTotal;
        }
        public DetalleVenta(int idDetalle, Producto prod, double precioVenta, int cantidad, double subTotal)
        {
            this.idDetalle = idDetalle;
            this.prod = prod;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.subTotal = subTotal;
        }

        public DetalleVenta( Producto prod, double precioVenta, int cantidad, double subTotal)
        {
            this.prod = prod;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.subTotal = subTotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proy_u4
{
    public class Producto
    {
        private int idProd;
        private string desc;
        private string categoria;
        private int stock;
        private double precio;
        private double precioVenta;
        private string foto;

        private static int id = 100001;
        private static void autoIncrementar()
        {
            id++;
        }


        public int IdProd { get => idProd; set => idProd = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Foto { get => foto; set => foto = value; }
        public Producto()
        {
            autoIncrementar();
            idProd = id;
            desc = "Barcel Takis Fuego 200g";
            categoria = "Botana";
            stock = 20;
            precio = 18.00;
            precioVenta = 22.00;
        }
        public Producto(int idProd, string desc, string categoria, int stock, double precio, double precioVenta, string foto)
        {
            this.idProd = idProd;
            this.desc = desc;
            this.categoria = categoria;
            this.stock = stock;
            this.precio = precio;
            this.precioVenta = precioVenta;
            this.foto = foto;
        }

        public Producto(string desc)
        {
            this.desc = desc;
        }

        
    }
}


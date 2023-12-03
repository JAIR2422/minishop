using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy_u4.Clases
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string user;
        private string contrasena;
        private string rol;

        public int Id { get => id; set => id = value; } //para la factura
        public string Nombre { get => nombre; set => nombre = value; } //nombre d la persona
        public string Apellido { get => apellido; set => apellido = value; }
        
        public string User { get => user; set => user = value; } //para el login
        public string Contrasena { get => contrasena; set => contrasena = value; }
       
        public string Rol { get => rol; set => rol = value; }



        public Usuario()
        {
            id = 1;
            nombre = "Sonia";
            apellido = "Romero";
            user = "sonia";
            contrasena = "romero";
            rol = "Admin";

        }

        public Usuario(int id,string nombre,string ap, string correo, string user, string contrasena,string rol)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido= ap;
            this.user = user;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        public Usuario(int id, string nombre, string ap,  string user, string contrasena,string rol)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = ap;
            this.user = user;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        public Usuario(string nombre, string ap)
        {
            this.nombre = nombre;
            this.apellido = ap;
        }


    }
}

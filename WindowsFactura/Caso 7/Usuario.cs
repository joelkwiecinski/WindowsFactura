using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public abstract class Usuario
    {

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }

        public Cliente Cliente { get; set; }

        public Usuario(string apellido, string nombre, string dNI)
        {
            Apellido = apellido;
            Nombre = nombre;
            DNI = dNI;
        }

        public Usuario() { }
    }
}

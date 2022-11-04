using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public class Empleado: Usuario
    {

        public int Legajo { get; set; }
        public List<Factura> Facturas { get; set; }

    }
}

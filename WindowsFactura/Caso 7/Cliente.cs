using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public class Cliente: Usuario
    {

        public Usuario Usuario { get; set; }
        public List<Factura> Facturas { get; set; }

    }
}

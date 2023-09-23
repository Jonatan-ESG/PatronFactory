using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    internal class Entrega
    {
        public string NombreCliente { get; set; }
        public string UbicacionEntrega { get; set; }
        public string CodigoProducto { get; set; }

        public Entrega(string nombreCliente, string ubicacionEntrega, string codigoProducto) { 
            this.NombreCliente = nombreCliente;
            this.UbicacionEntrega = ubicacionEntrega;
            this.CodigoProducto = codigoProducto;
        }
    }
}

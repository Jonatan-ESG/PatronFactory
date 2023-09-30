using PatronFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    internal class LogisiticaMaritima : Logistica
    {
        public LogisiticaMaritima() {
            this.transporteRepartidor = crearTransporte();
        }

        protected override Transporte crearTransporte()
        {
            Barco barcoRepartidor =  new Barco(5000);
            return barcoRepartidor;
        }
    }
}

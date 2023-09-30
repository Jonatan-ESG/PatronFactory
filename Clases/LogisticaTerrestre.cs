using PatronFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    internal class LogisticaTerrestre : Logistica
    {
        public LogisticaTerrestre() {
            this.transporteRepartidor = crearTransporte();
        }
        protected override Transporte crearTransporte()
        {
            Camion camionRepartidor = new Camion("C 768 GFT");
            return camionRepartidor;
        }
    }
}

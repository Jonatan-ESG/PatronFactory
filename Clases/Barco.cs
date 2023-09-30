using PatronFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    internal class Barco : Transporte
    {
        decimal DWT;
        public Barco(decimal dwt) {
            this.DWT = dwt;
        }
        public bool realizarEntrega(Entrega entrega) {
            //Realizar entrega
            return true;
        }
    }
}

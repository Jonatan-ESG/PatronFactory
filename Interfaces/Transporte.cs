using PatronFactory.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Interfaces
{
    internal interface Transporte
    {
        bool realizarEntrega(Entrega entrega);
    }
}

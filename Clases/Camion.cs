﻿using PatronFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    internal class Camion : Transporte
    {
        string Placa;
        public Camion(string placa) { 
            this.Placa = placa;
        }

        public bool realizarEntrega(Entrega entrega) {
            //Lógica de entrega
            return true;
        }
    }
}

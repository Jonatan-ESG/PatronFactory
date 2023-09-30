using PatronFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    abstract class Logistica
    {
        public List<Entrega> entregasPendientes = new List<Entrega>();
        protected Transporte transporteRepartidor;

        protected abstract Transporte crearTransporte();

        public void planificarEntrega(Entrega entrega)
        {
            this.entregasPendientes.Add(entrega);
        }

        public string realizarEntregas() {
            if (this.entregasPendientes.Count == 0)
            {
                return $"No hay entregas pendientes";
            }

            string mensajeEntregas = "";

            foreach (Entrega entrega in this.entregasPendientes.ToList())
            {
                bool estadoEntrega = this.transporteRepartidor.realizarEntrega(entrega);

                if (!estadoEntrega)
                {
                    mensajeEntregas = $"No fue posible realizar la entrega. ";

                    return mensajeEntregas;
                }

                this.entregasPendientes.Remove(entrega);
                mensajeEntregas += $"Se entregó correctamente en la dirección {entrega.UbicacionEntrega}. Desde: {this.transporteRepartidor.GetType().Name}";

            }
            return mensajeEntregas;

        }

        public string obtenerEntregasPendientes()
        {
            string listaEntregasPendientes = "";

            foreach (Entrega entrega in this.entregasPendientes.ToList())
            {
                listaEntregasPendientes += $"Cliente: {entrega.NombreCliente} \n";
            }

            return listaEntregasPendientes;
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory.Clases
{
    internal class Logistica
    {
        DateTime FechaActual;
        List<Entrega> entregasPendientes = new List<Entrega>();
        Camion camionRepartidor = new Camion("C 768 GFT");

        public Logistica() {
            this.FechaActual = DateTime.Now;
        }

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
                bool estadoEntrega = this.camionRepartidor.realizarEntrega(entrega);

                if (!estadoEntrega)
                {
                    mensajeEntregas = $"No fue posible realizar la entrega. ";

                    return mensajeEntregas;
                }

                this.entregasPendientes.Remove(entrega);
                mensajeEntregas += $"Se entregó correctamente en la dirección {entrega.UbicacionEntrega}. ";

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

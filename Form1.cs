using PatronFactory.Clases;

namespace PatronFactory
{
    public partial class Form1 : Form
    {
        Logistica logisticaTerrestre;
        Logistica logisticaMaritima;
        public Form1()
        {
            InitializeComponent();
            this.logisticaTerrestre = new LogisticaTerrestre();
            this.logisticaMaritima = new LogisiticaMaritima();
        }

        private void botonEnvioTerrestre_Click(object sender, EventArgs e)
        {
            string nombreCliente = campoNombreCliente.Text.Trim();
            string ubicacionEntrega = campoUbicacionEntrega.Text.Trim();
            string codigoProducto = campoCodigoProducto.Text.Trim();

            if (nombreCliente == "" || ubicacionEntrega == "" || codigoProducto == "")
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            Entrega entregaDesdeInterfaz = new Entrega(nombreCliente, ubicacionEntrega, codigoProducto);

            this.logisticaTerrestre.planificarEntrega(entregaDesdeInterfaz);

            MessageBox.Show($"Se está coordinando su envío");

            this.actualizarListaEntregasPendientes();

            this.LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            campoNombreCliente.Clear();
            campoUbicacionEntrega.Clear();
            campoCodigoProducto.Clear();
        }

        private void botonRealizarEntregas_Click(object sender, EventArgs e)
        {
            string mensajeTerrestre = this.logisticaTerrestre.realizarEntregas();
            string mensajeMaritimo = this.logisticaMaritima.realizarEntregas();

            this.actualizarListaEntregasPendientes();

            MessageBox.Show($"{mensajeTerrestre}\n{mensajeMaritimo}");

        }

        private void actualizarListaEntregasPendientes()
        {
            listaEntregasPendientes.Text = $"{this.logisticaTerrestre.obtenerEntregasPendientes()}\n{this.logisticaMaritima.obtenerEntregasPendientes()}" ;
        }

        private void botonEnvioMaritimo_Click(object sender, EventArgs e)
        {
            string nombreCliente = campoNombreCliente.Text.Trim();
            string ubicacionEntrega = campoUbicacionEntrega.Text.Trim();
            string codigoProducto = campoCodigoProducto.Text.Trim();

            if (nombreCliente == "" || ubicacionEntrega == "" || codigoProducto == "")
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            Entrega entregaDesdeInterfaz = new Entrega(nombreCliente, ubicacionEntrega, codigoProducto);

            this.logisticaMaritima.planificarEntrega(entregaDesdeInterfaz);

            MessageBox.Show($"Se está coordinando su envío");

            this.actualizarListaEntregasPendientes();

            this.LimpiarFormulario();
        }
    }
}
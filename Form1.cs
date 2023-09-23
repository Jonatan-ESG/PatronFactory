using PatronFactory.Clases;

namespace PatronFactory
{
    public partial class Form1 : Form
    {
        Logistica logistica;
        public Form1()
        {
            InitializeComponent();
            this.logistica = new Logistica();
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

            this.logistica.planificarEntrega(entregaDesdeInterfaz);

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
            string mensaje = this.logistica.realizarEntregas();

            this.actualizarListaEntregasPendientes();

            MessageBox.Show(mensaje);

        }

        private void actualizarListaEntregasPendientes()
        {
            listaEntregasPendientes.Text = this.logistica.obtenerEntregasPendientes(); ;
        }
    }
}
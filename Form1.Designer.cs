namespace PatronFactory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonEnvioTerrestre = new Button();
            label1 = new Label();
            campoNombreCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            campoUbicacionEntrega = new TextBox();
            label4 = new Label();
            campoCodigoProducto = new TextBox();
            botonRealizarEntregas = new Button();
            listaEntregasPendientes = new Label();
            SuspendLayout();
            // 
            // botonEnvioTerrestre
            // 
            botonEnvioTerrestre.Image = Properties.Resources.camion;
            botonEnvioTerrestre.Location = new Point(260, 254);
            botonEnvioTerrestre.Name = "botonEnvioTerrestre";
            botonEnvioTerrestre.Size = new Size(174, 106);
            botonEnvioTerrestre.TabIndex = 0;
            botonEnvioTerrestre.Text = "Envío Terrestre";
            botonEnvioTerrestre.TextAlign = ContentAlignment.BottomCenter;
            botonEnvioTerrestre.UseVisualStyleBackColor = true;
            botonEnvioTerrestre.Click += botonEnvioTerrestre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 10);
            label1.Name = "label1";
            label1.Size = new Size(205, 31);
            label1.TabIndex = 1;
            label1.Text = "Coordinar Entrega";
            // 
            // campoNombreCliente
            // 
            campoNombreCliente.Location = new Point(207, 72);
            campoNombreCliente.Name = "campoNombreCliente";
            campoNombreCliente.PlaceholderText = "Escriba el nombre del cliente";
            campoNombreCliente.Size = new Size(492, 27);
            campoNombreCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 5;
            label3.Text = "Ubicación de Entrega *";
            // 
            // campoUbicacionEntrega
            // 
            campoUbicacionEntrega.Location = new Point(207, 126);
            campoUbicacionEntrega.Name = "campoUbicacionEntrega";
            campoUbicacionEntrega.PlaceholderText = "Escriba la ubicación de entrega";
            campoUbicacionEntrega.Size = new Size(492, 27);
            campoUbicacionEntrega.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 186);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 7;
            label4.Text = "Código Producto *";
            // 
            // campoCodigoProducto
            // 
            campoCodigoProducto.Location = new Point(207, 183);
            campoCodigoProducto.Name = "campoCodigoProducto";
            campoCodigoProducto.PlaceholderText = "Ingrese el código del producto a entregar";
            campoCodigoProducto.Size = new Size(492, 27);
            campoCodigoProducto.TabIndex = 6;
            // 
            // botonRealizarEntregas
            // 
            botonRealizarEntregas.Location = new Point(831, 15);
            botonRealizarEntregas.Name = "botonRealizarEntregas";
            botonRealizarEntregas.Size = new Size(133, 29);
            botonRealizarEntregas.TabIndex = 8;
            botonRealizarEntregas.Text = "Realizar Entregas";
            botonRealizarEntregas.UseVisualStyleBackColor = true;
            botonRealizarEntregas.Click += botonRealizarEntregas_Click;
            // 
            // listaEntregasPendientes
            // 
            listaEntregasPendientes.AutoSize = true;
            listaEntregasPendientes.Location = new Point(798, 72);
            listaEntregasPendientes.Name = "listaEntregasPendientes";
            listaEntregasPendientes.Size = new Size(0, 20);
            listaEntregasPendientes.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 399);
            Controls.Add(listaEntregasPendientes);
            Controls.Add(botonRealizarEntregas);
            Controls.Add(label4);
            Controls.Add(campoCodigoProducto);
            Controls.Add(label3);
            Controls.Add(campoUbicacionEntrega);
            Controls.Add(label2);
            Controls.Add(campoNombreCliente);
            Controls.Add(label1);
            Controls.Add(botonEnvioTerrestre);
            Name = "Form1";
            Text = "Aplicación Logística";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonEnvioTerrestre;
        private Label label1;
        private TextBox campoNombreCliente;
        private Label label2;
        private Label label3;
        private TextBox campoUbicacionEntrega;
        private Label label4;
        private TextBox campoCodigoProducto;
        private Button botonRealizarEntregas;
        private Label listaEntregasPendientes;
    }
}
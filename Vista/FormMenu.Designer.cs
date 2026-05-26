namespace PuntoDeVenta.Vista
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Text = "MarketSoft";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(150, 30);
            this.lblTitulo.Size = new System.Drawing.Size(300, 50);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitulo
            this.lblSubtitulo.Text = "Sistema Punto de Venta";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.Location = new System.Drawing.Point(150, 80);
            this.lblSubtitulo.Size = new System.Drawing.Size(300, 30);
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnProductos
            this.btnProductos.Text = "Productos";
            this.btnProductos.Location = new System.Drawing.Point(60, 160);
            this.btnProductos.Size = new System.Drawing.Size(120, 80);
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // btnClientes
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Location = new System.Drawing.Point(200, 160);
            this.btnClientes.Size = new System.Drawing.Size(120, 80);
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);

            // btnVentas
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Location = new System.Drawing.Point(340, 160);
            this.btnVentas.Size = new System.Drawing.Size(120, 80);
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);

            // btnSalir
            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(480, 160);
            this.btnSalir.Size = new System.Drawing.Size(120, 80);
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // FormMenu
            this.ClientSize = new System.Drawing.Size(660, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnSalir);
            this.Text = "MarketSoft - Sistema Punto de Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
    }
}
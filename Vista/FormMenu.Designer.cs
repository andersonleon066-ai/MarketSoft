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
            this.lblLinea = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Text = "MarketSoft";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTitulo.Location = new System.Drawing.Point(0, 50);
            this.lblTitulo.Size = new System.Drawing.Size(720, 55);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitulo
            this.lblSubtitulo.Text = "— Sistema Punto de Venta —";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 105);
            this.lblSubtitulo.Size = new System.Drawing.Size(720, 25);
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLinea
            this.lblLinea.Text = "";
            this.lblLinea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinea.Location = new System.Drawing.Point(100, 140);
            this.lblLinea.Size = new System.Drawing.Size(520, 2);

            // btnProductos
            this.btnProductos.Text = "Productos";
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProductos.Location = new System.Drawing.Point(90, 165);
            this.btnProductos.Size = new System.Drawing.Size(120, 90);
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // btnClientes
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClientes.Location = new System.Drawing.Point(230, 165);
            this.btnClientes.Size = new System.Drawing.Size(120, 90);
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);

            // btnVentas
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnVentas.Location = new System.Drawing.Point(370, 165);
            this.btnVentas.Size = new System.Drawing.Size(120, 90);
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);

            // btnSalir
            this.btnSalir.Text = "Salir";
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSalir.Location = new System.Drawing.Point(510, 165);
            this.btnSalir.Size = new System.Drawing.Size(120, 90);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // lblFooter
            this.lblFooter.Text = "Desarrollado por equipo MarketSoft  |  2026";
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(0, 290);
            this.lblFooter.Size = new System.Drawing.Size(720, 20);
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormMenu
            this.ClientSize = new System.Drawing.Size(720, 330);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFooter);
            this.Text = "MarketSoft - Sistema Punto de Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFooter;
    }
}
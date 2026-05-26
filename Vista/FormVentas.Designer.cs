namespace PuntoDeVenta.Vista
{
    partial class FormVentas
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblClienteEncontrado = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpiarVenta = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Text = "REGISTRO DE VENTAS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);

            // grpDatos
            this.grpDatos.Text = "Datos de la Venta";
            this.grpDatos.Location = new System.Drawing.Point(12, 50);
            this.grpDatos.Size = new System.Drawing.Size(450, 130);

            // lblDocumento
            this.lblDocumento.Text = "Documento cliente:";
            this.lblDocumento.Location = new System.Drawing.Point(10, 30);
            this.lblDocumento.Size = new System.Drawing.Size(130, 20);

            // txtDocumento
            this.txtDocumento.Location = new System.Drawing.Point(150, 27);
            this.txtDocumento.Size = new System.Drawing.Size(160, 23);

            // btnBuscarCliente
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.Location = new System.Drawing.Point(320, 25);
            this.btnBuscarCliente.Size = new System.Drawing.Size(120, 27);
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);

            // lblClienteEncontrado
            this.lblClienteEncontrado.Text = "Cliente: ";
            this.lblClienteEncontrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClienteEncontrado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClienteEncontrado.Location = new System.Drawing.Point(10, 65);
            this.lblClienteEncontrado.Size = new System.Drawing.Size(430, 20);

            // lblIdProducto
            this.lblIdProducto.Text = "ID Producto:";
            this.lblIdProducto.Location = new System.Drawing.Point(10, 100);
            this.lblIdProducto.Size = new System.Drawing.Size(130, 20);

            // txtIdProducto
            this.txtIdProducto.Location = new System.Drawing.Point(150, 97);
            this.txtIdProducto.Size = new System.Drawing.Size(160, 23);

            this.grpDatos.Controls.Add(this.lblDocumento);
            this.grpDatos.Controls.Add(this.txtDocumento);
            this.grpDatos.Controls.Add(this.btnBuscarCliente);
            this.grpDatos.Controls.Add(this.lblClienteEncontrado);
            this.grpDatos.Controls.Add(this.lblIdProducto);
            this.grpDatos.Controls.Add(this.txtIdProducto);

            // grpAcciones
            this.grpAcciones.Text = "Acciones";
            this.grpAcciones.Location = new System.Drawing.Point(475, 50);
            this.grpAcciones.Size = new System.Drawing.Size(150, 130);

            // btnAgregarProducto
            this.btnAgregarProducto.Text = "+ Agregar Producto";
            this.btnAgregarProducto.Location = new System.Drawing.Point(10, 25);
            this.btnAgregarProducto.Size = new System.Drawing.Size(125, 30);
            this.btnAgregarProducto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);

            // btnQuitarProducto
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.Location = new System.Drawing.Point(10, 60);
            this.btnQuitarProducto.Size = new System.Drawing.Size(125, 30);
            this.btnQuitarProducto.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);

            // btnRegistrarVenta
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.Location = new System.Drawing.Point(10, 95);
            this.btnRegistrarVenta.Size = new System.Drawing.Size(125, 30);
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);

            // btnMostrarVentas
            this.btnMostrarVentas.Text = "Mostrar Ventas";
            this.btnMostrarVentas.Location = new System.Drawing.Point(10, 130);
            this.btnMostrarVentas.Size = new System.Drawing.Size(125, 30);
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);

            this.grpAcciones.Controls.Add(this.btnAgregarProducto);
            this.grpAcciones.Controls.Add(this.btnQuitarProducto);
            this.grpAcciones.Controls.Add(this.btnRegistrarVenta);
            this.grpAcciones.Controls.Add(this.btnMostrarVentas);

            // lblProductos
            this.lblProductos.Text = "Productos de la Venta";
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductos.Location = new System.Drawing.Point(12, 195);
            this.lblProductos.Size = new System.Drawing.Size(200, 20);

            // dgvProductosVenta
            this.dgvProductosVenta.Location = new System.Drawing.Point(12, 220);
            this.dgvProductosVenta.Size = new System.Drawing.Size(613, 180);
            this.dgvProductosVenta.AllowUserToAddRows = false;
            this.dgvProductosVenta.ReadOnly = true;
            this.dgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosVenta.Columns.Add("ID", "ID");
            this.dgvProductosVenta.Columns.Add("Producto", "Producto");
            this.dgvProductosVenta.Columns.Add("Precio", "Precio");
            this.dgvProductosVenta.Columns.Add("Subtotal", "Subtotal");

            // lblTotal
            this.lblTotal.Text = "Total: $0";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotal.Location = new System.Drawing.Point(400, 410);
            this.lblTotal.Size = new System.Drawing.Size(220, 30);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnLimpiarVenta
            this.btnLimpiarVenta.Text = "Limpiar Venta";
            this.btnLimpiarVenta.Location = new System.Drawing.Point(12, 410);
            this.btnLimpiarVenta.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiarVenta.Click += new System.EventHandler(this.btnLimpiarVenta_Click);

            // FormVentas
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.dgvProductosVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimpiarVenta);
            this.Text = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.grpDatos.ResumeLayout(false);
            this.grpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblClienteEncontrado;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnMostrarVentas;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpiarVenta;
    }
}
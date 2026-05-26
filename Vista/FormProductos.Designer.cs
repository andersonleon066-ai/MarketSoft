namespace PuntoDeVenta.Vista
{
    partial class FormProductos
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.grpDatos.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Text = "GESTIÓN DE PRODUCTOS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);

            // grpDatos
            this.grpDatos.Text = "Datos del Producto";
            this.grpDatos.Location = new System.Drawing.Point(12, 50);
            this.grpDatos.Size = new System.Drawing.Size(400, 160);

            // lblId
            this.lblId.Text = "ID:";
            this.lblId.Location = new System.Drawing.Point(10, 30);
            this.lblId.Size = new System.Drawing.Size(80, 20);

            // txtId
            this.txtId.Location = new System.Drawing.Point(100, 27);
            this.txtId.Size = new System.Drawing.Size(280, 23);

            // lblNombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(10, 65);
            this.lblNombre.Size = new System.Drawing.Size(80, 20);

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(100, 62);
            this.txtNombre.Size = new System.Drawing.Size(280, 23);

            // lblPrecio
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Location = new System.Drawing.Point(10, 100);
            this.lblPrecio.Size = new System.Drawing.Size(80, 20);

            // txtPrecio
            this.txtPrecio.Location = new System.Drawing.Point(100, 97);
            this.txtPrecio.Size = new System.Drawing.Size(280, 23);

            // lblStock
            this.lblStock.Text = "Stock:";
            this.lblStock.Location = new System.Drawing.Point(10, 135);
            this.lblStock.Size = new System.Drawing.Size(80, 20);

            // txtStock
            this.txtStock.Location = new System.Drawing.Point(100, 132);
            this.txtStock.Size = new System.Drawing.Size(280, 23);

            this.grpDatos.Controls.Add(this.lblId);
            this.grpDatos.Controls.Add(this.txtId);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Controls.Add(this.lblStock);
            this.grpDatos.Controls.Add(this.txtStock);

            // grpAcciones
            this.grpAcciones.Text = "Acciones";
            this.grpAcciones.Location = new System.Drawing.Point(430, 50);
            this.grpAcciones.Size = new System.Drawing.Size(150, 160);

            // btnAgregar
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(10, 25);
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnEliminar
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(10, 65);
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // btnLimpiar
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(10, 105);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnMostrar
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.Location = new System.Drawing.Point(10, 140);
            this.btnMostrar.Size = new System.Drawing.Size(120, 30);
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);

            this.grpAcciones.Controls.Add(this.btnAgregar);
            this.grpAcciones.Controls.Add(this.btnEliminar);
            this.grpAcciones.Controls.Add(this.btnLimpiar);
            this.grpAcciones.Controls.Add(this.btnMostrar);

            // lblLista
            this.lblLista.Text = "Lista de Productos";
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLista.Location = new System.Drawing.Point(12, 225);
            this.lblLista.Size = new System.Drawing.Size(200, 20);

            // dgvProductos
            this.dgvProductos.Location = new System.Drawing.Point(12, 250);
            this.dgvProductos.Size = new System.Drawing.Size(568, 200);
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.Columns.Add("ID", "ID");
            this.dgvProductos.Columns.Add("Nombre", "Nombre");
            this.dgvProductos.Columns.Add("Precio", "Precio");
            this.dgvProductos.Columns.Add("Stock", "Stock");

            // FormProductos
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.dgvProductos);
            this.Text = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.grpDatos.ResumeLayout(false);
            this.grpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}
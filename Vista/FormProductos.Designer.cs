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
            this.lblLinea = new System.Windows.Forms.Label();
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
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Size = new System.Drawing.Size(760, 35);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblLinea
            this.lblLinea.Text = "";
            this.lblLinea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinea.Location = new System.Drawing.Point(12, 52);
            this.lblLinea.Size = new System.Drawing.Size(760, 2);

            // grpDatos
            this.grpDatos.Text = "Datos del Producto";
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.Location = new System.Drawing.Point(12, 65);
            this.grpDatos.Size = new System.Drawing.Size(580, 160);

            // lblId
            this.lblId.Text = "ID:";
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblId.Location = new System.Drawing.Point(15, 35);
            this.lblId.Size = new System.Drawing.Size(80, 20);

            // txtId
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(110, 32);
            this.txtId.Size = new System.Drawing.Size(440, 23);

            // lblNombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(15, 70);
            this.lblNombre.Size = new System.Drawing.Size(80, 20);

            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(110, 67);
            this.txtNombre.Size = new System.Drawing.Size(440, 23);

            // lblPrecio
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecio.Location = new System.Drawing.Point(15, 105);
            this.lblPrecio.Size = new System.Drawing.Size(80, 20);

            // txtPrecio
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(110, 102);
            this.txtPrecio.Size = new System.Drawing.Size(200, 23);

            // lblStock
            this.lblStock.Text = "Stock:";
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStock.Location = new System.Drawing.Point(330, 105);
            this.lblStock.Size = new System.Drawing.Size(60, 20);

            // txtStock
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStock.Location = new System.Drawing.Point(400, 102);
            this.txtStock.Size = new System.Drawing.Size(150, 23);

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
            this.grpAcciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAcciones.Location = new System.Drawing.Point(610, 65);
            this.grpAcciones.Size = new System.Drawing.Size(162, 160);

            // btnAgregar
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.Location = new System.Drawing.Point(15, 25);
            this.btnAgregar.Size = new System.Drawing.Size(130, 30);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnEliminar
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.Location = new System.Drawing.Point(15, 63);
            this.btnEliminar.Size = new System.Drawing.Size(130, 30);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // btnLimpiar
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.Location = new System.Drawing.Point(15, 101);
            this.btnLimpiar.Size = new System.Drawing.Size(130, 30);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnMostrar
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrar.Location = new System.Drawing.Point(15, 135);
            this.btnMostrar.Size = new System.Drawing.Size(130, 30);
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);

            this.grpAcciones.Controls.Add(this.btnAgregar);
            this.grpAcciones.Controls.Add(this.btnEliminar);
            this.grpAcciones.Controls.Add(this.btnLimpiar);
            this.grpAcciones.Controls.Add(this.btnMostrar);

            // lblLista
            this.lblLista.Text = "Lista de Productos";
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLista.Location = new System.Drawing.Point(12, 240);
            this.lblLista.Size = new System.Drawing.Size(200, 22);

            // dgvProductos
            this.dgvProductos.Location = new System.Drawing.Point(12, 265);
            this.dgvProductos.Size = new System.Drawing.Size(760, 220);
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProductos.Columns.Add("ID", "ID");
            this.dgvProductos.Columns.Add("Nombre", "Nombre");
            this.dgvProductos.Columns.Add("Precio", "Precio");
            this.dgvProductos.Columns.Add("Stock", "Stock");

            // FormProductos
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.dgvProductos);
            this.Text = "Productos";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.grpDatos.ResumeLayout(false);
            this.grpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLinea;
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
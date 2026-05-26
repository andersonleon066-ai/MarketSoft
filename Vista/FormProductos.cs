using System;
using System.Windows.Forms;
using PuntoDeVenta.Modelo;
using PuntoDeVenta.Servicios;
using PuntoDeVenta.Utilidades;

namespace PuntoDeVenta.Vista
{
    public partial class FormProductos : Form
    {
        private ServicioProducto servicioProducto;

        public FormProductos(ServicioProducto servicioProducto)
        {
            InitializeComponent();
            this.servicioProducto = servicioProducto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string idTexto = txtId.Text;
            string precioTexto = txtPrecio.Text;
            string stockTexto = txtStock.Text;

            if (!Validador.ValidarTexto(nombre) || !Validador.ValidarTexto(idTexto) ||
                !Validador.ValidarTexto(precioTexto) || !Validador.ValidarTexto(stockTexto))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id;
            double precio;
            int stock;

            if (!int.TryParse(idTexto, out id) || !double.TryParse(precioTexto, out precio) || !int.TryParse(stockTexto, out stock))
            {
                MessageBox.Show("ID, precio y stock deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validador.ValidarNumeroPositivo(precio) || !Validador.ValidarStock(stock))
            {
                MessageBox.Show("El precio debe ser mayor a cero y el stock no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = new Producto(id, nombre, precio, stock);
            servicioProducto.AgregarProducto(producto);

            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            MostrarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idTexto = txtId.Text;

            if (!Validador.ValidarTexto(idTexto))
            {
                MessageBox.Show("Ingrese el ID del producto a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id;
            if (!int.TryParse(idTexto, out id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool eliminado = servicioProducto.EliminarProducto(id);

            if (eliminado)
            {
                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void MostrarProductos()
        {
            dgvProductos.Rows.Clear();

            foreach (Producto p in servicioProducto.ObtenerProductos())
            {
                dgvProductos.Rows.Add(p.Id, p.Nombre, p.Precio, p.Stock);
            }
        }
    }
    
}
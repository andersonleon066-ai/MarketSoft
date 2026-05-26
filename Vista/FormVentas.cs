using System;
using System.Windows.Forms;
using PuntoDeVenta.Modelo;
using PuntoDeVenta.Servicios;
using PuntoDeVenta.Utilidades;

namespace PuntoDeVenta.Vista
{
    public partial class FormVentas : Form
    {
        private ServicioVenta servicioVenta;
        private ServicioCliente servicioCliente;
        private ServicioProducto servicioProducto;
        private Venta ventaActual;

        public FormVentas(ServicioVenta servicioVenta, ServicioCliente servicioCliente, ServicioProducto servicioProducto)
        {
            InitializeComponent();
            this.servicioVenta = servicioVenta;
            this.servicioCliente = servicioCliente;
            this.servicioProducto = servicioProducto;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;

            if (!Validador.ValidarTexto(documento))
            {
                MessageBox.Show("Ingrese el documento del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = servicioCliente.BuscarCliente(documento);

            if (cliente != null)
            {
                lblClienteEncontrado.Text = "Cliente: " + cliente.Nombre;

                Cajero cajero = new Cajero("Juan Pérez", "12345", 25, 1500000, "Mañana");
                ventaActual = new Venta(servicioVenta.ObtenerSiguienteId(), cliente, cajero);

                MessageBox.Show("Cliente encontrado. Ya puede agregar productos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ventaActual == null)
            {
                MessageBox.Show("Primero busque un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idTexto = txtIdProducto.Text;

            if (!Validador.ValidarTexto(idTexto))
            {
                MessageBox.Show("Ingrese el ID del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id;
            if (!int.TryParse(idTexto, out id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = servicioProducto.BuscarProducto(id);

            if (producto != null)
            {
                ventaActual.AgregarProducto(producto);
                MostrarProductosVenta();
                lblTotal.Text = "Total: $" + ventaActual.CalcularTotal();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (ventaActual == null || ventaActual.Productos.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvProductosVenta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para quitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = dgvProductosVenta.SelectedRows[0].Index;
            Producto producto = ventaActual.Productos[index];
            ventaActual.EliminarProducto(producto);

            MostrarProductosVenta();
            lblTotal.Text = "Total: $" + ventaActual.CalcularTotal();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (ventaActual == null || ventaActual.Productos.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            servicioVenta.RegistrarVenta(ventaActual);
            MessageBox.Show("Venta registrada correctamente. Total: $" + ventaActual.CalcularTotal(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarVenta();
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            string resumen = "";
            foreach (Venta v in servicioVenta.ObtenerVentas())
            {
                resumen += "Venta #" + v.IdVenta + " - Cliente: " + v.Cliente.Nombre + " - Total: $" + v.CalcularTotal() + "\n";
            }

            if (resumen == "")
            {
                MessageBox.Show("No hay ventas registradas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resumen, "Ventas registradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarVenta_Click(object sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void MostrarProductosVenta()
        {
            dgvProductosVenta.Rows.Clear();

            foreach (Producto p in ventaActual.Productos)
            {
                dgvProductosVenta.Rows.Add(p.Id, p.Nombre, p.Precio, p.Precio + p.CalcularIVA());
            }
        }

        private void LimpiarVenta()
        {
            ventaActual = null;
            txtDocumento.Text = "";
            txtIdProducto.Text = "";
            lblClienteEncontrado.Text = "Cliente: ";
            lblTotal.Text = "Total: $0";
            dgvProductosVenta.Rows.Clear();
        }
    }
}
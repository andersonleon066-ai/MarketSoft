using System;
using System.Windows.Forms;
using PuntoDeVenta.Servicios;

namespace PuntoDeVenta.Vista
{
    public partial class FormMenu : Form
    {
        private ServicioCliente servicioCliente;
        private ServicioProducto servicioProducto;
        private ServicioVenta servicioVenta;

        public FormMenu()
        {
            InitializeComponent();
            servicioCliente = new ServicioCliente();
            servicioProducto = new ServicioProducto();
            servicioVenta = new ServicioVenta();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos(servicioProducto);
            formProductos.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(servicioCliente);
            formClientes.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas(servicioVenta, servicioCliente, servicioProducto);
            formVentas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
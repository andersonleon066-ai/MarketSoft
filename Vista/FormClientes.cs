 using System;
using System.Windows.Forms;
using PuntoDeVenta.Modelo;
using PuntoDeVenta.Servicios;
using PuntoDeVenta.Utilidades;

namespace PuntoDeVenta.Vista
{
    public partial class FormClientes : Form
    {
        private ServicioCliente servicioCliente;

        public FormClientes(ServicioCliente servicioCliente)
        {
            InitializeComponent();
            this.servicioCliente = servicioCliente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            string nombre = txtNombre.Text;
            string edadTexto = txtEdad.Text;

            if (!Validador.ValidarTexto(documento) || !Validador.ValidarTexto(nombre) || !Validador.ValidarTexto(edadTexto))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int edad;
            if (!int.TryParse(edadTexto, out edad))
            {
                MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validador.ValidarEdad(edad))
            {
                MessageBox.Show("La edad debe estar entre 18 y 100 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = new Cliente(nombre, documento, edad, 0);
            servicioCliente.AgregarCliente(cliente);

            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            MostrarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;

            if (!Validador.ValidarTexto(documento))
            {
                MessageBox.Show("Ingrese el documento del cliente a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool eliminado = servicioCliente.EliminarCliente(documento);

            if (eliminado)
            {
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarClientes();
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void LimpiarCampos()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
        }

        private void MostrarClientes()
        {
            dgvClientes.Rows.Clear();

            foreach (Cliente c in servicioCliente.ObtenerClientes())
            {
                dgvClientes.Rows.Add(c.Documento, c.Nombre, c.Edad, c.Puntos);
            }
        }
    }
}
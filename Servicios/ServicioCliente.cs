using PuntoDeVenta.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace PuntoDeVenta.Servicios
{
    public class ServicioCliente
    {
        // Lista de clientes
        private List<Cliente> clientes;

        // Constructor
        public ServicioCliente()
        {
            clientes = new List<Cliente>();
        }

        // CREATE
        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        // READ
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        // SEARCH
        public Cliente BuscarCliente(string documento)
        {
            return clientes.FirstOrDefault(c => c.Documento == documento);
        }

        // DELETE
        public bool EliminarCliente(string documento)
        {
            Cliente cliente = BuscarCliente(documento);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                return true;
            }

            return false;
        }

        // Mostrar clientes
        public void MostrarClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                cliente.MostrarInfo();
            }
        }
    }
}
using PuntoDeVenta.Modelo;
using System.Collections.Generic;

namespace PuntoDeVenta.Servicios
{
    public class ServicioCliente
    {
        private List<Cliente> clientes;

        public ServicioCliente()
        {
            clientes = new List<Cliente>();
        }

        // CREATE
        public void AgregarCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                clientes.Add(cliente);
                Console.WriteLine("Cliente agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: El cliente no puede ser nulo.");
            }
        }

        // READ
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        // SEARCH
        public Cliente BuscarCliente(string documento)
        {
            foreach (Cliente c in clientes)
            {
                if (c.Documento == documento)
                {
                    return c;
                }
            }
            Console.WriteLine("Cliente no encontrado.");
            return null;
        }

        // DELETE
        public bool EliminarCliente(string documento)
        {
            Cliente cliente = BuscarCliente(documento);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente eliminado correctamente.");
                return true;
            }

            return false;
        }

        // Mostrar clientes
        public void MostrarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                foreach (Cliente c in clientes)
                {
                    c.MostrarInfo();
                }
            }
        }
    }
}
using PuntoDeVenta.Modelo;
using System.Collections.Generic;

namespace PuntoDeVenta.Servicios
{
    public class ServicioCajero
    {
        private List<Cajero> cajeros;

        public ServicioCajero()
        {
            cajeros = new List<Cajero>();
        }

        // CREATE
        public void AgregarCajero(Cajero cajero)
        {
            if (cajero != null)
            {
                cajeros.Add(cajero);
                Console.WriteLine("Cajero agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: El cajero no puede ser nulo.");
            }
        }

        // READ
        public List<Cajero> ObtenerCajeros()
        {
            return cajeros;
        }

        // SEARCH
        public Cajero BuscarCajero(string documento)
        {
            foreach (Cajero c in cajeros)
            {
                if (c.Documento == documento)
                {
                    return c;
                }
            }
            Console.WriteLine("Cajero no encontrado.");
            return null;
        }

        // DELETE
        public bool EliminarCajero(string documento)
        {
            Cajero cajero = BuscarCajero(documento);

            if (cajero != null)
            {
                cajeros.Remove(cajero);
                Console.WriteLine("Cajero eliminado correctamente.");
                return true;
            }

            return false;
        }

        // Mostrar cajeros
        public void MostrarCajeros()
        {
            if (cajeros.Count == 0)
            {
                Console.WriteLine("No hay cajeros registrados.");
            }
            else
            {
                foreach (Cajero c in cajeros)
                {
                    c.MostrarInfo();
                }
            }
        }
    }
}
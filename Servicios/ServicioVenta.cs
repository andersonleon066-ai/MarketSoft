using PuntoDeVenta.Modelo;
using System.Collections.Generic;

namespace PuntoDeVenta.Servicios
{
    public class ServicioVenta
    {
        private List<Venta> ventas;
        private int contadorId;

        public ServicioVenta()
        {
            ventas = new List<Venta>();
            contadorId = 1;
        }

        // CREATE
        public void RegistrarVenta(Venta venta)
        {
            if (venta != null)
            {
                ventas.Add(venta);
                contadorId++;
                Console.WriteLine("Venta registrada correctamente.");
            }
            else
            {
                Console.WriteLine("Error: La venta no puede ser nula.");
            }
        }

        // READ
        public List<Venta> ObtenerVentas()
        {
            return ventas;
        }

        // Obtener siguiente ID disponible
        public int ObtenerSiguienteId()
        {
            return contadorId;
        }

        // Mostrar ventas
        public void MostrarVentas()
        {
            if (ventas.Count == 0)
            {
                Console.WriteLine("No hay ventas registradas.");
            }
            else
            {
                foreach (Venta v in ventas)
                {
                    v.MostrarResumen();
                }
            }
        }
    }
}
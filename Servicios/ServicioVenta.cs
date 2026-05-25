using PuntoDeVenta.Modelo;
using System.Collections.Generic;

namespace PuntoDeVenta.Servicios
{
    public class ServicioVenta
    {
        // Lista de ventas
        private List<Venta> ventas;

        // Constructor
        public ServicioVenta()
        {
            ventas = new List<Venta>();
        }

        // CREATE
        public void RegistrarVenta(Venta venta)
        {
            ventas.Add(venta);
        }

        // READ
        public List<Venta> ObtenerVentas()
        {
            return ventas;
        }

        // Mostrar ventas
        public void MostrarVentas()
        {
            foreach (Venta venta in ventas)
            {
                venta.MostrarResumen();
            }
        }
    }
}
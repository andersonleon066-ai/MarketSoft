using PuntoDeVenta.Modelo;
using System.Collections.Generic;

namespace PuntoDeVenta.Servicios
{
    public class ServicioProducto
    {
        private List<Producto> productos;

        public ServicioProducto()
        {
            productos = new List<Producto>();
        }

        // CREATE
        public void AgregarProducto(Producto producto)
        {
            if (producto != null)
            {
                productos.Add(producto);
                Console.WriteLine("Producto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: El producto no puede ser nulo.");
            }
        }

        // READ
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        // SEARCH
        public Producto BuscarProducto(int id)
        {
            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            Console.WriteLine("Producto no encontrado.");
            return null;
        }

        // DELETE
        public bool EliminarProducto(int id)
        {
            Producto producto = BuscarProducto(id);

            if (producto != null)
            {
                productos.Remove(producto);
                Console.WriteLine("Producto eliminado correctamente.");
                return true;
            }

            return false;
        }

        // Mostrar productos
        public void MostrarProductos()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                foreach (Producto p in productos)
                {
                    p.MostrarInfo();
                }
            }
        }
    }
}
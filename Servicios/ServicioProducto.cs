using PuntoDeVenta.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace PuntoDeVenta.Servicios
{
    public class ServicioProducto
    {
        // Lista de productos
        private List<Producto> productos;

        // Constructor
        public ServicioProducto()
        {
            productos = new List<Producto>();
        }

        // CREATE
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        // READ
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        // SEARCH
        public Producto BuscarProducto(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

        // DELETE
        public bool EliminarProducto(int id)
        {
            Producto producto = BuscarProducto(id);

            if (producto != null)
            {
                productos.Remove(producto);
                return true;
            }

            return false;
        }

        // Mostrar productos
        public void MostrarProductos()
        {
            foreach (Producto producto in productos)
            {
                producto.MostrarInfo();
            }
        }
    }
}
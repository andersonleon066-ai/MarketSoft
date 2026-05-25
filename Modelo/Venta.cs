using System;
using System.Collections.Generic;

namespace PuntoDeVenta.Modelo
{
    public class Venta
    {
        private int idVenta;
        private Cliente cliente;
        private Cajero cajero;
        private List<Producto> productos;
        private DateTime fecha;

        public int IdVenta { get { return idVenta; } }
        public Cliente Cliente { get { return cliente; } }
        public Cajero Cajero { get { return cajero; } }
        public List<Producto> Productos { get { return productos; } }

        public Venta(int idVenta, Cliente cliente, Cajero cajero)
        {
            this.idVenta = idVenta;
            this.cliente = cliente;
            this.cajero = cajero;
            this.productos = new List<Producto>();
            this.fecha = DateTime.Now;
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto.Stock > 0)
            {
                productos.Add(producto);
                producto.DescontarStock(1);
                Console.WriteLine("Producto agregado: " + producto.Nombre);
            }
            else
            {
                Console.WriteLine("Error: El producto " + producto.Nombre + " no tiene stock.");
            }
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.Precio + producto.CalcularIVA();
            }
            return total;
        }

        public void MostrarResumen()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Venta #" + this.idVenta);
            Console.WriteLine("Fecha: " + this.fecha);
            Console.WriteLine("Cliente: " + this.cliente.Nombre);
            Console.WriteLine("Cajero: " + this.cajero.Nombre);
            Console.WriteLine("Turno: " + this.cajero.Turno);
            Console.WriteLine("--- Productos ---");
            foreach (Producto p in productos)
            {
                Console.WriteLine("- " + p.Nombre + ": " + (p.Precio + p.CalcularIVA()));
            }
            Console.WriteLine("Total: " + CalcularTotal());
        }
    }
}
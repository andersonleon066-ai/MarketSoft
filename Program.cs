using System;

class Program
{
    static void Main(string[] args)
    {
        Producto producto =
            new Producto(1, "Gaseosa", 5000, 20);

        Cliente cliente =
            new Cliente(1, "Sara", "3001234567");

        Cajero cajero =
            new Cajero(1, "Carlos", "3019876543",
                        2000000, "Mañana");

        Venta venta =
            new Venta(1, cliente, producto,
                      cajero, 2);

        venta.MostrarVenta();

        cajero.CobrarVenta();
    }
}
using System;

public class Venta
{
    private int idVenta;
    private Cliente cliente;
    private Producto producto;
    private Cajero cajero;
    private int cantidad;

    public Venta(int idVenta, Cliente cliente,
                 Producto producto, Cajero cajero,
                 int cantidad)
    {
        this.idVenta = idVenta;
        this.cliente = cliente;
        this.producto = producto;
        this.cajero = cajero;
        this.cantidad = cantidad;
    }

    public double CalcularTotal()
    {
        return producto.GetPrecio() * cantidad;
    }

    public void MostrarVenta()
    {
        Console.WriteLine("===== FACTURA =====");

        cliente.MostrarCliente();

        producto.MostrarProducto();

        cajero.MostrarCajero();

        Console.WriteLine("Cantidad: " + cantidad);

        Console.WriteLine("Total: " + CalcularTotal());
    }
}
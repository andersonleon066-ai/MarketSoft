using System;

public class Producto
{
    private int id;
    private string nombre;
    private double precio;
    private int stock;

    public Producto(int id, string nombre,
                    double precio, int stock)
    {
        this.id = id;
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
    }

    public double GetPrecio()
    {
        return precio;
    }

    public void MostrarProducto()
    {
        Console.WriteLine("=== PRODUCTO ===");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: " + precio);
        Console.WriteLine("Stock: " + stock);
    }
}
using System;

public class Cajero : Empleado
{
    private string turno;

    public Cajero(int id, string nombre,
                  string telefono, double salario,
                  string turno)
        : base(id, nombre, telefono, salario)
    {
        this.turno = turno;
    }

    public void CobrarVenta()
    {
        Console.WriteLine(nombre + " está cobrando una venta.");
    }

    public void MostrarCajero()
    {
        Console.WriteLine("=== CAJERO ===");
        MostrarEmpleado();
        Console.WriteLine("Turno: " + turno);
    }
}
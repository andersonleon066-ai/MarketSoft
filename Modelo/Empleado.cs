using System;

public class Empleado : Persona
{
    protected double salario;

    public Empleado(int id, string nombre,
                    string telefono, double salario)
        : base(id, nombre, telefono)
    {
        this.salario = salario;
    }

    public void MostrarEmpleado()
    {
        Console.WriteLine("=== EMPLEADO ===");
        MostrarPersona();
        Console.WriteLine("Salario: " + salario);
    }
}
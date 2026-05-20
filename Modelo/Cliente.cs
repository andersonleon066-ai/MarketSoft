using System;

public class Cliente : Persona
{
    public Cliente(int id, string nombre, string telefono)
        : base(id, nombre, telefono)
    {
    }

    public void MostrarCliente()
    {
        Console.WriteLine("=== CLIENTE ===");
        MostrarPersona();
    }
}
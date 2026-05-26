using PuntoDeVenta.Modelo;
using System.Collections.Generic;

namespace PuntoDeVenta.Servicios
{
    public class ServicioEmpleado
    {
        private List<Empleado> empleados;

        public ServicioEmpleado()
        {
            empleados = new List<Empleado>();
        }

        // CREATE
        public void AgregarEmpleado(Empleado empleado)
        {
            if (empleado != null)
            {
                empleados.Add(empleado);
                Console.WriteLine("Empleado agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: El empleado no puede ser nulo.");
            }
        }

        // READ
        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

        // SEARCH
        public Empleado BuscarEmpleado(string documento)
        {
            foreach (Empleado e in empleados)
            {
                if (e.Documento == documento)
                {
                    return e;
                }
            }
            Console.WriteLine("Empleado no encontrado.");
            return null;
        }

        // DELETE
        public bool EliminarEmpleado(string documento)
        {
            Empleado empleado = BuscarEmpleado(documento);

            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado eliminado correctamente.");
                return true;
            }

            return false;
        }

        // Mostrar empleados
        public void MostrarEmpleados()
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
            }
            else
            {
                foreach (Empleado e in empleados)
                {
                    e.MostrarInfo();
                }
            }
        }
    }
}
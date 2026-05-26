namespace PuntoDeVenta.Utilidades
{
    public static class Validador
    {
        // Validar texto
        public static bool ValidarTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("Error: El campo no puede estar vacío.");
                return false;
            }
            return true;
        }

        // Validar números positivos
        public static bool ValidarNumeroPositivo(double numero)
        {
            if (numero <= 0)
            {
                Console.WriteLine("Error: El número debe ser mayor a cero.");
                return false;
            }
            return true;
        }

        // Validar edad
        public static bool ValidarEdad(int edad)
        {
            if (edad < 18 || edad > 100)
            {
                Console.WriteLine("Error: La edad debe estar entre 18 y 100 años.");
                return false;
            }
            return true;
        }

        // Validar stock
        public static bool ValidarStock(int stock)
        {
            if (stock < 0)
            {
                Console.WriteLine("Error: El stock no puede ser negativo.");
                return false;
            }
            return true;
        }

        // Validar documento
        public static bool ValidarDocumento(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento))
            {
                Console.WriteLine("Error: El documento no puede estar vacío.");
                return false;
            }
            if (documento.Length < 6 || documento.Length > 15)
            {
                Console.WriteLine("Error: El documento debe tener entre 6 y 15 caracteres.");
                return false;
            }
            return true;
        }

        // Validar turno
        public static bool ValidarTurno(string turno)
        {
            if (turno == "Mañana" || turno == "Tarde" || turno == "Noche")
            {
                return true;
            }
            Console.WriteLine("Error: El turno debe ser Mañana, Tarde o Noche.");
            return false;
        }
    }
}
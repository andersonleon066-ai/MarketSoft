namespace PuntoDeVenta.Utilidades
{
    public static class Validador
    {
        // Validar texto
        public static bool ValidarTexto(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        // Validar números positivos
        public static bool ValidarNumeroPositivo(double numero)
        {
            return numero > 0;
        }

        // Validar edad
        public static bool ValidarEdad(int edad)
        {
            return edad >= 18 && edad <= 100;
        }

        // Validar stock
        public static bool ValidarStock(int stock)
        {
            return stock >= 0;
        }
    }
}
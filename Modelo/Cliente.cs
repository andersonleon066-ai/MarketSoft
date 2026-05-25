namespace PuntoDeVenta.Modelo
{
    public class Cliente : Persona
    {
        private int puntos;

        public int Puntos
        {
            get { return puntos; }
            set
            {
                if (value >= 0)
                {
                    puntos = value;
                }
                else
                {
                    Console.WriteLine("Error: Los puntos no pueden ser negativos.");
                }
            }
        }

        public Cliente(string nombre, string documento, int edad, int puntos)
            : base(nombre, documento, edad)
        {
            this.Puntos = puntos;
        }

        public void AcumularPuntos(int cantidad)
        {
            if (cantidad > 0)
            {
                puntos += cantidad;
                Console.WriteLine("Puntos acumulados: " + puntos);
            }
            else
            {
                Console.WriteLine("Error: La cantidad debe ser mayor a cero.");
            }
        }

        public override string MostrarRol()
        {
            return "Cliente";
        }
    }
}

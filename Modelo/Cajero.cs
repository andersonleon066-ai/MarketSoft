namespace PuntoDeVenta.Modelo
{
    public class Cajero : Empleado
    {
        private string turno;

        public string Turno
        {
            get { return turno; }
            set
            {
                if (value == "Mañana" || value == "Tarde" || value == "Noche")
                {
                    turno = value;
                }
                else
                {
                    Console.WriteLine("Error: El turno debe ser Mañana, Tarde o Noche.");
                }
            }
        }

        public Cajero(string nombre, string documento, int edad, double salario, string turno)
            : base(nombre, documento, edad, salario, "Cajero")
        {
            this.Turno = turno;
        }

        public override string MostrarRol()
        {
            return "Cajero";
        }
    }
}
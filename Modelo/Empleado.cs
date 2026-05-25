namespace PuntoDeVenta.Modelo
{
    public class Empleado : Persona
    {
        protected double salario;
        protected string cargo;

        public double Salario
        {
            get { return salario; }
            set
            {
                if (value > 0)
                {
                    salario = value;
                }
                else
                {
                    Console.WriteLine("Error: El salario debe ser mayor a cero.");
                }
            }
        }

        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (value != "")
                {
                    cargo = value;
                }
                else
                {
                    Console.WriteLine("Error: El cargo no puede estar vacío.");
                }
            }
        }

        public Empleado(string nombre, string documento, int edad, double salario, string cargo)
            : base(nombre, documento, edad)
        {
            this.Salario = salario;
            this.Cargo = cargo;
        }

        public override string MostrarRol()
        {
            return "Empleado";
        }
    }
}
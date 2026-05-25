namespace PuntoDeVenta.Modelo
{
    public class Persona
    {
        protected string nombre;
        protected string documento;
        protected int edad;

        public string Nombre { get { return nombre; } }
        public string Documento { get { return documento; } }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 18 && value <= 100)
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("Error: La edad debe estar entre 18 y 100 años.");
                }
            }
        }

        public Persona(string nombre, string documento, int edad)
        {
            this.nombre = nombre;
            this.documento = documento;
            this.Edad = edad;
        }

        public virtual string MostrarRol()
        {
            return "Persona";
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Rol: " + MostrarRol());
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Documento: " + this.documento);
            Console.WriteLine("Edad: " + this.edad);
        }
    }
}
namespace PuntoDeVenta.Modelo
{
    public class Producto
    {
        protected int id;
        protected string nombre;
        protected double precio;
        protected int stock;

        public int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public int Stock { get { return stock; } }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    Console.WriteLine("Error: El precio debe ser mayor a cero.");
                }
            }
        }

        public Producto(int id, string nombre, double precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.Precio = precio;
            this.stock = stock;
        }

        public void DescontarStock(int cantidad)
        {
            if (cantidad > 0 && cantidad <= stock)
            {
                stock -= cantidad;
            }
            else
            {
                Console.WriteLine("Error: Stock insuficiente o cantidad inválida.");
            }
        }

        public void ReponerStock(int cantidad)
        {
            if (cantidad > 0)
            {
                stock += cantidad;
            }
            else
            {
                Console.WriteLine("Error: La cantidad debe ser mayor a cero.");
            }
        }

        public virtual double CalcularIVA()
        {
            return precio * 0.19;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("======================");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Precio: " + this.precio);
            Console.WriteLine("IVA: " + CalcularIVA());
            Console.WriteLine("Stock: " + this.stock);
        }
    }
}
using System;

namespace TecnoPunto
{
    public class Producto
    {
        // Campos privados: los datos solo se acceden por propiedades
        private string nombre;
        private decimal precio;
        private int cantidad;

        public string Codigo { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                nombre = value;
            }
        }

        public decimal Precio
        {
            get { return precio; }
            set
            {
               
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                precio = value;
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                cantidad = value;
            }
        }

       
        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Código:      {Codigo}");
            Console.WriteLine($"Nombre:      {Nombre}");
            Console.WriteLine($"Precio:      RD${Precio:N2}");
            Console.WriteLine($"Cantidad:    {Cantidad}");
            Console.WriteLine($"Valor total: RD${ValorTotal:N2}");
            Console.WriteLine("----------------------------");
        }
    }
}

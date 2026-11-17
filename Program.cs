using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inventario de TecnoPunto ===");

           
            for (int i = 1; i <= 3; i++)
            {
                bool registrado = false;

                
                while (!registrado)
                {
                    try
                    {
                        Console.WriteLine($"\nProducto {i}:");

                        Console.Write("Código: ");
                        string codigo = Console.ReadLine();

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Precio: ");
                        decimal precio = decimal.Parse(Console.ReadLine());

                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        
                        Producto producto = new Producto(codigo, nombre, precio, cantidad);
                        producto.MostrarInfo();
                        registrado = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message} Intente de nuevo.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: debe escribir un número válido. Intente de nuevo.");
                    }
                }
            }

            Console.WriteLine("\nRegistro finalizado.");
        }
    }
}
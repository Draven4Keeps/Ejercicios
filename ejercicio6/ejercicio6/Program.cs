using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el nombre del producto:");
        string producto = Console.ReadLine();

        Console.WriteLine("Ingresa el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());

        double impuesto = 0.0;

        if (producto.ToLower() != "medicina")
        {
            impuesto = 0.1; 
        }

        double impuestoTotal = precio * impuesto;
        double precioTotal = precio + impuestoTotal;

        Console.WriteLine("Impuesto: $" + impuestoTotal);
        Console.WriteLine("Precio total: $" + precioTotal);
    }
}

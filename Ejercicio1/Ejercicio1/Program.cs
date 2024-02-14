using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Que desea calcular?");
        Console.WriteLine("1.- Radianes");
        Console.WriteLine("2.- Grados");
        int opcion = int.Parse(Console.ReadLine());

        double resultado;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Inngrese los grados que desea convertir a radianes: ");
                double radianes = double.Parse(Console.ReadLine());
                resultado = ConvertirARadianes(radianes);
                Console.WriteLine($"Eso son {resultado}radianes.");
                break;
            case 2:
                Console.WriteLine("Ingrese los radianes que desea convertir a grados: ");
                double grados = double.Parse(Console.ReadLine());
                resultado = ConvertirAGrados(grados);
                Console.WriteLine($"Eso son {resultado}grados.");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        
        static double ConvertirARadianes(double radianes)
        {
            return radianes * (180 / Math.PI);
        }
        
        static double ConvertirAGrados(double grados) //definicion del metodo
        {
            return grados * (Math.PI / 180);
        }
    }
}
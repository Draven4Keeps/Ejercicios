using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido. ¿Que desea calcular?");
        Console.WriteLine("1.- Perimetro");
        Console.WriteLine("2.- Area");
        int opcion = int.Parse(Console.ReadLine());

        double resultado;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese el numero de lados del poligono: ");
                int numLados = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la longitud de un lado del poligono: ");
                double longitudLado = double.Parse(Console.ReadLine());
                
                double perimetro = CalcularPerimetro(numLados, longitudLado);

                Console.WriteLine($"El perimetro del poligono con {numLados} {longitudLado} es: {perimetro}");
                break;
            case 2:
                Console.WriteLine("Ingrese cuanto mide la base del poligono: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la longitud de un lado del poligono: ");
                double altura = double.Parse(Console.ReadLine());

                double area = CalcularArea(b,altura);

                Console.WriteLine($"El area del poligono con {b} {altura} es: {area}");
                break;
        }
        static double CalcularPerimetro(int numLados, double longitudLado)
        {
            return numLados * longitudLado;
        }
        static double CalcularArea(int b, double altura)
        {
            return b * altura / 2;
        }
    }
}
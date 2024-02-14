using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriba un numero del 1 al 7");
        int dias = int.Parse(Console.ReadLine());
        
        switch (dias)
        {
            case 1:
                if (dias == 1) ; Console.WriteLine($"ES LUNES.");
                break;
            case 2:
                if (dias == 2) ; Console.WriteLine($"ES MARTES.");
                break; 
            case 3:
                if (dias == 3) ; Console.WriteLine($"ES MIERCOLES.");
                break;
            case 4:
                if (dias == 4) ; Console.WriteLine($"ES JUEVES.");
                break; 
            case 5:
                if (dias == 5) ; Console.WriteLine($"ES VIERNES.");
                break; 
            case 6:
                if (dias == 6) ; Console.WriteLine($"ES SABADO.");
                break;
            case 7:
                if (dias == 7) ; Console.WriteLine($"ES DOMINGO.");
                break;
        }
    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, delta, x1, x2;

        Console.WriteLine("\nMe dê o valor de a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("\nMe dê o valor de b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("\nMe dê o valor de c:");
        c = double.Parse(Console.ReadLine());

        delta = Math.Pow(b, 2.0) - 4.0 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("O resultado de delta deu negativo, infelizmente não é possível determinar as raizes!");
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"O valor do x1 é {x1} e do x2 é {x2}");
        }
    }
}
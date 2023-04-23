using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, m, d, t; // a = anos, m = meses, d = dias, t = total.

        Console.WriteLine("Olá, esse programa calcula quantos dias você já viveu!!");
        Console.WriteLine("Primeiro me diga, Quantos anos você tem? ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Agora me diga quantos meses você tem? ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("E quantos dias você tem? ");
        d = int.Parse(Console.ReadLine());

        t = (a * 356) + (m * 30) + d;

        Console.WriteLine($"Você já viveu {t} dias!!");
    }
}
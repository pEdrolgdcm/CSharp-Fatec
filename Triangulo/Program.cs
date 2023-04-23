using System;

namespace Triangulo
{
    class program
    {
        static void Main(string[] args)
        {
            float a, b, calculo;
            Console.WriteLine("Bem vindos a interface, Calculamos a área de uma triângulo para você!");
            Console.WriteLine("Primeiro, qual a base do triângulo em centimetros? ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("E qual a altura do triângulo em centimetros? ");
            a = float.Parse(Console.ReadLine());

            calculo = (a * b) / 2;

            Console.WriteLine($"A área do triângulo é {calculo} centimetros");
        }
    }
}
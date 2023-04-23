using System;

namespace ParOuImpar
{
    class program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Informe o número que deseja saber se é par ou impar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                Console.WriteLine("O número informado é impar!");
            }
            else
            {
                Console.WriteLine("O número informado é par!");
            }
        }
    }
}
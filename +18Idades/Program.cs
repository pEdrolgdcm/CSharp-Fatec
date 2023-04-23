using System;

class Program
{
    static void Main(string[] args)
    {
        int[] idades = new int[10];
        int[] idades18 = new int[10];
        int dezoito = 0, id = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite a idade da pessoa " + (i + 1) + ":");
            string entrada = Console.ReadLine();
            idades[i] = int.Parse(entrada);

            if (idades[i] >= 18)
            {
                dezoito++;
                idades18[id] = idades[i];
                id++;
            }
        }

        Console.WriteLine("As idades digitadas foram: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(idades[i]);
        }

        Console.WriteLine("As idades digitadas que tem mais de 18 anos foram: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(idades18[i]);
        }

        Console.WriteLine($"Somando tudo dá {dezoito} pessoas maiores de 18 anos!");
    }
}
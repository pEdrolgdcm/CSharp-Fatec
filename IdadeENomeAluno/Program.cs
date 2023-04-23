using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int[] idades = new int[10];
        int[] idades18 = new int[10];
        string[] nomes = new string[10];
        string[] nomes18 = new string[10];
        int dezoito = 0;

        for (int i = 0; i < 10; i++, j++)
        {
            Console.WriteLine($"Qual o nome do {i + 1}º aluno? ");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite a idade do(a) {nomes[i]}? ");
            string resI = Console.ReadLine();
            idades[i] = int.Parse(resI);

            if (idades[i] >= 18)
            {
                dezoito++;
                idades18[i] = idades[i];
                nomes18[i] = nomes[i];
            }
        }

        Console.WriteLine("\nOs nomes digitados foram: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(nomes[i]);
        }

        Console.WriteLine("\nAs idades digitadas foram: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(idades[i]);
        }

        Console.WriteLine("\nOs alunos com mais de 18 anos são:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{nomes18[i]} com {idades18[i]}");
        }

        Console.WriteLine($"\nSomando tudo dá {dezoito} pessoas maiores de 18 anos!");
    }
}
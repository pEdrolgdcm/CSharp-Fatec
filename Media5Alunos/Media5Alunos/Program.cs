using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int idade = 0;
        float media = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Qual a idade do {i}º aluno? ");
            idade = int.Parse(Console.ReadLine());
            media += idade;
        }

        media = media / 5;

        Console.WriteLine($"o total da media das idades é: {media}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int[] idades = new int[10];

        for (int i = 0; i < 10; i++) 
        {
            Console.Write($"Digite a idade da {i + 1}º pessoa: ");
            idades[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("As pessoas que tem mais de 18 anos são:");
        for (int i = 0; i < 10; i++)
        {
            if (idades[i] >= 18) 
            {
                Console.WriteLine($"{i + 1}º pessoa: {idades[i]} anos");
            }
        }
    }
}
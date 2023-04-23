internal class Program
{
    private static void Main(string[] args)
    {
        int aluno = 0;
        int idade;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Me diga a idade do "+ i +"º aluno(a)");
            idade = int.Parse(Console.ReadLine());
            aluno += idade;
        }

        float total = aluno/5.0f;

        Console.WriteLine("A média das idades é "+ (float)total + " anos");
    }
}
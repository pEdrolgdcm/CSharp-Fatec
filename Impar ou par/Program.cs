internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Me informe o numero que deseja saber se é impar ou par: ");
        float n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 ==0)
        {
            Console.WriteLine("O número "+ n +" é par!");
        }
        else
        {
            Console.WriteLine("O número "+ n +" é impar!");
        }


    }
}
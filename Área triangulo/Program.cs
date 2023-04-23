internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Me informe a base ");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a altura ");
        float a = float.Parse(Console.ReadLine());

        float area = (b * a) / 2.00f;

        Console.WriteLine($"A área do triângulo é: {area}");
    }
}
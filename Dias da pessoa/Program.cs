internal class Program
{
    private static void Main(string[] args)
    {
        int diastotal;

        Console.WriteLine("Olá, sou um programa feito para calcular quantos dias de vida você tem!");

        Console.WriteLine("Primeiramente me informe quantos anos você tem: ");
        int anos = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora me informe quantos meses você tem: ");
        int meses = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora me informe quantos dias você tem: ");
        int dias = int.Parse(Console.ReadLine());

        diastotal = (anos * 365) + (meses * 30) + dias;

        Console.WriteLine($"Você tem {diastotal} dias de vida! :)");
    }
}
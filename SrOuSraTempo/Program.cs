using System;
using System.ComponentModel.Design;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int horas;
        Console.WriteLine("Qual o seu primeiro e último nome?");
        string s = Console.ReadLine();
        string[] v = s.Split(' ');
        string a = v[0];
        string b = v[1];

        Console.WriteLine("\nVocê se considera gênero masculino ou feminino?");
        string MouF = Console.ReadLine();

        switch (MouF)
        {
            case "masculino":
                Console.WriteLine("\nQual o horário que você está respondendo isso? (Ex: 12)");
                Console.WriteLine("E preciso do horário no formato de 24 horas!");
                horas = int.Parse(Console.ReadLine());

                if (horas >= 00 && horas < 13)
                {
                    Console.WriteLine($"\nBom dia Sr. {a} {b}!");
                }
                else if (horas >= 13 && horas < 18)
                {
                    Console.WriteLine($"Boa tarde {a}!");
                }

                else if (horas >= 18 && horas < 24)
                {
                    Console.WriteLine($"\nBoa noite Sr. {b}!");
                }
                break;

            case "feminino":
                Console.WriteLine("\nQual o horário que você está respondendo isso? (Ex: 12 horas)");
                Console.WriteLine("E preciso do horário no formato de 24 horas!");
                horas = int.Parse(Console.ReadLine());

                if (horas >= 00 && horas < 13)
                {
                    Console.WriteLine($"\nBom dia Sra. {a} {b}!");
                }
                else if (horas >= 13 && horas < 18)
                {
                    Console.WriteLine($"Boa tarde {a}!");
                }

                else if (horas >= 18 && horas < 24)
                {
                    Console.WriteLine($"\nBoa noite Sra. {b}!");
                }


                break;
            default:
                Console.WriteLine($"\n{MouF} não é uma opção válida");
                break;
        }
    }
}
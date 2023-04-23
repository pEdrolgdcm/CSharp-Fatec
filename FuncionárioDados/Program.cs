using System;
using System.Runtime.InteropServices;

class program
{
    public static void Main()
    {
        float horas = 0, salarioH = 0, salarioT = 0;
        uint matricula = 0;
        List<float> salvar = new List<float>();

        string loop; do
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Olá, selecione a opção desejada para continuar!");
            Console.WriteLine("Para efetuar o cálculo do salário por horas trabalhadas precione (C)!");
            Console.WriteLine("Para visualizar os dados precione (D)!");
            Console.WriteLine("Para encerrar o programa precione (S)!");
            loop = Console.ReadLine();

            switch (loop)
            {
                case "C":
                case "c":
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Qual o número da matrícula desse funcionário?");
                    matricula = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Qual foi o número de horas trabalhadas desse funcionário?");
                    horas = float.Parse(Console.ReadLine());
                    Console.WriteLine("Quanto esse funcionário rececbe por hora trabalhada?");
                    salarioH = float.Parse(Console.ReadLine());
                    salarioT = salarioH * horas;
                    Console.WriteLine("Calculo efetuado com sucesso!");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("-----------------------------------------");
                    string texto = $"O funcionário da matrícula {matricula}, trabalhou {horas} horas, e por hora ele recebe {salarioH} reais, logo ele deve rececber {salarioT.ToString("F2")} reais!";
                    foreach (var texto in lista)

                    {

                        Console.WriteLine(texto);



                    }
                    break;
                case "S":
                case "s":
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Achei que eramos amigos :(");
                    break;
                default:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"{loop} não é uma opção válida");
                    break;
            }
        } while (loop != "S" && loop != "s");
    }
}
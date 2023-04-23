using System;
using System.Collections.Generic;

namespace Prova_Carol
{
    public class Fruta
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            List<Fruta> estoque = new List<Fruta>();

            string loop; do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Olá, selecione a opção desejada para continuar!");
                Console.WriteLine("Para adicionar frutas ao estoque, pressione (1)");
                Console.WriteLine("Para contabilizar frutas vendidas, pressione (2)!");
                Console.WriteLine("Para visualizar o estoque de frutas, pressione (3)!");
                Console.WriteLine("Para encerrar o programa precione (S)!");
                loop = Console.ReadLine();

                switch (loop)
                {
                    case "1":
                        string loop2; do
                        {
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Para adicionar novas frutas ao estoque pressione (1)");
                            Console.WriteLine("Para reabastecer o estoque de frutas pressione (2)");
                            Console.WriteLine("Para voltar precione (S)!");
                            loop2 = Console.ReadLine();

                            switch (loop2)
                            {
                                case "1":
                                    Console.WriteLine("----------------------------------------------------");
                                    Console.WriteLine("Qual fruta você deseja adicionar ao estoque?:(");
                                    string nomeFruta = Console.ReadLine();
                                    Console.WriteLine("----------------------------------------------------");
                                    Console.WriteLine("Qual a quantidade dessa fruta que você deseja adicionar?");
                                    int quantidadeFruta = int.Parse(Console.ReadLine());
                                    estoque.Add(new Fruta { Nome = nomeFruta, Quantidade = quantidadeFruta });
                                    Console.WriteLine("----------------------------------------------------");
                                    Console.WriteLine($"Adicionado {quantidadeFruta} {nomeFruta}(s) ao estoque!");
                                    break;
                                case "2":
                                    Console.WriteLine("----------------------------------------------------");
                                    Console.WriteLine("Qual fruta você deseja reabastecer?:");
                                    string nomeFrutaReabastecer = Console.ReadLine();
                                    Fruta frutaReabastecer = estoque.Find(f => f.Nome == nomeFrutaReabastecer);
                                    if (frutaReabastecer == null)
                                    {
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine($"A fruta {nomeFrutaReabastecer} não foi encontrada no estoque.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine($"Qual a quantidade de {nomeFrutaReabastecer} você deseja adicionar ao estoque?");
                                        int quantidadeFrutaReabastecer = int.Parse(Console.ReadLine());
                                        frutaReabastecer.Quantidade += quantidadeFrutaReabastecer;
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine($"Reabastecido com sucesso! O estoque de {nomeFrutaReabastecer} agora é de {frutaReabastecer.Quantidade}.");
                                    }
                                    break;
                                case "S":
                                case "s":
                                    break;
                                default:
                                    Console.WriteLine("----------------------------------------------------");
                                    Console.WriteLine($"{loop2} não é uma opção válida");
                                    break;
                            }
                        } while (loop2 != "S" && loop2 != "s");
                        break;
                    case "2":
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Qual fruta foi vendida?");
                        string nomeFrutaRemover = Console.ReadLine();
                        Fruta frutaRemover = estoque.Find(f => f.Nome == nomeFrutaRemover);
                        if (frutaRemover == null)
                        {
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine($"A fruta {nomeFrutaRemover} não foi encontrada no estoque.");
                        }
                        else
                        {
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine($"Qual a quantidade de {nomeFrutaRemover} que foi vendida?");
                            int quantidadeFrutaRemover = int.Parse(Console.ReadLine());
                            frutaRemover.Quantidade -= quantidadeFrutaRemover;
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine($"Contabilizado com sucesso! O estoque de {nomeFrutaRemover} agora é de {frutaRemover.Quantidade}.");
                        }
                        break;
                    case "3":
                        if (estoque.Count == 0)
                        {
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("O estoque está vazio.");
                        }
                        else
                        {
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Frutas no estoque:");
                            foreach (var fruta in estoque)
                            {
                                Console.WriteLine($"{fruta.Nome}: {fruta.Quantidade}");
                            }
                        }
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Achei que eramos amigos :(");
                        break;
                    default:
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine($"{loop} não é uma opção válida");
                        break;
                }
            } while (loop != "S" && loop != "s");

        }
    }
}

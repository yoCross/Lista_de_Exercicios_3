/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial,
classe, e raça do personagem e exiba esses dados no console.
@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo Lima
@Data: 30/08/2024
---------------------------------------------------------------------*/
using System;
using System.Threading;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int qntTotal, qntTipos, qntAbrir;
            System.Console.WriteLine("Quantas chaves você tem?");
            int.TryParse(Console.ReadLine(), out qntTotal);

            System.Console.WriteLine("Quantos tipos de baús existem?");
            int.TryParse(Console.ReadLine(), out qntTipos);

            for (int i = 1; i <= qntTipos; i++) {
                if (qntTotal == 0) {continue;}
                System.Console.WriteLine($"Quantos baús do {i}° tipo você gostaria de abrir?");
                int.TryParse(Console.ReadLine(), out qntAbrir);
                while (qntTotal - qntAbrir < 0) {
                    System.Console.WriteLine($"Você ainda possui {qntTotal} chaves");
                    System.Console.WriteLine($"Quantos baús do {i}° tipo você gostaria de abrir?");
                    int.TryParse(Console.ReadLine(), out qntAbrir);
                }
                qntTotal -= qntAbrir;

                if(qntAbrir == 0) {continue;}
                
                if (qntAbrir == 1) {
                    Console.Write("O baú dropou ");
                } else {
                    Console.Write("Os baús droparam ");
                }

                for (int j = 1; j <= qntAbrir; j++) {
                    if (j != qntAbrir) {
                        Console.Write($"{random.Next((i-1), (i+5))}, ");
                    } else {
                        Console.Write($"{random.Next((i-1), (i+5))} ");
                    }
                }

                if (qntAbrir == 1) {
                    Console.WriteLine("item raro.");
                } else {
                    Console.WriteLine("itens raros.");
                }
            }
            Thread.Sleep(500);
            System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
            Console.ReadKey();
        }
    }
}
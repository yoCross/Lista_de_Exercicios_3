/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de Dificuldade
Contextualização: Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade. Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando: Desenvolva um programa em C# que:
1.Pergunte ao jogador quantas missões ele completou.
2.Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3.Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
• Fácil: 50 pontos por inimigo
• Médio: 100 pontos por inimigo
• Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.

@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azebedo
@Data: 30/08/2024
---------------------------------------------------------------------*/
using System;
using System.Runtime.ConstrainedExecution;
class Program{
    static void Main(string[] args){
        int quantas, total = 0;
        System.Console.WriteLine("Quantas missões você completou?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out quantas);

        string?[] dificuldade = new string? [quantas];

        int[] derrotou = new int[quantas];

        for (int i = 0; i < quantas; i++){
            while(true){
                System.Console.WriteLine($"Qual foi a dificuldade da missão {i+1}");
                System.Console.WriteLine("Facil \n Medio \n Dificil");
                System.Console.Write("Escolha: ");
                dificuldade[i] = Console.ReadLine().ToLower();
                if (dificuldade[i] != "facil" && dificuldade[i] != "medio" && dificuldade[i] != "dificil"){
                    Console.Clear();
                    System.Console.WriteLine("Ponha uma dificuldade veridica");
                }
                else{
                    break;
                }
            }   
            Console.Clear();
        }
        for (int i = 0; i < quantas; i++){
            System.Console.WriteLine($"Quantos inimigos voce derrotou na missão {i+1}");
            System.Console.Write("Quantos: ");
            int.TryParse(Console.ReadLine(), out derrotou[i]);
            Console.Clear();
        }
        for(int i = 0; i < quantas; i++){
            if(dificuldade[i] == "facil"){
                total += derrotou[i] * 50;
            }
            else if(dificuldade[i] == "medio"){
                total += derrotou[i] * 100;
            }
            else if(dificuldade[i] == "dificil"){
                total += derrotou[i] * 150;
            }
        }
        System.Console.WriteLine($"Sua pontuação total foi de {total}");
        Thread.Sleep(500);
        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}
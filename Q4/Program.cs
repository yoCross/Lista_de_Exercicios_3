/*-------------------------------------------------------------------
Questão 4: Jornada do Herói com Pontos de Vida e Itens de Cura
Contextualização
O herói de um jogo atravessa várias fases, ganhando ou perdendo pontos de vida. Além disso, em algumas fases, o herói pode usar itens de cura para recuperar pontos de vida.
Comando
Desenvolva um programa em C# que:
1.Pergunte ao jogador quantas fases ele deseja jogar.
2.Para cada fase, pergunte quantos pontos de vida o herói ganhou ou perdeu (valores positivos indicam ganho e negativos indicam perda).
3.Para cada fase, pergunte se o herói usou um item de cura (Sim/Não). Se sim, pergunte quantos pontos de cura foram usados.
O programa deve calcular e mostrar a vida total do herói ao final da jornada, considerando que ele começa com 100 pontos de vida.
@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo
@Data: 30/08/2024
---------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        int fases, total = 100;
        bool curou;
        System.Console.WriteLine("Quantas fases voce deseja jogar?");
        System.Console.Write("Escolha: ");
        Console.Clear();
        int.TryParse(System.Console.ReadLine(), out fases);
        int[] perdeu = new int[fases];
        int[] ganhou = new int[fases];
        int[] curouquanto = new int[fases];
        for(int i = 0; i < fases; i++){
            System.Console.WriteLine($"Quantos pontos de vida voce ganhou na fase {i+1}?");
            int.TryParse(System.Console.ReadLine(), out ganhou[i]);
            Console.Clear();
            System.Console.WriteLine($"Quantos pontos de vida voce perdeu na fase {i+1}? (escreva as perdas com numeros negativos, exemplo: -12)");
            int.TryParse(System.Console.ReadLine(), out perdeu[i]);
            Console.Clear();
            
            System.Console.WriteLine("Voce usou um item de cura? (Sim/Não)");
            System.Console.Write("Escolha: ");
            if(Console.ReadLine().ToLower() == "sim"){
                Console.Clear();
                curou = true;
                    
            }
            else{
                Console.Clear();
                curou = false;
            }
            if(curou == true){
                System.Console.WriteLine("Quantos pontos de cura foram usados?");
                System.Console.Write("Escolha: ");
                int.TryParse(Console.ReadLine(), out curouquanto[i]);
                Console.Clear();
            }
        }
        for(int i = 0; i < fases; i++){
            total += ganhou[i] + perdeu[i] + curouquanto[i];
        }
        System.Console.WriteLine($"Vida total: {total}");
        Thread.Sleep(500);
        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}
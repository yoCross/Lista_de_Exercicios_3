/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1.Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no inventário.
2.Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3.Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está dentro da capacidade máxima, informando se está excedido ou não.
@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo Lima
@Data: 30/08/2024
---------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        int quantos, max, total = 0;
        System.Console.WriteLine("Quantos tipos diferentes de itens voce deseja armazenar no inventário?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out quantos);
        string?[] nome = new string?[quantos];
        int[] nomequatos = new int[quantos];
        for(int i = 0; i < quantos; i++){
            System.Console.WriteLine($"Qual o nome do item {i+1}");
            System.Console.Write("Escolha: ");
            nome[i] = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine($"Quantos {nome[i]} voce tem?");
            System.Console.Write("Escolha: ");
            int.TryParse(Console.ReadLine(), out nomequatos[i]);
            Console.Clear();
        }
        System.Console.WriteLine("Qual e o seu espaço maximo de inventario?");
        System.Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out max);
        for(int i = 0; i < quantos; i++){
            total += nomequatos[i];
        }
        if(total > max){
            System.Console.WriteLine($"{total} itens. Excede a capacidade.");
        }
        else{
            System.Console.WriteLine($"{total} itens. Dentro da capacidade.");
        }
        Thread.Sleep(500);
        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}
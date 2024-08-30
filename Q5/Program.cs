/*-------------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente. A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso, se o jogador atingir certos marcos de dias, recebe bônus adicionais. Comando
Crie um programa em C# que:
1.Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2.Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3.Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4.(Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias (Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os bônus se aplicável.
@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azeveda Lima
@Data: 30/08/2024
---------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        int viciado, inicial, total = 0;
        int acrescimo = 0;

        Console.WriteLine("Quantos dias consecutivos voce logou no jogo.");
        int.TryParse(Console.ReadLine(), out viciado);
        Console.WriteLine("qual o valor da recompensa inicial em moedas no primeiro dia.");
        int.TryParse(Console.ReadLine(), out inicial);
        int[] somas = new int[viciado];
        Console.WriteLine("Qual o incremento da recompensa a cada dia consecutivo");
        int.TryParse(Console.ReadLine(), out acrescimo);
        
        for(int i = 0; i < viciado; i++){
            total += inicial + (acrescimo * i);
        }
        System.Console.WriteLine($"voce tem um total de {total} moedas");
        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}
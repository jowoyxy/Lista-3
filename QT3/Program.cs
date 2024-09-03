/*-------------------------------------------------------------------
Questão 3:
• Contextualização:Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
@Lista: 03 - laços de repetição
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos tipos diferentes de itens você deseja armazenar no inventário?");
        int tiposItens = int.Parse(Console.ReadLine());

        int totalItens = 0;

        for (int i = 1; i <= tiposItens; i++)
        {
            Console.WriteLine($"Digite o nome do item {i}:");
            string nomeItem = Console.ReadLine();

            Console.WriteLine($"Digite a quantidade de {nomeItem}:");
            int quantidade = int.Parse(Console.ReadLine());

            totalItens += quantidade;
        }

        Console.WriteLine("Qual é a capacidade máxima do inventário?");
        int capacidadeMaxima = int.Parse(Console.ReadLine());

        Console.WriteLine($"Total: {totalItens} itens.");

        if (totalItens <= capacidadeMaxima)
        {
            Console.WriteLine("Dentro da capacidade.");
        }
        else
        {
            Console.WriteLine("Excede a capacidade.");
        }
    }
}

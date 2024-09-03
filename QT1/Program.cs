/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de exploração, o jogador pode abrir diferentes tipos de baús em uma masmorra.
Cada tipo de baú possui uma variação na quantidade de itens raros que pode conter.
Comando:
Crie um programa em C# que simule a coleta de itens raros a partir de diferentes tipos de baús.
O programa deve:
1. Perguntar ao jogador quantos baús ele deseja abrir.
2. Perguntar ao jogador quantos tipos diferentes de baús existem no jogo.
3. Para cada tipo de baú, perguntar quantos baús desse tipo o jogador deseja abrir.
Para cada baú aberto, dependendo do tipo, gerar aleatoriamente a quantidade de itens raros
obtidos:
• Tipo A: 0 a 3 itens
• Tipo B: 1 a 5 itens
• Tipo C: 2 a 6 itens
• (Adapte conforme o número de tipos definidos pelo jogador)
O programa deve calcular e exibir a quantidade total de itens raros obtidos após abrir todos os
baús
@Lista: 03 - laços de repetição
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Quantos tipos diferentes de baús existem no jogo?");
        int numeroTiposBaus = int.Parse(Console.ReadLine());

        int totalItensRaros = 0;

        for (int i = 1; i <= numeroTiposBaus; i++)
        {
            Console.WriteLine($"Digite a quantidade de baús do tipo {i} que você deseja abrir:");
            int quantidadeBaus = int.Parse(Console.ReadLine());

            for (int j = 1; j <= quantidadeBaus; j++)
            {
                int itensRaros = 0;

                switch (i)
                {
                    case 1:
                        itensRaros = random.Next(0, 4);
                        break;
                    case 2:
                        itensRaros = random.Next(1, 6);
                        break;
                    case 3:
                        itensRaros = random.Next(2, 7);
                        break;
                }

                totalItensRaros += itensRaros;
            }
        }

        Console.WriteLine($"Total de itens raros obtidos: {totalItensRaros}");
    }
}

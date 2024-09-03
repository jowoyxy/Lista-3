/*-------------------------------------------------------------------
Questão 2:
• Contextualização:Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade.
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
• Fácil: 50 pontos por inimigo
• Médio: 100 pontos por inimigo
• Difícil: 150 pontos por inimigo

@Lista: 03 - laços de repetição
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantas missões você completou?");
        int numeroMissoes = int.Parse(Console.ReadLine());

        int pontuacaoTotal = 0;

        for (int i = 1; i <= numeroMissoes; i++)
        {
            Console.WriteLine($"Qual o nível de dificuldade da missão {i}? (Fácil, Médio, Difícil)");
            string dificuldade = Console.ReadLine().ToLower();

            Console.WriteLine($"Quantos inimigos você derrotou na missão {i}?");
            int inimigosDerrotados = int.Parse(Console.ReadLine());

            int pontuacaoPorInimigo = 0;

            switch (dificuldade)
            {
                case "fácil":
                    pontuacaoPorInimigo = 50;
                    break;
                case "médio":
                    pontuacaoPorInimigo = 100;
                    break;
                case "difícil":
                    pontuacaoPorInimigo = 150;
                    break;
            }

            pontuacaoTotal += pontuacaoPorInimigo * inimigosDerrotados;
        }

        Console.WriteLine($"Pontuação total: {pontuacaoTotal} pontos");
    }
}


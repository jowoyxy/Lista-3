/*-------------------------------------------------------------------
Questão 4:
• Contextualização:Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente.
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso,
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os
bônus se aplicável.
@Lista: 03 - laços de repetição
@Autor: Joanna Nobre
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por quantos dias consecutivos você logou no jogo?");
        int diasConsecutivos = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é a recompensa inicial em moedas no primeiro dia?");
        int recompensaInicial = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é o incremento da recompensa a cada dia consecutivo?");
        int incrementoDiario = int.Parse(Console.ReadLine());

        int totalMoedas = 0;

        Console.WriteLine("Deseja considerar bônus por marcos de dias? (Sim/Não)");
        string considerarBonus = Console.ReadLine().ToLower();

        int marcoDias = 0;
        int valorBonus = 0;

        if (considerarBonus == "sim")
        {
            Console.WriteLine("A cada quantos dias consecutivos há um bônus?");
            marcoDias = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o valor do bônus?");
            valorBonus = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= diasConsecutivos; i++)
        {
            int recompensaDia = recompensaInicial + (incrementoDiario * (i - 1));
            totalMoedas += recompensaDia;

            if (considerarBonus == "sim" && i % marcoDias == 0)
            {
                totalMoedas += valorBonus;
            }
        }

        Console.WriteLine($"Total de moedas acumuladas: {totalMoedas} moedas");
    }
}


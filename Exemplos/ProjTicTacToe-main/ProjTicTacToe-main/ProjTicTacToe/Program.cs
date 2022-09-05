using System;
using System.Collections.Generic;
namespace ProjTicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];           //1° passo - declarei a matriz 3/3
            string turno = "X";
            List<string> IndexNumeros = new List<string> { };
            int index = 1;
            int tentativas = 0;
            Console.WriteLine("_____________________");
            Console.WriteLine("     JOGO DA VELHA   ");
            Console.WriteLine("_____________________");
            // Alimentando a matriz
            for (int lin = 0; lin < 3; lin++)              //Lendo as linhas
            {
                for (int col = 0; col < 3; col++)           //Lendo as colunas
                {
                    matriz[lin, col] = index.ToString();
                    IndexNumeros.Add(index.ToString());      //Lista com todo a numeração válida do jogo.
                    index++;
                }
            }
            //Imprimir a matriz
            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($" [{matriz[lin, col]}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write($"VOCÊ QUER JOGAR [{turno}] EM QUAL POSIÇÃO? ");
            string jogada = Console.ReadLine();
            Console.Clear();
            //Começa o jogo
            while (tentativas < 9)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(" JOGO DA VELHA ");
                Console.WriteLine("---------------");
                for (int lin = 0; lin < 3; lin++)
                {
                    for (int col = 0; col < 3; col++)
                    {                                                                  //Neste "for" estou validando minha "string jogada", se o valor digitado estiver dentro da matriz;
                        if (matriz[lin, col] == jogada && IndexNumeros.Contains(jogada))                // ou seja, estou substituindo o valor na sua respectiva casa.
                        {
                            matriz[lin, col] = turno;
                            IndexNumeros.Remove(jogada);
                        }
                    }
                }
                for (int lin = 0; lin < 3; lin++)
                {
                    for (int col = 0; col < 3; col++)                                   // neste for estou desenhando minha matriz novamente.
                    {
                        Console.Write($" [{matriz[lin, col]}] ");
                    }
                    Console.WriteLine();
                }
                //Condição de vitória
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||       // Condições de vitória na diagonal
                    matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    Console.WriteLine("\n---------------------------------");
                    Console.Write($"\n O Ganhador [{turno}] venceu. Parabéns!");
                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Fim de jogo!!!");
                    break;
                }
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||       // Condições de vitória na horizontal
                     matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                     matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    Console.WriteLine("\n---------------------------------");
                    Console.Write($"\n O Ganhador [{turno}] venceu. Parabéns!");
                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Fim de jogo!!!");
                    break;
                }
                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                    matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                    matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    Console.WriteLine("\n---------------------------------");
                    Console.Write($"\n O Ganhador [{turno}] venceu. Parabéns!");
                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Fim de jogo!!!");
                    break;
                }
                if (turno == "X")                                                     // Trocando jogadas > primeiro "X", depois "O", assim por diante.
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }
                Console.WriteLine();
                Console.Write($"Você quer jogar [{turno}] em qual posição? ");
                jogada = Console.ReadLine();
                //Condição para opção inválida
                while (!IndexNumeros.Contains(jogada))                         // Add para anular jogadas repetidas ou inválidas de acordo com a lista.
                {
                    Console.WriteLine();
                    Console.Write("Jogada Inválida. Tente novamente: ");
                    jogada = Console.ReadLine();
                }
                tentativas++;
                Console.Clear();
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
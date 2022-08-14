//Faça um algoritmo que leia três numeros float e informe
//qual o valor do maior e qual valor do menor assim como
//quem é o maior e quem é o menor;

using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe um número: ");
            float Num = float.Parse(Console.ReadLine());

            float Maior = Num;
            float Menor = Num;
            int PosM = 1;
            int PosN = 1;

            for (int i = 2; i < 4; i++)
            {

                Console.Write("Informe outro número: ");
                Num = float.Parse(Console.ReadLine());

                if (Num > Maior)
                {
                    Maior = Num;
                    PosM = i;
                }

                if (Num < Menor)
                {
                    Menor = Num;
                    PosN = i;
                }
            }

            Console.WriteLine($"Maior numero informado é {Maior} e sua posição é {PosM}");
            Console.WriteLine($"Menor numero informado é {Menor} e sua posição é {PosN}");

        }
    }
}
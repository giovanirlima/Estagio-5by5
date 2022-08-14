//Faça um algoritmo que leia um numero inteiro e informe se ele é primo ou não.

using System;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int Num = int.Parse(Console.ReadLine());
            int Primo = 0;

            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                    Primo++;
            }

            if (Primo == 2)
            {
                Console.WriteLine($"{Num} é um número primo");
            }
            else
            {
                Console.WriteLine($"{Num} não é um número primo");
            }

        }
    }
}

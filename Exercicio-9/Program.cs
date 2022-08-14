//Faça um algoritmo que leia um numero inteiro e informe se ele é par ou impar.

using System;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int Num = int.Parse(Console.ReadLine());

            int Par = Num % 2;

            if (Par == 0) { Console.WriteLine($"{Num} é um número par."); }

            else { Console.WriteLine($"{Num} é um número impar."); }
        }
    }
}

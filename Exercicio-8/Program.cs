//Faça um algoritmo que leia um numero inteiro, e mostre a sua tabuada.

using System;

namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número que deseje saber a tabuada: ");
            int Num = int.Parse(Console.ReadLine());

            int Resultado = 0;
            for (int i = 0; i < 11; i++)
            {
                Resultado = Num * i;
                Console.WriteLine($"{Num} x {i} = {Resultado}");
            }
        }
    }
}

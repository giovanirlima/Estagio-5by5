//Faça um algoritmo que leia 2 numeros e execute as quatro operações matematicas basicas.

using System;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            double Num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            double Num2 = double.Parse(Console.ReadLine());

            //Executa a soma dos números
            double Soma = Num1 + Num2;

            //Executa a subtração dos números
            double Sub = Num1 - Num2;

            //Executa a multiplicação dos números
            double Mult = Num1 * Num2;

            //Executa a divisão dos números
            double Div = Num1 / Num2;

            //Imprimi os resultados das operações
            Console.WriteLine($"O resultado da soma dos números é {Soma}");
            Console.WriteLine($"O resultado da subtração dos números é {Sub}");
            Console.WriteLine($"O resultado da multiplicação dos números é {Mult}");
            Console.WriteLine($"O resultado da divisão dos números é {Div}");

        }
    }
}

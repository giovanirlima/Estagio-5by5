//Faça um algoritmo que leia 3 numeros, e informe se é isoceles, equilatero, escaleno.
using System;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do lado 1 triangulo: ");
            float L1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do lado 2 triangulo: ");
            float L2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do lado 3 triangulo: ");
            float L3 = float.Parse(Console.ReadLine());

            //Teste para saber que tipo é o triangulo

            if ((L1 == L2 && L1 != L3) || (L2 == L3 && L2 != L1) || (L3 == L1 && L3 != L2))
            {
                Console.WriteLine("Triangulo é Isosceles, pois dois de seus lados são iguais.");
            }

            if (L1 == L2 && L1 == L3)
            {
                Console.WriteLine("Triangulo é Equilatero, pois possue todos lados iguais");
            }

            if (L1 != L2 && L1 != L3)
            {
                Console.WriteLine("Triangulo é Escaleno, pois possue todos os lados diferentes");
            }

        }
    }
}

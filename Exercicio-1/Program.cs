//leia celsius e converta para fahrenhet, 
using System;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a temperatura em º Celsius: ");
            double TempC = double.Parse(Console.ReadLine());

            //Conversão utilizando a seguinte formula (C * 9/8) + 32.
            double TempF = (TempC * 9 / 5) + 32;


            Console.Write($"Após a conversão, nova temperatura em Fahrenhet: {TempF} ºF");
        }
    }
}
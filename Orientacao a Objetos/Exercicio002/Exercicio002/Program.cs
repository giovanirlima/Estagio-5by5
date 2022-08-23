using System;

namespace Exercicio002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            X.A = double.Parse(Console.ReadLine());
            X.B = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do Triângulo Y: ");
            Y.A = double.Parse(Console.ReadLine());
            Y.B = double.Parse(Console.ReadLine());
            Y.C = double.Parse(Console.ReadLine());

            double AreaX = X.Area();
            double AreaY = Y.Area();

            string Maior;
            if (AreaX > AreaY)
            {
                Maior = "X";
            }
            else
            {
                Maior = "Y";
            }
            Console.WriteLine(("Área de X = {0}"), AreaX.ToString("F4"));
            Console.WriteLine(("Área de Y = {0}"), AreaY.ToString("F4"));
            Console.WriteLine(("Maior área: {0}"), Maior);

        }
    }
}
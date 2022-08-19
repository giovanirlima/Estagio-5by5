using System;

namespace PFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            double num1 = 0, num2 = 0, resultado = 0;
            string Operacao;

            do
            {
                Console.WriteLine("\nOlá usuário, escolha uma das opções!");

                Console.WriteLine("1 - SOMA\n2 - SUBTRACAO\n3 - DIVISAO\n4 - MULTIPLICACAO\n0 - Para sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.Write("Informe o primeiro valor: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo valor: ");
                    num2 = double.Parse(Console.ReadLine());

                    resultado = Soma(num1, num2);

                    Console.WriteLine($"Soma: {resultado}");
                }

                else if (op == 2)
                {
                    Console.Write("Informe o primeiro valor: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo valor: ");
                    num2 = double.Parse(Console.ReadLine());

                    resultado = Subtracao(num1, num2);

                    Console.WriteLine($"Subtração: {resultado}");
                }

                else if (op == 3)
                {
                    Console.Write("Informe o primeiro valor: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo valor: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Número não é divisivel por 0");
                    }
                    else
                    {
                        resultado = Divisao(num1, num2);
                        Console.WriteLine($"Divisão: {resultado}");
                    }

                }

                else if (op == 4)
                {
                    Console.Write("Informe o primeiro valor: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo valor: ");
                    num2 = double.Parse(Console.ReadLine());

                    resultado = Multiplicacao(num1, num2);

                    Console.WriteLine($"Multiplicação: {resultado}");
                }
                else
                {
                    if (op == 0)
                    {
                        Console.WriteLine("Bye Bye !!!");
                    }

                    else
                    {
                        Console.WriteLine("Você digitou uma opção inválida!");
                    }
                }

            } while (op != 0);
                        
        }

        static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        static double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
        static double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }


    }


}


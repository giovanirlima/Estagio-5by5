//FAÇA UM PROGRAMA QUE LEIA DOIS VETORES DE CINCO POSICOES E TENHA AS SEGUINTES FUNÇÕES.
//1º EXECUTE A OPERACAO MATEMATICA ESCOLHA PELO USUARIO
//2º COMPARE CADA UMA DAS POSICOES DOS VETORES, E INFORME QUAL VETOR POSSUE O MAIOR VALOR SÃO IGUAIS

using System;

namespace PVFuncções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Calculo(double[] n1, double[] n2)
            {
                int op = 0;
                do
                {

                    Console.WriteLine("\nOlá!");
                    Console.WriteLine("Informe a opção desejada: ");
                    Console.WriteLine("1 - SOMA\n2 - SUBTRACAO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO\n0 - SAIR\n");
                    op = int.Parse(Console.ReadLine());

                    double[] aux = new double[5];

                    if (op == 1)
                    {
                        for (int i = 0; i < n1.Length; i++)
                        {
                            aux[i] = n1[i] + n2[i];
                            Console.WriteLine($"Resultado da soma: {aux[i]}");
                        }
                    }

                    else if (op == 2)
                    {
                        for (int i = 0; i < n1.Length; i++)
                        {
                            aux[i] = n1[i] - n2[i];
                            Console.WriteLine($"Resultado da subtração: {aux[i]}");
                        }
                    }

                    else if (op == 3)
                    {
                        for (int i = 0; i < n1.Length; i++)
                        {
                            aux[i] = n1[i] * n2[i];
                            Console.WriteLine($"Resultado da multiplicação: {aux[i]}");
                        }
                    }

                    else if (op == 4)
                    {
                        for (int i = 0; i < n1.Length; i++)
                        {
                            if (n2[i] == 0)
                            {
                                Console.WriteLine("Número não divisivel por zero!");
                            }
                            else
                            {
                                aux[i] = n1[i] / n2[i];
                                Console.WriteLine($"Resultado da divisão: {aux[i]}");
                            }

                        }
                    }
                    else if (op == 0)
                    {
                        Console.WriteLine("Bye Bye !!!");
                    }
                    else
                    {
                        Console.WriteLine("Você digitou uma opção inválida!");
                    }
                } while (op != 0);
            }

            void Maior(double[] n1, double[] n2)
            {
                for (int i = 0; i < n1.Length; i++)
                {
                    if (n1[i] > n2[i])
                    {
                        Console.WriteLine($"Na posição {i} Vetor A tem o maior Número!");
                    }
                    else if (n1[i] < n2[i])
                    {
                        Console.WriteLine($"Na posição {i} Vetor B tem o maior Número!");
                    }
                    else
                    {
                        Console.WriteLine($"Na posição {i} Vetor A e B os números são iguais!");
                    }
                }
            }

            double[] vetA = new double[5];
            double[] vetB = new double[5];

            Console.WriteLine("Informe os valores do vetor A");

            for (int i = 0; i < vetA.Length; i++)
            {
                vetA[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nInforme os valores do vetor B");

            for (int i = 0; i < vetA.Length; i++)
            {
                vetB[i] = double.Parse(Console.ReadLine());
            }

            Calculo(vetA, vetB);

            Maior(vetA, vetB);
        }
    }
}
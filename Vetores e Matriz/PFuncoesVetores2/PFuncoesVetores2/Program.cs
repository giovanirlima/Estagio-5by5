// FAÇA UM PROGRAMA QUE LEIA DOIS VETORES DE CINCO POSICOES E TENHA AS SEGUINTES FUNÇÕES.
//1º EXECUTE A OPERACAO MATEMATICA ESCOLHA PELO USUARIO
//2º COMPARE CADA UMA DAS POSICOES DOS VETORES, E INFORME QUAL VETOR POSSUE O MAIOR VALOR SÃO IGUAIS

using System;

namespace PFuncoesVetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void LerVetores()
            {
                float[] v1 = new float[5];

                for (int i = 0; i < v1.Length; i++)
                {
                    v1[i] = float.Parse(Console.ReadLine());
                }
            }
            void Calculo()
            {
                double[] n1 = new double[5];
                double[] n2 = new double[5];
                int op = 0;
                do
                {
                    Console.WriteLine("\nOlá!");
                    Console.WriteLine("Informe a opção desejada: ");
                    Console.WriteLine("1 - SOMA\n2 - SUBTRACAO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO\n0 - SAIR");
                    op = int.Parse(Console.ReadLine());

                    while (op != 1 && op != 2 && op != 3 && op != 4 && op != 0)
                    {
                        Console.WriteLine("Opção invalida!");

                        Console.WriteLine("\nOlá!");
                        Console.WriteLine("Informe a opção desejada: ");
                        Console.WriteLine("1 - SOMA\n2 - SUBTRACAO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO\n0 - SAIR");
                        op = int.Parse(Console.ReadLine());
                    }

                    if (op != 0)
                    {
                        Console.WriteLine("Informe os valores do vetor A");

                        for (int i = 0; i < n1.Length; i++)
                        {
                            n1[i] = double.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("\nInforme os valores do vetor B");

                        for (int i = 0; i < n2.Length; i++)
                        {
                            n2[i] = double.Parse(Console.ReadLine());
                        }

                        double[] aux = new double[5];

                        if (op == 1)
                        {
                            Console.WriteLine("");
                            for (int i = 0; i < n1.Length; i++)
                            {
                                aux[i] = n1[i] + n2[i];
                                Console.WriteLine($"Resultado da soma: {aux[i]}");
                            }
                        }

                        else if (op == 2)
                        {
                            Console.WriteLine("");
                            for (int i = 0; i < n1.Length; i++)
                            {
                                aux[i] = n1[i] - n2[i];
                                Console.WriteLine($"Resultado da subtração: {aux[i]}");
                            }
                        }

                        else if (op == 3)
                        {
                            Console.WriteLine("");
                            for (int i = 0; i < n1.Length; i++)
                            {
                                aux[i] = n1[i] * n2[i];
                                Console.WriteLine($"Resultado da multiplicação: {aux[i]}");
                            }
                        }

                        else if (op == 4)
                        {
                            Console.WriteLine("");
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
                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Bye Bye !!!");
                    }
                } while (op != 0);
            }

            void Maior()
            {
                double[] n1 = new double[5];
                double[] n2 = new double[5];

                Console.WriteLine("");

                Console.WriteLine("Informe os valores para saber o maior!");

                Console.WriteLine("Informe os valores do vetor A");

                for (int i = 0; i < n1.Length; i++)
                {
                    n1[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nInforme os valores do vetor B");

                for (int i = 0; i < n2.Length; i++)
                {
                    n2[i] = double.Parse(Console.ReadLine());
                }

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

            Calculo();
            Maior();
        }
    }
}


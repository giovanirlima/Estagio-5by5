//1 - Leia um vetor de 10 posições 
//2- Copie os valores do vetor A para o vetor B
//3- Copie para o Vetor C, de forma invertida, os valores do Vetor A
//4- Ordene os valores do Vetor A
//5- Imprima Vetor A, B e C

using System;


namespace PVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];

            Console.WriteLine("Entre com o valor dos vetores");
            Console.WriteLine();
            for (int i = 0, j = 9; i < 10; i++, j--)
            {
                Console.Write($"º{i + 1} Vetor: ");
                vet1[i] = int.Parse(Console.ReadLine());
                vet2[i] = vet1[i];
                vet3[j] = vet1[i];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (vet1[i] < vet1[j])
                    {
                        aux = vet1[j];
                        vet1[j] = vet1[i];
                        vet1[i] = aux;
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("Valores do vetor A");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Resultado: {vet1[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Valores do vetor B");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Resultado: {vet2[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Valores do vetor C");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Resultado: {vet3[i]}");
            }

        }
    }
}

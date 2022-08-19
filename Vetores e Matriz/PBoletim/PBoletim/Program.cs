// ELABORE UM PROGRAMA QUE:
//LEIA 2 NOTAS DE 5 ALUNOS
//APÓS LER TODOS VALORES CALCULE A MÉDIA DOS ALUNOS
using System;

namespace PBoletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    float[,] n1 = new float[5, 2];
               float[] Media = new float[5];
               int div = 2;

               for (int i = 0; i < 5; i++)
               {
                   for (int j = 0; j < 2; j++)

                   {
                       Console.WriteLine($"Informe a {j + 1}º nota do Aluno {i + 1} ");
                       n1[i, j] = float.Parse(Console.ReadLine());
                       while (n1[i,j] > 10)
                       {
                           Console.WriteLine("Nota não pode ser maior que 10");
                           Console.WriteLine($"Informe a {j + 1}º nota do Aluno {i + 1} ");
                           n1[i, j] = float.Parse(Console.ReadLine());
                       }
                       Media[i] += n1[i, j];
                   }
               }

               for (int i = 0; i < Media.Length; i++)
               {
                   Console.WriteLine($"A média do {i+1}ª aluno é: {Media[i] / 2}");

               }

               */

            float[,] Notas = new float[5, 3];

            Console.WriteLine("Informe as notas dos alunos: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Aluno [{i + 1}]:");
                    Console.WriteLine($"Informe a Nota {j + 1}");
                    Notas[i, j] = float.Parse(Console.ReadLine());
                }
            }

            for (int i = 0, z = 2; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Notas[i, z] += Notas[i, j];
                }
                Notas[i, z] /= z;
            }
            Console.WriteLine("As notas dos alunos da turma são: ");

            for (int i = 0, z = 2; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Aluno {i + 1}, Nota {j + 1}: {Notas[i, j]}");
                }
                Console.WriteLine($"Média: {Notas[i, z]}");
            }
        }
    }
}

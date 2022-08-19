using System;

namespace PMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 3];
            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[j, i] = r.Next(100);
                }
            }


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Matriz na coluna {i}");

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Matriz[{j},{i}] = {mat[j, i]} ");
                }

                Console.WriteLine();
            }






        }
    }
}

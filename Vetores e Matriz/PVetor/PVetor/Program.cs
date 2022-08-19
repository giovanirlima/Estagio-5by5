
using System;

namespace PVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char aux;
            int Cont1 = 0, Cont2 = 0, Cont3 = 0;
            int Cont4 = 0, Cont5 = 0, Cont6 = 0;
            char[] v1 = new char[5];
            char[] v2 = new char[5];
            char[] v3 = new char[10];

            for (int i = 0; i < v1.Length; i++)
            {
                v1[i] = char.Parse(Console.ReadLine().ToUpper());
            }

            for (int i = 0; i < v2.Length; i++)

            {
                v2[i] = char.Parse(Console.ReadLine().ToUpper());
            }

            Console.WriteLine();

            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write($"{v1[i]} ");
            }

            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write($"{v2[i]} ");
            }

            Console.WriteLine();

            for (int i = 0, j = 0; i < v3.Length; i++)
            {
                if (i < v1.Length)
                {
                    v3[i] = v1[i];
                }
                else
                {
                    v3[i] = v2[j];
                    j++;
                }

            }

            Console.WriteLine();

            for (int i = 0; i < v3.Length; i++)
            {
                Console.Write($"{v3[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] == 'A' || v1[i] == 'E' || v1[i] == 'I' || v1[i] == 'O' || v1[i] == 'U')
                {
                    Cont1++;
                    v1[i] = char.ToLower(v1[i]);
                }

                else
                {
                    Cont4++;
                }


                if (v2[i] == 'A' || v2[i] == 'E' || v2[i] == 'I' || v2[i] == 'O' || v2[i] == 'U')
                {
                    Cont2++;
                    v2[i] = char.ToLower(v2[i]);
                }

                else
                {
                    Cont5++;
                }
            }

            for (int i = 0; i < v3.Length; i++)
            {
                if (v3[i] == 'A' || v3[i] == 'E' || v3[i] == 'I' || v3[i] == 'O' || v3[i] == 'U')
                {
                    Cont3++;
                    v3[i] = char.ToLower(v3[i]);
                }
                else
                {
                    Cont6++;
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Vetor A possue {Cont1} vogais e {Cont4} consoantes");

            Console.WriteLine();

            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write($"{v1[i]} ");
            }
            Console.WriteLine("");

            Console.WriteLine($"\nVetor B possue {Cont2} vogais e {Cont5} consoantes");

            Console.WriteLine("");

            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write($"{v2[i]} ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"Vetor C possue {Cont3} vogais e {Cont6} consoantes");

            Console.WriteLine("");

            for (int i = 0; i < v3.Length; i++)
            {
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine("");

        }
    }
}

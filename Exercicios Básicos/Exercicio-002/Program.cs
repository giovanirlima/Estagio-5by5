//Faça um algoritmo que leia a data de nascimento de uma pessoa
//e calcule a sua idade em anos meses e dias
using System;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Obtendo data de aniversário e separando por váriavel;
            Console.WriteLine("Entre com a data de aniversario (dd/mm/aaaa): ");
            string[] vet = Console.ReadLine().Split('/');

            int diaA = int.Parse(vet[0]);
            int mesA = int.Parse(vet[1]);
            int anoA = int.Parse(vet[2]);

            Console.WriteLine("Entre com a data atual (dd/mm/aaaa): ");
            vet = Console.ReadLine().Split('/');

            int diaH = int.Parse(vet[0]);
            int mesH = int.Parse(vet[1]);
            int anoH = int.Parse(vet[2]);

            int anoBi = 0;

            for (int i = anoA; i <= anoH; i++)
            {
                if (i % 400 == 00 || i % 4 == 00 && i % 100 != 00)
                {
                    anoBi++;
                }
            }
            int idadeA = 0;
            int idadeM = 0;
            int idadeD = 0;

            if (mesA > mesH)
            {
                idadeA = anoH - anoA - 1;
                idadeM = ((idadeA + 1) * 12) - (mesA - mesH);
                idadeD = (idadeM * 30) + diaH + anoBi;
                Console.WriteLine($"A pessoa tem {idadeA} Anos ou {idadeM} Meses ou {idadeD} Dias.");
               
            }

            if (mesA == mesH)
            {
                if (diaA <= diaH)
                {
                    idadeA = anoH - anoA;
                    idadeM = idadeA * 12;
                    idadeD = (idadeM * 30) + diaH + anoBi;
                    Console.WriteLine($"A pessoa tem {idadeA} Anos ou {idadeM} Meses ou {idadeD} Dias.");
                }

                else
                {
                    idadeA = anoH - anoA - 1;
                    idadeM = ((idadeA + 1) * 12) - (mesA - mesH);
                    idadeD = (idadeM * 30) + diaH + anoBi;
                    Console.WriteLine($"A pessoa tem {idadeA} Anos ou {idadeM} Meses ou {idadeD} Dias.");
                }
            }

            if (mesA < mesH)
            {
                idadeA = anoH - anoA;
                idadeM = idadeA * 12;
                idadeD = (idadeM * 30) + diaH + anoBi;

                Console.WriteLine($"A pessoa tem {idadeA} Anos ou {idadeM} Meses ou {idadeD} Dias.");

            }
        }
    }
}
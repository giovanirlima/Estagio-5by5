//Faça um algoritmo que leia o nome de um aluno
//e o horario informado, baseado no horario mostre
//a mensagem, bom dia, boa tarde ou boa noite.

using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do Aluno: ");
            string Nome = Console.ReadLine();

            Console.Write("Informe o horário: (hh:mm:ss)");
            string[] vet = Console.ReadLine().Split(":");

            int Hora = int.Parse(vet[0]);
            int Minuto = int.Parse(vet[1]);
            int Segundo = int.Parse(vet[2]);

            while (Hora > 24)
            {
                Hora -= 24;
            }

            if (Hora >= 00 && Hora < 12)
            { 
                Console.WriteLine($"Boa dia, Aluno {Nome} agora são: {Hora}:{Minuto}:{Segundo}"); 
            }

            if (Hora > 11 && Hora < 18)
            { 
                Console.WriteLine($"Boa tarde, Aluno {Nome} agora são: {Hora}:{Minuto}:{Segundo}"); 
            }

            if (Hora > 17 && Hora <= 23)
            { 
                Console.WriteLine($"Boa noite, Aluno {Nome} agora são: {Hora}:{Minuto}:{Segundo}"); 
            }
        }
    }
}

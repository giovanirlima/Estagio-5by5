//CRIE UM PROGRAMA QUE CRIE 3 OBJETOS VINDO DE UMA CLASSE PESSOA QUE TEM QUATRO ATRIBUTOS,
//NOME,
//DATA DE NASCIMENTO
//CPF
//TELEFONE

using System;
using Exercicio1.Entidades;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] p = new Pessoa[3];


            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Pessoa();

                Console.Write($"Informe o nome da {i + 1}º pessoa: ");
                p[i].Nome = Console.ReadLine();

                Console.Write($"Informe a data de nascimento da {i + 1}º pessoa: ");
                p[i].Nascimento = DateTime.Parse(Console.ReadLine());

                Console.Write($"Informe o CPF da {i + 1}º pessoa: ");
                p[i].CPF = long.Parse(Console.ReadLine());

                Console.Write($"Informe o telefone da {i + 1}º pessoa: ");
                p[i].Telefone = long.Parse(Console.ReadLine());
            }

            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i].ToString());
                Console.WriteLine();
            }
        }
    }
}

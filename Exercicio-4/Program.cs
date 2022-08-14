//1 - Faça um algoritmo que leia 4 notas de um aluno
//e calcule a sua média de acordo com o resultado informe
//se ele esta aprovado, de recuperação ou reprovado seguindo
//os seguintes critérios. 1º REPROVADO até menor que 5
//2º Recuperação maior ou igual a 5 e menor que 7
//3ºe aprovado 7 a 10.

using System;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota do aluno: ");
            double N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do aluno: ");
            double N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do aluno: ");
            double N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do aluno: ");
            double N4 = double.Parse(Console.ReadLine());

            double Media = (N1 + N2 + N3 + N4) / 4;

            if (Media < 5) { Console.WriteLine($"Aluno reprovado, Média: {Media.ToString("F1")}"); }

            if (Media >= 5 && Media < 7) { Console.WriteLine($"Aluno de Recuperação, Média: {Media.ToString("F1")}"); }

            if (Media >= 7 && Media <= 10 ) { Console.WriteLine($"Aluno aprovado, Média: {Media.ToString("F1")}"); }

            if (Media > 10) { Console.WriteLine("Nota do aluno não pode ser superior a 10,0"); }
            
        }
    }
}

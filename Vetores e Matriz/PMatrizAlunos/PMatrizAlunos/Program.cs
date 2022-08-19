/*Elabore um programa que:
a) Leia a quantidade de alunos de uma sala.
b) Leia o nome de cada aluno e em seguida, cada uma das notas.
c) Após ler todos os valores calcule a média do aluno e salve o valor na ultima coluna de sua matriz
d) No final imprima o "Boletim do Aluno" informando se foi aprovado ou reprovado, UM DE CADA VEZ, pausando a tela da leitura.
Utilizar função o máximo possivél.

EX:

Nome do aluno: "Giovani"

Nota 1 nota 2 Média
10.0 5.0 7,5

Situação: XXXXX

Para informar a situação, use o seguinte critério:

REPROVADO > nota até 6
APROVADO > a partir de 6, até 10.0;*/

using System;

namespace PMatrizAlunos
{
    internal class Program
    {
        static int QtdAluno()
        {
            Console.Write("Informe quantos alunos possue na sala: ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("é necessário ter pelo menos um aluno para nota\n");
                Console.Write("Informe quantos alunos possuem na sala: ");
                n = int.Parse(Console.ReadLine());
            }

            return n;
        }
        static string[] CriarVetor(int n)
        {
            return new string[n];
        }
        static float[,] CriarMatriz(int n)
        {
            return new float[n, 3];
        }
        static string LerNome()
        {
            string nome;
            Console.WriteLine();
            Console.Write($"Informe o nome do Aluno: ");
            nome = Console.ReadLine();

            return nome;
        }
        static float LerNota()
        {
            Console.Write($"Nota: ");
            float nota = float.Parse(Console.ReadLine());

            while (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota não pode ser menor que 0 ou maior que 10\n");

                Console.Write($"Nota: ");
                nota = float.Parse(Console.ReadLine());
            }

            return nota;

        }
        static float Media(float[,] n1, int i)
        {
            int j;
            float m = 0;
            for (j = i; i == j; i++)
            {
                m = ((n1[i, 0] + n1[i, 1]) / 2);
            }
            return m;
        }
        static void Verificador(float[,] n2, int i)
        {
            int j = 0;
            for (j = i; i == j; i++)
            {
                if (n2[i, 2] >= 6)
                {
                    Console.WriteLine("Situação: APROVADO!");
                }

                else
                {
                    Console.WriteLine("Situação: REPROVADO!");
                }
            }
        }
        static void Impressao(float[,] aluno,string[] nome, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nBoletim do aluno\n");
                Console.Write($"Nome do aluno: {nome[i]}\n\n");

                Console.Write($"Nota 1 \tNota 2 \tMédia \n");
                Console.Write($"{aluno[i, 0]}\t{aluno[i, 1]}\t{aluno[i, 2]}\n\n");

                Verificador(aluno, i);

                Console.ReadKey();

                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            int qtdAluno;
            string[] nome;
            float[,] aluno;

            qtdAluno = QtdAluno();
            nome = CriarVetor(qtdAluno);
            aluno = CriarMatriz(qtdAluno);

            for (int i = 0; i < qtdAluno; i++)
            {
                nome[i] = LerNome();

                for (int j = 0; j < 2; j++)
                {
                    aluno[i, j] = LerNota();
                }
            }

            for (int i = 0; i < qtdAluno; i++)
            {
                aluno[i, 2] = Media(aluno, i);
            }

            Impressao(aluno, nome, qtdAluno);

        }
    }
}
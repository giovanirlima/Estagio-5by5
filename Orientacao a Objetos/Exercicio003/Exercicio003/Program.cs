//FAÇA UM PROGRAMA QUE CRIE OBJETOS FILHOS DE UMA CLASSE PAI PESSOA,
//AS CLASSES TERÃO NOME DE ALUNO E FUNCIONÁRIO, A CLASSE PAI TEM OS SEGUINTES ATRIBUTOS:
using System;
using Exercicio003.Entidade;

namespace Exercicio003
{
    internal class Program
    {
        static int QuantidadePessoas()
        {
            int qtd = 0;
            bool verificacao = false;

            do
            {
                Console.Write("Informe quantas pessoas deseja cadastrar: ");
                try
                {
                    qtd = int.Parse(Console.ReadLine());
                    verificacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Error! Tipo de valor informado é inválido!\n");
                    verificacao = true;
                }

                if (qtd < 0)
                {
                    Console.WriteLine("Informe um número maior ou igual a zero\n");
                    verificacao = true;
                }

            } while (verificacao);

            return qtd;
        }
        static int QuantidadeAlunos()
        {
            int qtd = 0;
            bool verificacao = false;

            do
            {
                Console.Write("\nInforme quantos alunos(a) deseja cadastrar: ");
                try
                {
                    qtd = int.Parse(Console.ReadLine());
                    verificacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Error! Tipo de valor informado é inválido!\n");
                    verificacao = true;
                }

                if (qtd < 0)
                {
                    Console.WriteLine("Informe um número maior ou igual a zero\n");
                    verificacao = true;
                }

            } while (verificacao);

            return qtd;
        }
        static int QuantidadeFuncionarios()
        {
            int qtd = 0;
            bool verificacao = false;

            do
            {
                Console.Write("\nInforme quantos funcionarios(a) deseja cadastrar: ");
                try
                {
                    qtd = int.Parse(Console.ReadLine());
                    verificacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Error! Tipo de valor informado é inválido!\n");
                    verificacao = true;
                }

                if (qtd < 0)
                {
                    Console.WriteLine("Informe um número maior ou igual a zero\n");
                    verificacao = true;
                }

            } while (verificacao);

            return qtd;
        }

        static void Main(string[] args)
        {
            int qtdP, qtdA, qtdF;

            Pessoa[] pessoa;
            Aluno[] aluno;
            Funcionario[] funcionario;

            qtdP = QuantidadePessoas();
            pessoa = new Pessoa[qtdP];

            for (int i = 0; i < qtdP; i++)
            {
                pessoa[i] = new Pessoa();

                pessoa[i].CadastrarPessoa(pessoa, i);
            }

            Console.Clear();

            qtdA = QuantidadeAlunos();
            aluno = new Aluno[qtdA];

            for (int i = 0; i < qtdA; i++)
            {
                aluno[i] = new Aluno();
                aluno[i].CadastrarAluno(aluno, i);
            }

            Console.Clear();

            qtdF = QuantidadeFuncionarios();
            funcionario = new Funcionario[qtdF];

            for (int i = 0; i < qtdF; i++)
            {
                funcionario[i] = new Funcionario();
                funcionario[i].CadastrarFuncionario(funcionario, i);
            }

            Console.Clear();

            for (int i = 0; i < qtdP; i++)
            {
                Console.WriteLine(pessoa[i]);
                Console.ReadKey();
            }

            Console.Clear();

            for (int i = 0; i < qtdA; i++)
            {
                Console.WriteLine(aluno[i]);
                Console.ReadKey();
            }

            Console.Clear();

            for (int i = 0; i < qtdF; i++)
            {
                Console.WriteLine(funcionario[i]);
                Console.ReadKey();
            }
        }
    }
}

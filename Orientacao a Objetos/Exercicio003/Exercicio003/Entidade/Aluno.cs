//ALUNO
//{
//    RA
//   DATA DE MATRICULA
//}


using System;

namespace Exercicio003.Entidade
{
    internal class Aluno : Pessoa
    {
        internal string Ra { get; set; }
        internal DateTime DataDaMatricula { get; set; }
        public Aluno()
        {
        }
        public Aluno(string ra, DateTime dataDaMatricula, string nome, DateTime nascimento, long cpf) : base(nome, nascimento, cpf)
        {
            Ra = ra;
            DataDaMatricula = dataDaMatricula;
        }

        public Aluno[] CadastrarAluno(Aluno[] aluno, int cont)
        {
            bool validacao = false;

            Console.Write("\nInforme o nome do Aluno: ");
            aluno[cont].Nome = Console.ReadLine();

            do
            {
                Console.Write("Informe a data de nascimento da aluno: ");
                try
                {
                    aluno[cont].Nascimento = DateTime.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informados é inválido\n");
                    validacao = true;
                }
            } while (validacao);

            do
            {
                Console.Write("Informe o CPF do aluno: ");
                try
                {
                    aluno[cont].Cpf = long.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido\n");
                    validacao = true;
                }
                if (aluno[cont].Cpf < 0)
                {
                    Console.WriteLine("Não existe CPF com números negativos!\n");
                    validacao = true;
                }
            } while (validacao);

            Console.Write("Informe o RA do Aluno: ");
            aluno[cont].Ra = Console.ReadLine();

            do
            {
                Console.Write("Informe data de matricula do Aluno: ");
                try
                {
                    aluno[cont].DataDaMatricula = DateTime.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido");
                    Console.WriteLine("(dd/mm/aaaa)\n");
                    validacao = true;
                }

            } while (validacao);

            return aluno;
        }

        public override string ToString()
        {
            return $"\nAlunos Cadastrados  \nNome: {Nome}\nNascimento: {Nascimento.ToLongDateString()}\nCPF: {Cpf}\nRA: {Ra}\nData da matricula: {DataDaMatricula.ToLongDateString()}";
        }

    }
}

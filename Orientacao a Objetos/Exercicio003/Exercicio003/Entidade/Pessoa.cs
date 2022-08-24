//PESSOA
//{
//    NOME
//    DATA DE NASCIMENTO
//    CPF
//}
using System;


namespace Exercicio003.Entidade
{
    internal class Pessoa
    {
        internal string Nome { get; set; }
        internal DateTime Nascimento { get; set; }
        internal long Cpf { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, DateTime nascimento, long cpf)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
        }
        public Pessoa[] CadastrarPessoa(Pessoa[] p, int cont)
        {
            bool validacao = false;

            Console.Write("\nInforme o nome da pessoa: ");
            p[cont].Nome = Console.ReadLine();

            do
            {
                Console.Write("Informe a data de nascimento da pessoa: ");
                try
                {
                    p[cont].Nascimento = DateTime.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido\n");
                    validacao = true;
                }
            } while (validacao);

            do
            {
                Console.Write("Informe o CPF da pessoa: ");
                try
                {
                    p[cont].Cpf = long.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido, digite apenas números\n");
                    validacao = true;
                }
                if (p[cont].Cpf < 0)
                {
                    Console.WriteLine("Não existe CPF com números negativos!\n");
                    validacao = true;
                }
            } while (validacao);

            return p;
        }
        public override string ToString()
        {
            return $"\nPessoas Cadastradas  \nNome: {Nome}\nNascimento: {Nascimento.ToLongDateString()}\nCPF: {Cpf}";
        }

    }
}



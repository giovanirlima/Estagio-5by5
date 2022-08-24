//FUNCIONARIO
//{
//NUMERO DO PIS
//SALARIO
//SETOR
//}
using System;

namespace Exercicio003.Entidade
{
    internal class Funcionario : Pessoa
    {
        internal long Pis { get; set; }
        internal double Salario { get; set; }
        internal string Setor { get; set; }

        public Funcionario()
        {
        }
        public Funcionario(long pis, double salario, string setor, string nome, DateTime nascimento, long cpf) : base(nome, nascimento, cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }
        public Funcionario[] CadastrarFuncionario(Funcionario[] fun, int cont)
        {

            bool validacao = false;

            Console.Write("\nInforme o nome do funcionário: ");
            fun[cont].Nome = Console.ReadLine();

            do
            {
                Console.Write("Informe a data de nascimento do funcionário: ");
                try
                {
                    fun[cont].Nascimento = DateTime.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido");
                    Console.WriteLine("(dd/mm/yyyy)\n");
                    validacao = true;
                }
            } while (validacao);

            do
            {
                Console.Write("Informe o CPF do funcionário: ");
                try
                {
                    fun[cont].Cpf = long.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido, digite apenas números\n");
                    validacao = true;
                }
                if (fun[cont].Cpf < 0)
                {
                    Console.WriteLine("Não existe CPF com números negativos!\n");
                    validacao = true;
                }

            } while (validacao);

            do
            {
                Console.Write("Informe o Pis do funcionário: ");
                try
                {
                    fun[cont].Pis = long.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido, digite apenas números\n");
                    validacao = true;
                }
                if (fun[cont].Pis < 0)
                {
                    Console.WriteLine("Não existe Pis com números negativos!\n");
                    validacao = true;
                }

            } while (validacao);

            do
            {
                Console.Write("Informe o salário do funcionário: ");
                try
                {
                    fun[cont].Salario = double.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Parametros informado é inválido, digite apenas números\n");
                    validacao = true;
                }
                if (fun[cont].Salario < 0)
                {
                    Console.WriteLine("Não existe salário com números negativos!\n");
                    validacao = true;
                }

            } while (validacao);

             Console.Write("Informe o Setor que o Funcionário trabalha: ");
            fun[cont].Setor = Console.ReadLine();
            return fun;
        }

        public override string ToString()
        {

            return $"\nFuncionarios Cadastrados  \nNome: {Nome}\nNascimento: {Nascimento.ToLongDateString()}\nCPF: {Cpf}\nPis: {Pis}\nSalario: R${Salario.ToString("F2")}\nSetor: {Setor}";

        }

    }
}


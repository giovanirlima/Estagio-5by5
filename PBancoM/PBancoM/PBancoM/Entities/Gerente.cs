using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Gerente : Funcionario
    {
        public Gerente()
        {
        }
        public Gerente(string nome, int matricula, Agencia agencia) : base(nome, matricula, agencia)
        {
        }

        public Funcionario CadastrarFuncionario(int contador)
        {
            Funcionario[] funcionario = new Funcionario[contador];
            Funcionario[] gerente = new Gerente[contador];
            char tipo = 'a';
            bool validacao = false;

            Console.WriteLine("Olá Gerente");
            Console.Write("Informe o nome do novo funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a matricula do funcionário: ");
            int matricula = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("O fúncionario será um novo gerente (s/n)?");
                try
                {
                    tipo = char.Parse(Console.ReadLine().ToLower());
                    validacao = false;
                }

                catch (Exception)
                {
                    Console.WriteLine("Opção informada é inválida!");
                    Console.WriteLine("Informe s ou n!");
                    validacao = true;
                }

                if (tipo != 's' || tipo != 'n')
                {
                    Console.WriteLine("Informe s ou n!");
                    validacao = true;
                }

            } while (validacao);

            Console.Write("Informe id da agência que o funcionário irá trabalhar: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("informe o nome da rua da agência: ");
            string rua = Console.ReadLine();

            Console.Write("Informe o número da agência: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Informe a cidade da agência: ");
            string cidade = Console.ReadLine();

            Endereco endereco = new Endereco(rua, cidade, n);
            Agencia agencia = new Agencia(id, endereco);

            if (tipo == 's')
            {
                return gerente[contador] = new Gerente(nome, matricula, agencia);
            }

            else
            {
                return funcionario[contador] = new Funcionario(nome, matricula, agencia);
            }
        }
        void CadastrarAgencia()
        {

        }

        void AprovarEmprestimo()
        {

        }
        public bool AprovarConta(string nome, string cpf, DateTime nascimento, string telefone, Endereco endereco, double renda)
        {
            Console.WriteLine("Olá sr. Gerente");
            Console.WriteLine("Dados do cliente para aprovação: ");
            Console.WriteLine($"Nome: {nome}\nCPF: {cpf}\nData de Nascimento: {nascimento}" +
                              $"\nTelefone: {telefone}\nRenda mensal: {renda}");

            Console.Write("Deseja aprovar criação da conta: SIM/NAO");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim" || resposta == "s")
            {
                Console.WriteLine("Conta aprovada!");
                Console.WriteLine("Prossiga com o cadastro!");
                return true;
            }

            else
            {
                Console.WriteLine("Conta não aprovada!");
                Console.WriteLine("Cadastro negado!");
                return false;
            }

        }

    }
}

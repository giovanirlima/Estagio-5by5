using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

        public Funcionario CadastrarFuncionario(Funcionario[] funcionario, int contador)
        {
            char tipo = 'a';
            bool validacao = false;

            Console.WriteLine("Olá Gerente");
            Console.Write("Informe o nome do novo funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a matricula do funcionário: ");
            int matricula = int.Parse(Console.ReadLine());                   

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
                return funcionario[contador] = new Gerente(nome, matricula, agencia);
            }

            else
            {
                return funcionario[contador] = new Funcionario(nome, matricula, agencia);
            }
        }
        public Agencia CadastrarAgencia(Agencia[] agencia, int contador)
        {
            bool verificacao = false;
            int id = 0;
            Console.WriteLine("Olá, Sr. Gerente");
            do
            {
                Console.Write("Informe id da agencia: ");
                id = int.Parse(Console.ReadLine());

                for (int i = 0; i < contador; i++)
                {
                    if (agencia[i].Id == id)
                    {
                        Console.WriteLine("Já existe este ID cadastrado");
                        verificacao = true;
                    }
                }
            } while (verificacao);

            Endereco endereco = new Endereco();

            endereco.CadastrarEndereco();

            return agencia[contador] = new Agencia(id, endereco);
        }
        public bool AprovarEmprestimo(Cliente[] cliente, int contCliente, double emprestimo)
        {
            bool validacao = false;

            Console.WriteLine("olá sr.(a) Gerente!");
            Console.WriteLine("Pedido de empréstimo para aprovação");
            Console.WriteLine($"Nome: {cliente[contCliente].Nome}");
            Console.WriteLine($"Renda: {cliente[contCliente].Renda}");
            Console.WriteLine($"Valor solicitado: {emprestimo.ToString("F2")}");
            Console.WriteLine();
            do
            {
                Console.WriteLine("1 - Aprovar\n2 - Recusar");
                int resposta = int.Parse(Console.ReadLine());
                validacao = false;


                if (resposta != 1 || resposta != 2)
                {
                    Console.WriteLine("Opção escolhida é inexistente!");
                    Console.WriteLine("Escolha 1 ou 2");
                    Console.Clear();
                    validacao = true;
                    return false;
                }
                else
                {
                    if (resposta == 1)
                    {
                        Console.WriteLine("Pedido de empréstimo aprovado");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Pedido de empréstimo reprovado");
                        return false;
                    }
                }
            } while (validacao);

        }
        public bool AprovarConta(string nome, string cpf, DateTime nascimento, string telefone, double renda)
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

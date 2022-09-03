using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;


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

        public Gerente CadastrarGerente(Gerente[] gerente, Funcionario[] funcionario, Agencia[] agencias, int contGerente, int contFuncionario, int contAgencia)
        {
            Console.Clear();
            Console.WriteLine("Olá Gerente\n");
            Console.Write("Informe o nome do novo funcionário: ");
            string nome = Console.ReadLine();

            bool validacao;
            int matricula;

            do
            {
                Console.Write("Informe a matricula do novo funcionário: ");
                matricula = int.Parse(Console.ReadLine());

                validacao = false;

                for (int i = 0; i < contGerente; i++)
                {
                    if (gerente[i].Matricula == matricula)
                    {
                        Console.WriteLine($"\nO Gerente {gerente[i].Nome} já possue está mátricula!");
                        Console.WriteLine("Necessário escolher uma nova!\n");
                        validacao = true;
                    }
                }

                for (int i = 0; i < contFuncionario; i++)
                {
                    if (funcionario[i].Matricula == matricula)
                    {
                        Console.WriteLine($"\nO Funcionário {funcionario[i].Nome} já possue está mátricula!");
                        Console.WriteLine("Necessário escolher uma nova!\n");
                        validacao = true;
                    }
                }

            } while (validacao);

            Console.Clear();

            Console.WriteLine("Informe o id da agência que o funcionario será registrado");

            for (int i = 0; i < contAgencia; i++)
            {

                Console.WriteLine(agencias[i].ToString());

            }

            Console.Write("\nID: ");

            int idAgencia = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionário cadastrado com sucesso!");

            Console.WriteLine("\nPressione Enter para continuar!");
            Console.ReadKey();

            return gerente[contGerente] = new Gerente(nome, matricula, agencias[idAgencia-1]);

        }
        public Funcionario CadastrarFuncionario(Funcionario[] funcionario, Gerente[] gerente, Agencia[] agencias, int contFuncionario, int contGerente, int contAgencia)
        {
            Console.Clear();
            Console.WriteLine("Olá Gerente\n");
            Console.Write("Informe o nome do novo funcionário: ");
            string nome = Console.ReadLine();

            bool validacao;
            int matricula;

            do
            {
                Console.Write("Informe a matricula do novo funcionário: ");
                matricula = int.Parse(Console.ReadLine());

                validacao = false;

                for (int i = 0; i < contFuncionario; i++)
                {
                    if (funcionario[i].Matricula == matricula)
                    {
                        Console.WriteLine($"\nO Funcionário {funcionario[i].Nome} já possue está mátricula!");
                        Console.WriteLine("Necessário escolher uma nova!\n");
                        validacao = true;
                    }
                }
                for (int i = 0; i < contGerente; i++)
                {
                    if (gerente[i].Matricula == matricula)
                    {
                        Console.WriteLine($"\nO Gerente {gerente[i].Nome} já possue está mátricula!");
                        Console.WriteLine("Necessário escolher uma nova!\n");
                        validacao = true;
                    }
                }

            } while (validacao);

            Console.Clear();

            Console.WriteLine("Informe o id da agência que o funcionario será registrado");

            for (int i = 0; i < contAgencia; i++)
            {

                Console.WriteLine(agencias[i].ToString());

            }

            Console.Write("\nID: ");

            int idAgencia = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionário cadastrado com sucesso!");

            Console.WriteLine("\nPressione Enter para continuar!");
            Console.ReadKey();

            return funcionario[contFuncionario] = new Funcionario(nome, matricula, agencias[idAgencia-1]);

        }
        public Agencia CadastrarAgencia(Agencia[] agencia, int contAgencia)
        {
            bool verificacao = false;
            int id = 0;

            Console.Clear();

            Console.WriteLine("Olá, Sr. Gerente");
            do
            {
                Console.Write("\nInforme id da nova agência: ");
                id = int.Parse(Console.ReadLine());
                verificacao = false;

                for (int i = 0; i < contAgencia; i++)
                {
                    if (agencia[i].Id == id)
                    {
                        Console.WriteLine("\nJá existe este ID cadastrado");
                        verificacao = true;

                    }
                }

            } while (verificacao);

            Endereco endereco = new Endereco();

            return agencia[contAgencia] = new Agencia(id, endereco.CadastrarEndereco());

        }
        public bool AprovarEmprestimo(Cliente[] cliente, int i, double emprestimo)
        {
            bool validacao = false;

            Console.Clear();

            Console.WriteLine("olá sr.(a) Gerente!");
            Console.WriteLine("\nPedido de empréstimo para aprovação");
            Console.WriteLine($"Nome: {cliente[i].Nome}");
            Console.WriteLine($"Renda: R$ {cliente[i].Renda}");
            Console.WriteLine($"Valor solicitado: R$ {emprestimo.ToString("F2")}");
            Console.WriteLine();
            do
            {
                Console.WriteLine("1 - Aprovar\n2 - Recusar");
                Console.Write("\nOpção: ");
                int resposta = int.Parse(Console.ReadLine());
                validacao = false;


                if (resposta != 1 && resposta != 2)
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
                        return true;
                    }
                    else
                    {                        
                        return false;                        
                    }
                }
            } while (validacao);

        }
        public bool AprovarConta(string nome, string cpf, DateTime nascimento, string telefone, double renda)
        {
            Console.Clear();
            Console.WriteLine("Olá sr. Gerente\n");
            Console.WriteLine("Dados do cliente para aprovação: ");
            Console.WriteLine($"Nome: {nome}\nCPF: {cpf}\nData de Nascimento: {nascimento.ToShortDateString()}" +
                              $"\nTelefone: {telefone}\nRenda mensal: R${renda.ToString("F2")}");

            Console.WriteLine("Deseja aprovar criação da conta: SIM/NAO");

            Console.Write("\nResposta: ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim" || resposta == "s")
            {
                Console.WriteLine("\nConta aprovada!");
                Console.WriteLine("Prossiga com o cadastro!");

                Console.WriteLine("Pressione enter para continuar!");
                Console.ReadKey();
                return true;
            }

            else
            {
                Console.WriteLine("\nConta não aprovada!");
                Console.WriteLine("Cadastro negado!");
                Console.ReadKey();
                return false;
            }

        }
        public void VerAgenciasCadastradas(Agencia[] agencia, int contAgencia)
        {
            for (int i = 0; i < contAgencia; i++)
            {
                Console.WriteLine(agencia[i].ToString());
            }

            Console.ReadKey();

            Console.Clear();
        }
        public void VerFuncionariosCadastrados(Gerente[] gerente, Funcionario[] funcionario, int contGerente, int contFuncionario)
        {
            
            Console.WriteLine("Gerentes cadastrados: ");

            for (int i = 0; i < contGerente; i++)
            {
                Console.WriteLine(gerente[i].ToString());
            }

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Funcionarios cadastrados: ");
            
            for (int i = 0; i < contFuncionario; i++)
            {
                Console.WriteLine(funcionario[i].ToString());
            }

            Console.ReadKey();

            Console.Clear();

        }
        public void VerClientesCadastrados(Cliente[] cliente, int contCliente)
        {
            Console.WriteLine("Clientes cadastrados:\n");

            for (int i = 0; i < contCliente; i++)
            {
                Console.WriteLine(cliente[i].ToString());
            }

            Console.ReadKey();

            Console.Clear();
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}\nMatricula: {Matricula}{Agencia.ToString()}";
        }
    }
}

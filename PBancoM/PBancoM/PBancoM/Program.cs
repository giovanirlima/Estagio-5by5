using System;
using PBancoM.Entities;

namespace PBancoM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, contFuncionario = 0, contCliente = 0, contAgencia = 0;
            bool validacao = false;
            char resposta;
            Gerente g = new Gerente();
            Gerente[] gerentes = new Gerente[contFuncionario];
            Funcionario[] funcionarios = new Funcionario[contFuncionario];
            Cliente[] clientes = new Cliente[contCliente];
            Agencia[] agencias = new Agencia[contAgencia];
            ContaCorrente[] contas = new ContaCorrente[contCliente];


            do
            {
                Console.WriteLine("Olá Gerente, Infome a opção desejada: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Cadastrar Agência");
                Console.WriteLine("4 - Ir para o página de usúario menu >");
                Console.WriteLine();
                Console.WriteLine("0 - Sair");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                    validacao = false;
                }
                catch (System.FormatException)
                {

                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha uma das opções informadas!");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    validacao = true;
                }
                if (opc < 0)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha uma das opções informadas!");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    validacao = true;
                }

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Novo funcionário é um gerente? (s/n)");
                        resposta = char.Parse(Console.ReadLine().ToLower());

                        if (resposta == 's')
                        {
                            funcionarios[contFuncionario] = g.CadastrarFuncionario(funcionarios, contFuncionario);
                            contFuncionario++;
                            Console.Clear();
                        }
                        else
                        {
                            gerentes[contFuncionario] = g.CadastrarFuncionario(funcionarios, contFuncionario);
                            contFuncionario++;
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        clientes[contCliente] = g.CadastrarCliente(clientes, contas, agencias, contCliente, contAgencia);
                        contCliente++;
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        g.CadastrarAgencia(agencias, contAgencia);
                        contAgencia++;
                        Console.Clear();
                        break;

                    case 4:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Olá usúario, Infome a opção desejada: ");
                            Console.WriteLine("");
                            Console.WriteLine("1 - Solicitar abertura de conta");
                            Console.WriteLine("2 - Desbloquear cartão");
                            Console.WriteLine("3 - Cadastrar Agência");
                            Console.WriteLine("4 - Ir para o página de usúario menu >");
                            Console.WriteLine();
                            Console.WriteLine("0 - Sair");
                        } while (true);



                        break;
                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                }

            } while (validacao);





   
        }
    }
}

using System;
using System.Data;
using PBancoM.Entities;

namespace PBancoM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, contFuncionario = 0, contGerentes = 0, contCliente = 0, contAgencia = 0;
            bool validacao = false;
            char resposta;

            Gerente g = new Gerente();
            Gerente[] gerentes = new Gerente[10];
            Funcionario[] funcionarios = new Funcionario[10];
            Cliente[] clientes = new Cliente[10];
            Agencia[] agencias = new Agencia[10];
            ContaCorrente[] contasCorrentes = new ContaCorrente[10];
            ContaPoupanca[] contasPoupancas = new ContaPoupanca[10];


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

                        if (resposta == 'n')
                        {
                            funcionarios[contFuncionario] = g.CadastrarFuncionario(funcionarios, contFuncionario);
                            contFuncionario++;
                            Console.Clear();
                        }
                        else
                        {
                            gerentes[contGerentes] = g.CadastrarGerente(gerentes, contGerentes);
                            contGerentes++;
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        clientes[contCliente] = g.CadastrarCliente(clientes, contasCorrentes, contasPoupancas, agencias, contCliente, contAgencia);
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
                            Console.WriteLine("3 - Ir para o página de usúario menu >");
                            Console.WriteLine();
                            Console.WriteLine("0 - Voltar para o menu anterior");
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
                                    clientes[contCliente].SolicitarAbertura(clientes, contasCorrentes, contasPoupancas, agencias, contCliente, contAgencia);
                                    contCliente++;
                                    break;

                                case 2:

                                    break;

                                case 0:
                                    Console.Clear();
                                    break;


                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                                    
                                    

                            }


                        } while (opc != 0);



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

            } while (opc != 0);


            




        }
    }
}

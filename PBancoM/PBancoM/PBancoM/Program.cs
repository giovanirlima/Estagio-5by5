using System;
using System.Data;
using PBancoM.Entities;

namespace PBancoM
{
    internal class Program
    {
        static Gerente[] IniciarGerentes(Gerente[] gerentes, Agencia[] agencias)
        {
            gerentes[0] = new Gerente("Pestana", 123, agencias[0]);
            gerentes[1] = new Gerente("Papini", 345, agencias[1]);
            gerentes[2] = new Gerente("Fabricio", 678, agencias[2]);

            return gerentes;

        }
        static Funcionario[] IniciarFuncionarios(Funcionario[] funcionarios, Agencia[] agencias)
        {
            funcionarios[0] = new Funcionario("Giovani", 234, agencias[0]);
            funcionarios[1] = new Funcionario("Rocha", 567, agencias[1]);
            funcionarios[2] = new Funcionario("Lima", 891, agencias[2]);

            return funcionarios;
        }
        static Agencia[] IniciarAgencias(Agencia[] agencias)
        {
            agencias[0] = new Agencia(1, new Endereco("R: Alfredo Botta", "Araraquara", 407));
            agencias[1] = new Agencia(2, new Endereco("R: Pedro Cunha", "Araraquara", 408));
            agencias[2] = new Agencia(3, new Endereco("R: Joao Gomes", "Araraquara", 409));

            return agencias;
        }
        static Cliente[] IniciarClientes(Cliente[] cliente, Agencia[] agencia)
        {
            cliente[0] = new Cliente("João", "123.157.259-55", new DateTime(1994, 12, 03), "(15) 99665-1799", new Endereco("R: Fabio papini", "Araraquara", 915), 1000, new ContaCorrente(123, agencia[0]), new ContaPoupanca(123, agencia[0], 0), new Cartao(123, 0, 30));
            cliente[1] = new Cliente("Pedro", "145.177.229-33", new DateTime(1970, 01, 05), "(15) 99662-1855", new Endereco("R: Mario Pestana", "Araraquara", 917), 2000, new ContaCorrente(321, agencia[1]), new ContaPoupanca(321, agencia[1], 0), new Cartao(321, 0, 30));
            cliente[2] = new Cliente("Mário", "773.152.524-00", new DateTime(1986, 07, 13), "(15) 99725-6614", new Endereco("R: Alamedas", "Araraquara", 325), 5000, new ContaCorrente(456, agencia[2]), new ContaPoupanca(456, agencia[2], 0), new Cartao(456, 0, 30));

            return cliente;
        }
        static int MenuInicial()
        {
            int opcao = 0;
            bool validacao;

            do
            {
                Console.WriteLine("BEM-VINDO AO BANCO MORANGAO");
                Console.WriteLine("\nVocê é um: \n");
                Console.WriteLine("1 - Funcionario");
                Console.WriteLine("2 - Cliente");
                Console.Write("\nOpção: ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
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
                if (opcao < 0 || opcao > 6)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha uma das opções informadas!");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    validacao = true;
                }

            } while (validacao);

            return opcao;
        }
        static void MenuFuncionario()
        {

        }
        static int MenuGerente()
        {
            int opcao = 0;
            bool validacao;

            do
            {
                Console.WriteLine("Olá Gerente, ");
                Console.WriteLine("\nInfome a opção desejada: \n");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Cadastrar Agência");
                Console.WriteLine("4 - Ver Funcionarios cadastrados");
                Console.WriteLine("5 - Ver Clientes cadastrados");
                Console.WriteLine("6 - Ver Agências cadastradas");
                Console.WriteLine("\n0 - Sair");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
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
                if (opcao < 0 || opcao > 6)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha uma das opções informadas!");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    validacao = true;
                }

            } while (validacao);

            return opcao;
        }
        static void MenuCliente()
        {

        }


        static void Main(string[] args)
        {
            int opcao = 0, contadorDeFuncionario = 3, contadorDeGerente = 3, contadorDeClientes = 3, contadorDeAgencias = 3, ContadorDePagamentos = 0;
            bool condicaoDeParada = false;
            char resposta;

            Gerente g = new Gerente(); Cliente c = new Cliente();
            Gerente[] gerentes = new Gerente[10];
            Funcionario[] funcionarios = new Funcionario[10];
            Cliente[] clientes = new Cliente[10];
            Agencia[] agencias = new Agencia[10];
            ContaCorrente[] contasCorrentes = new ContaCorrente[10];
            ContaPoupanca[] contasPoupancas = new ContaPoupanca[10];
            Cartao[] cartaoCCorrente = new Cartao[10];

            IniciarAgencias(agencias);
            IniciarGerentes(gerentes, agencias);
            IniciarFuncionarios(funcionarios, agencias);
            IniciarClientes(clientes, agencias);

            do
            {
                Console.WriteLine("Olá Gerente, Infome a opção desejada: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Cadastrar Agência");
                Console.WriteLine("4 - Ver Funcionarios cadastrados");
                Console.WriteLine("5 - Ver Clientes cadastrados");
                Console.WriteLine("6 - Ver Agências cadastradas");
                Console.WriteLine("7 - Ir para página de usúario >");
                Console.WriteLine();
                Console.WriteLine("0 - Sair");
                Console.Write("\nOpção: ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    condicaoDeParada = false;
                }
                catch (System.FormatException)
                {

                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha uma das opções informadas!");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    condicaoDeParada = true;
                }
                if (opcao < 0 || opcao > 7)
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("\nEscolha uma das opções informadas!");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    condicaoDeParada = true;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Novo funcionário é um gerente? (s/n) ");
                        resposta = char.Parse(Console.ReadLine().ToLower());

                        if (resposta == 'n')
                        {
                            funcionarios[contadorDeFuncionario] = g.CadastrarFuncionario(funcionarios, gerentes, agencias, contadorDeFuncionario, contadorDeGerente, contadorDeAgencias);
                            contadorDeFuncionario++;
                            Console.Clear();
                        }
                        else
                        {
                            gerentes[contadorDeGerente] = g.CadastrarGerente(gerentes, funcionarios, agencias, contadorDeGerente, contadorDeFuncionario, contadorDeAgencias);
                            contadorDeGerente++;
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        clientes[contadorDeClientes] = g.CadastrarCliente(clientes, contasCorrentes, contasPoupancas, cartaoCCorrente, agencias, contadorDeClientes, contadorDeAgencias);
                        contadorDeClientes++;
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        g.CadastrarAgencia(agencias, contadorDeAgencias);
                        contadorDeAgencias++;
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        g.VerFuncionariosCadastrados(gerentes, funcionarios, contadorDeGerente, contadorDeFuncionario);
                        break;

                    case 5:
                        Console.Clear();
                        g.VerClientesCadastrados(clientes, contadorDeClientes);
                        break;

                    case 6:
                        Console.Clear();
                        g.VerAgenciasCadastradas(agencias, contadorDeAgencias);
                        break;

                    case 7:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Olá usúario, Infome a opção desejada: \n");
                            Console.WriteLine("1 - Solicitar abertura de conta");
                            Console.WriteLine("2 - Desbloquear cartão");
                            Console.WriteLine("3 - Solicitar empréstimo");
                            Console.WriteLine("4 - Acessar sua conta");
                            Console.WriteLine();
                            Console.WriteLine("5 - Voltar ao menu anterior");
                            Console.Write("\nOpção: ");
                            try
                            {
                                opcao = int.Parse(Console.ReadLine());
                                condicaoDeParada = false;
                            }
                            catch (System.FormatException)
                            {

                                Console.WriteLine("Opção inválida!");
                                Console.WriteLine("Escolha uma das opções informadas!");
                                Console.WriteLine("Pressione uma tecla para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                condicaoDeParada = true;
                            }
                            if (opcao < 0 || opcao > 9)
                            {
                                Console.WriteLine("Opção inválida!");
                                Console.WriteLine("Escolha uma das opções informadas!");
                                Console.WriteLine("Pressione uma tecla para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                condicaoDeParada = true;
                            }

                            switch (opcao)
                            {
                                case 1:
                                    Console.Clear();
                                    clientes[contadorDeClientes] = c.SolicitarAbertura(clientes, contasCorrentes, contasPoupancas, cartaoCCorrente, agencias, contadorDeClientes, contadorDeAgencias);
                                    contadorDeClientes++;
                                    break;

                                case 2:
                                    c.DesbloquearCartao(clientes, contadorDeClientes);
                                    break;

                                case 3:
                                    Console.Clear();
                                    c.SolicitarEmprestimo(clientes, contadorDeClientes);
                                    break;

                                case 4:
                                    c.AcessarConta(clientes, contadorDeClientes);
                                    break;
                                
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }

                        } while (opcao != 5);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
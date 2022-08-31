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
            cliente[0] = new Cliente("João", "123.157.259-55", new DateTime(1994,12,03), "(15) 99665-1799", new Endereco("R: Fabio papini", "Araraquara", 915), 1000, new ContaCorrente(123, agencia[0]), new ContaPoupanca(123, agencia[0], 0), new Cartao(123, 0, 30));
            cliente[1] = new Cliente("Pedro", "145.177.229-33", new DateTime(1970, 01, 05), "(15) 99662-1855", new Endereco("R: Mario Pestana", "Araraquara", 917), 2000, new ContaCorrente(321, agencia[1]), new ContaPoupanca(321, agencia[1], 0), new Cartao(321, 0, 30));
            cliente[2] = new Cliente("Mário", "773.152.524-00", new DateTime(1986, 07, 13), "(15) 99725-6614", new Endereco("R: Alamedas", "Araraquara", 325), 5000, new ContaCorrente(456, agencia[2]), new ContaPoupanca(456, agencia[2], 0), new Cartao(456, 0, 30));

            return cliente;
        }

        static void Main(string[] args)
        {
            int opc = 0, contFuncionario = 3, contGerente = 3, contCliente = 3, contAgencia = 3;
            bool validacao = false;
            char resposta;

            Gerente g = new Gerente();
            Cliente c = new Cliente();
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
                        Console.Write("Novo funcionário é um gerente? (s/n) ");
                        resposta = char.Parse(Console.ReadLine().ToLower());

                        if (resposta == 'n')
                        {
                            funcionarios[contFuncionario] = g.CadastrarFuncionario(funcionarios, gerentes, agencias, contFuncionario, contGerente, contAgencia);
                            contFuncionario++;
                            Console.Clear();
                        }
                        else
                        {
                            gerentes[contGerente] = g.CadastrarGerente(gerentes, funcionarios, agencias, contGerente, contFuncionario, contAgencia);
                            contGerente++;
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        clientes[contCliente] = g.CadastrarCliente(clientes, contasCorrentes, contasPoupancas, cartaoCCorrente, agencias, contCliente, contAgencia);
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
                        Console.Clear();
                        g.VerFuncionariosCadastrados(gerentes, funcionarios, contGerente, contFuncionario);
                        break;

                    case 5:
                        Console.Clear();
                        g.VerClientesCadastrados(clientes, contCliente);
                        break;

                    case 6:
                        Console.Clear();
                        g.VerAgenciasCadastradas(agencias, contAgencia);
                        break;

                    case 7:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Olá usúario, Infome a opção desejada: \n");                            
                            Console.WriteLine("1 - Solicitar abertura de conta");
                            Console.WriteLine("2 - Desbloquear cartão");
                            Console.WriteLine("3 - Acessar sua conta");
                            Console.WriteLine("4 - Ir para o página de usúario menu >");                            
                            Console.WriteLine();
                            Console.WriteLine("0 - Sair");
                            Console.Write("\nOpção: ");
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
                                    clientes[contCliente] = c.SolicitarAbertura(clientes, contasCorrentes, contasPoupancas, cartaoCCorrente, agencias, contCliente, contAgencia);
                                    contCliente++;
                                    break;

                                case 2:
                                    clientes[contCliente].Cartao = c.DesbloquearCartao(clientes, contCliente);
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

                    

                    

                    case 8:
                        break;

                }

            } while (opc != 0);







        }
    }
}

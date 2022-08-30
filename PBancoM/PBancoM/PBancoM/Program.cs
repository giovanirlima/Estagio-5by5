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
            Gerente g = new Gerente();
            Funcionario[] funcionarios = new Funcionario[contFuncionario];
            Cliente[] clientes = new Cliente[contCliente];
            Agencia[] agencias = new Agencia[contAgencia];
            ContaCorrente[] contas = new ContaCorrente[contCliente];

            
            do
            {
                Console.WriteLine("Olá usúario, Infome a opção desejada: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Cadastrar Agência");
                Console.WriteLine("4 - Ir para o próximo menu >");
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
                        funcionarios[contFuncionario] = g.CadastrarFuncionario(contFuncionario);
                        contFuncionario++;
                        break;

                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
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

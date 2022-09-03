using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PBancoM.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public Agencia Agencia { get; set; }

        public Funcionario()
        {
        }
        public Funcionario(string nome, int matricula, Agencia agencia)
        {
            Nome = nome;
            Matricula = matricula;
            Agencia = agencia;
        }
        public double VerificarTipoDeConta(double renda)
        {
            double chequeEspecial = 0;

            Console.Clear();

            if (renda <= 1000)
            {
                Console.WriteLine("Sua conta será encaminhada para aprovação!\nCaso o Gerente do seu banco aprove sua conta, ela será modelo universitário(a)");
                chequeEspecial = 1000;
                Console.WriteLine($"Com cheque especial liberado no valor de {chequeEspecial.ToString("F2")}");
                return chequeEspecial;
            }
            else
            {
                if (renda > 1000 && renda <= 2500)
                {
                    Console.WriteLine("Sua conta será encaminhada para aprovação!\nCaso o Gerente do seu banco aprove sua conta, ela será modelo normal class");
                    chequeEspecial = 2500;
                    Console.WriteLine($"Com cheque especial liberado no valor de R$ {chequeEspecial.ToString("F2")}");
                    return chequeEspecial;
                }
                else
                {
                    Console.WriteLine("Sua conta será encaminhada para aprovação!\nCaso o Gerente do seu banco aprove sua conta, ela será modelo VIP");
                    Console.WriteLine("Sua conta após aprovação será modelo VIP");
                    chequeEspecial = 5000;
                    Console.WriteLine($"Com cheque especial liberado no valor de {chequeEspecial.ToString("F2")}");
                    return chequeEspecial;
                }
            }
        }
        public Cliente CadastrarCliente(Cliente[] cliente, ContaCorrente[] contaCorrente, ContaPoupanca[] contaPoupanca, Cartao[] cartaoCCorrente, Agencia[] agencia, int contCliente, int contAgencia)
        {
            Gerente gerente = new Gerente();
            int id;
            double saldo = 0;
            double chequeEspecial = 0;
            bool validacao;
            //Cliente[] cliente = new Cliente[contador];

            Console.Clear();

            Console.WriteLine("Vamos iniciar seu cadastro:\n");

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Informe sua data de nascimento: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe seu Telefone: ");
            string telefone = Console.ReadLine();

            Endereco endereco = new Endereco();

            endereco.CadastrarEndereco();

            Console.Write("Informe sua renda mensal: ");
            double renda = double.Parse(Console.ReadLine());

            VerificarTipoDeConta(renda);

            Console.ReadKey();

            bool resposta = gerente.AprovarConta(nome, cpf, nascimento, telefone, renda);

            if (resposta)
            {
                Console.WriteLine("\nRetornando aprovação para o funcionário . . .");

                Console.WriteLine("Pressione enter para continuar!");
                Console.ReadKey();

                Console.Clear();

                do
                {
                    Console.Write("Informe o id da nova conta do cliente: ");
                    id = int.Parse(Console.ReadLine());
                    validacao = false;

                    for (int i = 0; i < contCliente; i++)
                    {
                        if (cliente[i].ContaCorrente.Id == id)
                        {
                            Console.WriteLine("\nId informado já está sendo utilizado por outro cliente!");
                            Console.WriteLine("Escolha outro Id");

                            validacao = true;

                            Console.ReadKey();
                        }
                    }

                    Console.Clear();

                } while (validacao);

                contaCorrente[contCliente] = new ContaCorrente(id, agencia[contAgencia], saldo, chequeEspecial);
                contaPoupanca[contCliente] = new ContaPoupanca(id, agencia[contAgencia], saldo);
                cartaoCCorrente[contCliente] = new Cartao(0, 30);

                Console.WriteLine("Conta criada com sucesso!");

                Console.WriteLine("Pressione enter para continuar!");
                Console.ReadKey();

                return cliente[contCliente] = new Cliente(nome, cpf, nascimento, telefone, endereco, renda, contaCorrente[contCliente], contaPoupanca[contCliente], cartaoCCorrente[contCliente]);
            }
            else
            {
                return null;
            }
        }
        public override string ToString()
        {
            return $"\nNome: {Nome}\nMatricula: {Matricula}{Agencia.ToString()}";
        }

    }
}

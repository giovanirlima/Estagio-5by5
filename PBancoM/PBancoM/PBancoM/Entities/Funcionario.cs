using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Sua conta após aprovação será modelo universitário(a)");
                chequeEspecial = 1000;
                Console.WriteLine($"Com cheque especial liberado no valor de {chequeEspecial.ToString("F2")}");
                return chequeEspecial;
            }
            else
            {
                if (renda > 1000 && renda <= 2500)
                {
                    Console.WriteLine("Sua conta após aprovação será modelo normal class");
                    chequeEspecial = 2500;
                    Console.WriteLine($"Com cheque especial liberado no valor de {chequeEspecial.ToString("F2")}");
                    return chequeEspecial;
                }
                else
                {
                    Console.WriteLine("Sua conta após aprovação será modelo VIP");
                    chequeEspecial = 5000;
                    Console.WriteLine($"Com cheque especial liberado no valor de {chequeEspecial.ToString("F2")}");
                    return chequeEspecial;
                }
            }
        }
        public Cliente CadastrarCliente(Cliente[] cliente, ContaCorrente[] contaCorrente,ContaPoupanca[] contaPoupanca, Agencia[] agencia, int contCliente, int contAgencia)
        {
            Gerente gerente = new Gerente();
            
            double saldo = 0;
            double chequeEspecial = 0;
            //Cliente[] cliente = new Cliente[contador];

            Console.WriteLine("Olá senhor cliente, vamos iniciar seu cadastro");

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
                Console.Write("Informe o id da conta: ");
                int id = int.Parse(Console.ReadLine());

                contaCorrente[contCliente] = new ContaCorrente(id, agencia[contAgencia], saldo, chequeEspecial);
                contaPoupanca[contCliente] = new ContaPoupanca(id, agencia[contAgencia], saldo);

                return cliente[contCliente] = new Cliente(nome, cpf, nascimento, telefone, endereco, renda, contaCorrente[contCliente], contaPoupanca[contCliente]);
            }
            else
            {
                return null;
            }
        }
    }
}

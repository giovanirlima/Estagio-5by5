using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        Endereco Endereco { get; set; }
        public double Renda { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public Cartao Cartao { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nome, string cpf, DateTime nascimento, string telefone, Endereco endereco, double renda, ContaCorrente cCorrente, ContaPoupanca cPoupanca, Cartao cartaoCCorrente)
        {
            Nome = nome;
            Cpf = cpf;
            Nascimento = nascimento;
            Telefone = telefone;
            Endereco = endereco;
            Renda = renda;
            ContaCorrente = cCorrente;
            ContaPoupanca = cPoupanca;
            Cartao = cartaoCCorrente;
        }

        public Cliente SolicitarAbertura(Cliente[] cliente, ContaCorrente[] contaCorrente, ContaPoupanca[] contaPoupanca, Cartao[] cartaoCCorrente, Agencia[] agencia, int contCliente, int contAgencia)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Olá Sr.(a) cliente!");
            Console.Write("\nDeseja solicitar abertura de uma conta? (s/n): ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                return cliente[contCliente] = funcionario.CadastrarCliente(cliente, contaCorrente, contaPoupanca, cartaoCCorrente, agencia, contCliente, contAgencia);
            }
            else
            {
                Console.WriteLine("Até logo!");
                return null;
            }
        }
        public void SolicitarEmprestimo(Cliente[] cliente, int contCliente)
        {
            int id;
            bool validacao;
            Gerente gerente = new Gerente();

            do
            {
                Console.Write("Informe o ID da conta: ");
                id = int.Parse(Console.ReadLine());
                validacao = false;

                for (int i = 0; i < contCliente; i++)
                {
                    if (cliente[i].ContaCorrente.Id == id)
                    {
                        Console.Clear();
                        Console.WriteLine($"Olá sr.(a) {cliente[i].Nome}");
                        Console.WriteLine("Informe o valor que deseja solicitar: ");
                        double emprestimo = double.Parse(Console.ReadLine());

                        Console.WriteLine("Solicitação sendo encaminhada para aprovação!");
                        Console.WriteLine("Aguarde . . .");
                        Thread.Sleep(2000);

                        gerente.AprovarEmprestimo(cliente, i, emprestimo);
                        validacao = false;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Id informado é inválido!\n");
                        validacao = true;
                    }
                }

            } while (validacao);





        }
        public void DesbloquearCartao(Cliente[] cliente, int contCliente)
        {
            int id;
            Console.Clear();
            Console.WriteLine("Olá, Sr.(a) cliente\n");
            Console.WriteLine("Deseja desbloquear seu cartão? (s/n)");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                Console.Write("\nInforme o id da Conta Corrente do cliente: ");
                id = int.Parse(Console.ReadLine());

                for (int i = 0; i < contCliente; i++)
                {
                    if (cliente[i].Cartao.Id == id)
                    {
                        if (cliente[i].Cartao.Limite == 0)
                        {
                            Console.WriteLine("Cartão desbloquado com sucesso!");
                            cliente[i].Cartao.Limite += 1000;

                            Console.WriteLine($"Sr.(a) {cliente[i].Nome} seu cartão foi desbloqueado com limite de R$ {cliente[i].Cartao.Limite.ToString("F2")}");

                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("cliente já desbloqueou seu cartão!");
                            Console.WriteLine($"Saldo do cartão: {cliente[i].Cartao.Limite.ToString("F2")}");

                            Console.ReadKey();
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("Processo cancelado pelo usuário!");
            }

        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf}\nData de Nascimento: {Nascimento.ToShortDateString()}\nTelefone: {Telefone}" +
                   $"\nRenda mensal: R$ {Renda.ToString("F2")}\nConta id: {ContaCorrente.Id}\n";
        }
    }
}

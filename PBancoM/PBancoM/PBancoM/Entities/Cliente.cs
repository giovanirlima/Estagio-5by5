using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Cliente()
        {
        }
        public Cliente(string nome, string cpf, DateTime nascimento, string telefone, Endereco endereco, double renda, ContaCorrente cCorrente, ContaPoupanca cPoupanca)
        {
            Nome = nome;
            Cpf = cpf;
            Nascimento = nascimento;
            Telefone = telefone;
            Endereco = endereco;
            Renda = renda;
            ContaCorrente = cCorrente;
            ContaPoupanca = cPoupanca;
        }

        public void SolicitarAbertura(Cliente[] cliente, ContaCorrente[] conta, Agencia[] agencia, int contCliente, int contAgencia)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Olá Sr.(a) cliente!");
            Console.Write("Deseja solicitar abertura de uma conta? (s/n)");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                funcionario.CadastrarCliente(cliente, conta, agencia, contCliente, contAgencia);
            }
            else
            {
                Console.WriteLine("Até logo!");
            }
        }
        public void SolicitarEmprestimo(Cliente[] cliente, int contCliente)
        {
            Gerente gerente = new Gerente();

            Console.WriteLine($"Olá sr.(a) {cliente[contCliente].Nome}");
            Console.WriteLine("Informe o valor que deseja solicitar: ");
            double emprestimo = double.Parse(Console.ReadLine());

            gerente.AprovarEmprestimo(cliente, contCliente, emprestimo);
        }
        void DesbloquearCartao()
        {

        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf}\nData de Nascimento: {Nascimento}\nTelefone: {Telefone}" +
                    $"Renda mensal: {Renda}";
        }
    }
}

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

        void SolicitarAbertura()
        {

        }
        void SolicitarEmprestimo()
        {

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

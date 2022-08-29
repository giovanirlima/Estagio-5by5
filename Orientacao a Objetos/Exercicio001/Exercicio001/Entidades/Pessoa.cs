using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio1.Entidades
{
    internal class Pessoa
    {
        internal string Nome { get; set; }
        internal DateTime Nascimento { get; set; }
        internal long CPF { get; set; }
        internal long Telefone { get; set; }

        public Pessoa()
        {
        }

        internal Pessoa(string nome, DateTime nascimento, long cpf, long telefone)
        {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            Telefone = telefone;
        }


        public override string ToString()
        {
            return $"Nome: {Nome}\nData de Nascimento: {Nascimento.ToShortDateString()}\nCPF: {CPF}\nTelefone: {Telefone}";
        }
    }
}


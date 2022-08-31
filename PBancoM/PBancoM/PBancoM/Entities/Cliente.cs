﻿using System;
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
        }

        public Cliente SolicitarAbertura(Cliente[] cliente, ContaCorrente[] contaCorrente, ContaPoupanca[] contaPoupanca, Cartao[] cartaoCCorrente, Agencia[] agencia, int contCliente, int contAgencia)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Olá Sr.(a) cliente!");
            Console.Write("Deseja solicitar abertura de uma conta? (s/n): ");
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
            Gerente gerente = new Gerente();

            Console.WriteLine($"Olá sr.(a) {cliente[contCliente].Nome}");
            Console.WriteLine("Informe o valor que deseja solicitar: ");
            double emprestimo = double.Parse(Console.ReadLine());

            gerente.AprovarEmprestimo(cliente, contCliente, emprestimo);
        }
        public Cartao DesbloquearCartao(Cliente[] cliente, int contCliente)
        {
            Console.Clear();
            Console.WriteLine("Olá, Sr.(a) cliente\n");
            Console.WriteLine("Deseja desbloquear seu cartão? (s/n)");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                if (cliente[contCliente].Cartao.Saldo == 0)
                {
                    return new Cartao(1000, 30);
                }

                else
                {
                    Console.WriteLine("Cliente já possue um cartão criado!");
                    Console.WriteLine(cliente[contCliente].Cartao);
                    return cliente[contCliente].Cartao;
                }
            }
            else
            {
                Console.WriteLine("Processo cancelado pelo usuário!");
                return null;
            }

        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf}\nData de Nascimento: {Nascimento}\nTelefone: {Telefone}" +
                    $"Renda mensal: {Renda}";
        }
    }
}

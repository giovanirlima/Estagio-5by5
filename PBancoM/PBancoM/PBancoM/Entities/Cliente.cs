﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
            bool validacao, verificacaoEmprestimo;
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
                        Console.Write("\nInforme o valor que deseja solicitar: R$ ");
                        double emprestimo = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nSolicitação sendo encaminhada para aprovação!");
                        Console.WriteLine("Pressione enter para continuar!");
                        Console.ReadKey();

                        verificacaoEmprestimo = gerente.AprovarEmprestimo(cliente, i, emprestimo);

                        if (!verificacaoEmprestimo)
                        {
                            Console.WriteLine("\nPedido de empréstimo reprovado!");
                            Console.WriteLine("Tente novamente mais tarde!");
                            Console.WriteLine("\nPressione enter para continuar!");
                            Console.ReadKey();
                            validacao = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pedido de empréstimo aprovado\n");
                            Console.WriteLine($"Valor de R$ {emprestimo.ToString("F2")} será depositado em sua conta!");
                            Console.WriteLine("Até mais!");
                            cliente[i].ContaCorrente.Saldo += emprestimo;

                            Console.WriteLine("\nPressione enter para continuar!");
                            Console.ReadKey();
                            validacao = false;
                        }
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
        public void AcessarConta(Cliente[] cliente, int contCliente, Pagamento[] registro, int contadorDePagamentos)
        {
            int id, opcao = 0, posicao = 0;
            bool validacao = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Olá Sr.(a) Cliente!");
                Console.Write("\nInforme o id da sua conta: ");
                id = int.Parse(Console.ReadLine());

                for (int i = 0; i < contCliente; i++)
                {
                    if (cliente[i].ContaCorrente.Id == id)
                    {
                        validacao = true;
                        posicao = i;
                    }
                }
                if (!validacao)
                {
                    Console.WriteLine("\nId inválido!");
                    Console.WriteLine("Pressione enter para continuar!");
                    Console.ReadKey();
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"Olá Sr.(a) {cliente[posicao].Nome}\n");
                        Console.WriteLine("Informe qual Opção deseja\n");

                        Console.WriteLine("1 - Ver saldo da conta");
                        Console.WriteLine("2 - Sacar dinheiro");
                        Console.WriteLine("3 - Solicitar Emprestimo");
                        Console.WriteLine("4 - Transferir dinheiro");
                        Console.WriteLine("5 - Extrato de movimentação");
                        Console.WriteLine("6 - Pagar conta");
                        Console.WriteLine("\n0 - Sair");
                        Console.Write("\nOpção: ");
                        try
                        {
                            opcao = int.Parse(Console.ReadLine());
                        }
                        catch (System.FormatException)
                        {

                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine("Escolha uma das opções informadas!");
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        if (opcao < 0 || opcao > 6)
                        {
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine("Escolha uma das opções informadas!");
                            Console.WriteLine("Pressione uma tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        switch (opcao)
                        {
                            case 1:
                                cliente[posicao].ContaCorrente.SaldoBancario();
                                break;

                            case 2:
                                cliente[posicao].ContaCorrente.SaqueBancario(registro);
                                break;

                            case 3:

                                break;

                            case 4:
                                cliente[posicao].ContaCorrente.TransferirDinheiro(cliente, contCliente, registro, contadorDePagamentos, posicao);
                                break;
                                
                            case 5:

                                break;

                            case 6:

                                break;

                            case 0:

                                break;

                            default:
                                break;
                        }



                    } while (opcao != 0);

                }

            } while (true);



        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf}\nData de Nascimento: {Nascimento.ToShortDateString()}\nTelefone: {Telefone}" +
                   $"\nRenda mensal: R$ {Renda.ToString("F2")}\nConta id: {ContaCorrente.Id}\n";
        }
    }
}

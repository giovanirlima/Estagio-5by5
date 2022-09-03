using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PBancoM.Entities
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public Agencia Agencia { get; set; }
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }
        Pagamento Registro { get; set; }

        public ContaCorrente()
        {
        }
        public ContaCorrente(int id)
        {
            Id = Id;
        }
        public ContaCorrente(int id, Agencia agencia)
        {
            Id = id;
            Agencia = agencia;
        }
        public ContaCorrente(int id, Agencia agencia, double saldo, double chequeEspecial)
        {
            Id = id;
            Agencia = agencia;
            Saldo = saldo;
            ChequeEspecial = chequeEspecial;
        }
        
        public void SaldoBancario()
        {
            Console.WriteLine($"Saldo em conta é {Saldo}");
        }
        public void SaqueBancario(Pagamento[] registro)
        {
            Console.Write("Informe o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            Saldo -= saque;


            Console.WriteLine("Saque efetuado com sucesso!");
        }
        public void DepositoBancario()
        {
            Console.Write("Informe o valor que deseja depositar: ");
            double deposito = double.Parse(Console.ReadLine());

            Saldo += deposito;
        }
        public void SolicitarEmprestimo(Cliente[] cliente, int contCliente)
        {
            Gerente gerente = new Gerente();
            Console.WriteLine($"Olá Sr.(a) {cliente[contCliente].Nome}");
            Console.WriteLine();
            Console.Write("Informe o valor do empréstimo: ");
            double emprestimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Pedido encaminhado ao gerente, aguarde a resposta!");
            Console.WriteLine("Precione enter para continuar!");
            Console.ReadKey();

            bool resposta = gerente.AprovarEmprestimo(cliente, contCliente, emprestimo);

            if (resposta == true)
            {
                Saldo += emprestimo;
                Console.WriteLine($"Novo saldo da conta: {Saldo.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Tente novamente mais tarde!");
            }
        }
        public void TransferirDinheiro(Cliente[] cliente, int contCliente, Pagamento registro, int contadorDePagamentos)
        {
            Console.Write("Informe o Id da conta que deseja realizar a transfêrencia: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < contConta; i++)
            {
                if (cCorrente[i].Id == id)
                {
                    Console.WriteLine("Informe o valor que deseja transferir: ");
                    double transferencia = double.Parse(Console.ReadLine());

                    cCorrente[contConta].Saldo -= transferencia;
                    cCorrente[i].Saldo += transferencia;

                    Console.WriteLine($"Transferência enviada para {cliente[i].Nome}");
                }
                else
                {
                    Console.WriteLine("ID informado não é válido!");
                }
            }
        }
        void ImprimirExtrato()
        {
            
        }
        public void PagamentoDeContas()
        {
            Console.Write("Informe o valor da conta que deseja pagar: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor de R$ {preco.ToString("F2")} será debitado de sua conta corrente");

            Saldo -= preco;

            Console.WriteLine("Pagamento efetuado com sucesso!");
        }
        void RegistrarTransacao(ContaCorrente[] conta, int contCliente)
        {
            
        }
        public void AdicionarChequeEspecial()
        {
            if (Saldo <= 0)
            {
                Console.WriteLine("Será adicionado o cheque especial ao seu saldo");
                Console.WriteLine("Será cobrado uma taxa de R$ 10, pela utilização do mesmo.");
                double aux = 0;
                aux -= ChequeEspecial;
                Saldo += ChequeEspecial;
                ChequeEspecial = 0;
                ChequeEspecial = aux;
            }
        }
        public void VerificarSaldoDevedor()
        {
            if (ChequeEspecial <= 0)
            {
                ChequeEspecial = ChequeEspecial + (Saldo - 10);
            }
        }

        
    }
}

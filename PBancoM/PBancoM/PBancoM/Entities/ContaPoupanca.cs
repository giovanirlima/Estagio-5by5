using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class ContaPoupanca : ContaCorrente
    {
        public double SaldoCP { get; set; }

        public ContaPoupanca(int id, Agencia agencia, double saldoCP) : base(id, agencia)
        {
            SaldoCP = saldoCP;
        }
        void AdicionarRendimento()
        {
            double adicao = 0;
            Console.Write("Estamos verificando seu rendimento, aguarde!");
            DateTime rendimento = DateTime.Now;

            if (rendimento.Day == 30 || rendimento.Day == 31)
            {
                Console.WriteLine("Calculando rendimento . . .");
                adicao = Saldo * 0.1;
                Console.WriteLine($"Seu rendimento mensal é de {adicao.ToString("F2")}");
                Saldo += adicao;
                Console.WriteLine($"Seu saldo agora é de {Saldo.ToString("F2")}");
            }
        }
    }
}

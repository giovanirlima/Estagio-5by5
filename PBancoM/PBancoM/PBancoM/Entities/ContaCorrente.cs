using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public Agencia Agencia { get; set; }
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }

        void SaldoBancario() 
        { 
        }

        void SaqueBancario()
        {
        }

        void DepositoBancario()
        {
        }

        void SolicitarEmprestimo()
        {
        }

        void TransferirDinheiro()
        {
        }

        void ImprimirExtrato()
        {
        }

        void PagamentoDeContas()
        {
        }

        void RegistrarTransacao()
        {
        }

        void VerificarSaldoDevedor()
        {
        }
    }
}

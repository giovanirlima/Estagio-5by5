using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Cartao : ContaCorrente
    {
        public double Limite { get; set; }
        public int Vencimento { get; set; }

        public Cartao()
        {
        }

        public Cartao(double limite, int vencimento)
        {
            Limite = limite;
            Vencimento = vencimento;
        }

        public Cartao(int id, double limite, int vencimento) : base(id)
        {
            Limite = limite;
            Vencimento = vencimento;
        }

        public Cartao(int id, Agencia agencia) : base(id, agencia)
        {
        }

        void Extrato()
        {
        }

        void VerFatura()
        {
        }

        void GerarFatura()
        {
        }
    }
}

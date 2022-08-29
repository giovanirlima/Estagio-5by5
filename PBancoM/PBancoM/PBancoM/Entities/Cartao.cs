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

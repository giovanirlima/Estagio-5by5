using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Cliente : Pessoa
    {
        public double FaixaSalarial { get; set; }
        public int Conta { get; set; }

        void SolicitarAbertura()
        {

        }

        void SolicitarEmprestimo()
        {

        }

        void DesbloquearCartao()
        {

        }
    }
}

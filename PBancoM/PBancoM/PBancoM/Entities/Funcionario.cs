using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Funcionario : Pessoa
    {
        public int Matricula { get; set; }
        public bool Tipo { get; set; }
        public Agencia Agencia { get; set; }

        void VerificarTipoDeConta()
        {

        }

        void CadastrarCliente()
        {

        }
    }
}

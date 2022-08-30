using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Agencia
    {
        public int Id { get; set; }
        public Endereco Endereco { get; set; }

        Agencia()
        {
        }

        public Agencia(int id, Endereco endereco)
        {
            Id = id;
            Endereco = endereco;
        }
    }
}

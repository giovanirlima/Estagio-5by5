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
        public Endereco endereco { get; set; }

        Agencia()
        {
        }

        public Agencia(int id, Endereco endereco)
        {
            Id = id;
            this.endereco = endereco;
        }
    }
}

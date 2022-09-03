using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PBancoM.Entities
{
    public class Agencia
    {
        public int Id { get; set; }
        public Endereco Endereco { get; set; }
        public Agencia()
        {
        }
        public Agencia(int id, Endereco endereco)
        {
            Id = id;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"\nAgência: \nId: {Id}\nEndereço: {Endereco.Rua} {Endereco.Numero}, {Endereco.Cidade}";
        }
    }
}

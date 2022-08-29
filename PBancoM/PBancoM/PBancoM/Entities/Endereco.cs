using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }

        Endereco()
        {
        }

        public Endereco(string rua, string cidade, int numero)
        {
            Rua = rua;
            Cidade = cidade;
            Numero = numero;
        }
    }
}

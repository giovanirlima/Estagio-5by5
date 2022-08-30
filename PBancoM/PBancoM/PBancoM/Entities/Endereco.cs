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

        public Endereco()
        {
        }

        public Endereco(string rua, string cidade, int numero)
        {
            Rua = rua;
            Cidade = cidade;
            Numero = numero;
        }

        public Endereco CadastrarEndereco()
        {
            Console.Write("Informe o numero da sua rua: ");
            string rua = Console.ReadLine();

            Console.Write("Informe o número do local: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Informe a cidade: ");
            string cidade = Console.ReadLine(); 

            return new Endereco(rua, cidade, n);
        }
    }
}

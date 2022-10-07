using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Companhia
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Companhia()
        {
        }

        public Companhia(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nNome: {Nome}\n";
        }
    }
}

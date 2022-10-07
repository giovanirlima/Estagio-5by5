using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Aeronave
    {
        public int ID { get; set; }
        public string Inscricao { get; set; }
        public int Capacidade { get; set; }

        public Aeronave()
        {
        }
        public Aeronave(string inscricao, int capacidade)
        {            
            Inscricao = inscricao;
            Capacidade = capacidade;
        }
        public Aeronave(int iD, string inscricao, int capacidade)
        {
            ID = iD;
            Inscricao = inscricao;
            Capacidade = capacidade;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nInscricao: {Inscricao}\nCapacidade: {Capacidade}\n";
        }
    }
}

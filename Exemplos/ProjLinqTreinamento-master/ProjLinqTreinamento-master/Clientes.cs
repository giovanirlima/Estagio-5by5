using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinqTreinamento
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public decimal Divida { get; set; }

        public List<Clientes> Cadastros()
        {
            List<Clientes> lst = new List<Clientes>();
            lst.Add (new Clientes() { Id=0, Nome="Felipe", EstadoCivil="Casado", Divida = 1000 });
            lst.Add(new Clientes() { Id = 1, Nome = "Andre", EstadoCivil = "Casado", Divida = 0 });
            lst.Add(new Clientes() { Id = 2, Nome = "Fabio", EstadoCivil = "Divorciado", Divida = 3500 });
            lst.Add(new Clientes() { Id = 3, Nome = "Bruno", EstadoCivil = "Solteiro", Divida = 7630 });
            lst.Add(new Clientes() { Id = 4, Nome = "Marina", EstadoCivil = "Solteiro", Divida = 0 });
            
            return lst;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: " + this.Nome + "\nDivida: " + this.Divida + "\n";
        }
    }
}

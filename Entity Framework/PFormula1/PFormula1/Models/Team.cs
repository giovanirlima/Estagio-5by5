using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFormula1.Models
{
    internal class Team
    {
        [Key()]
        public int id { get; set; }        
        public string nome { get; set; }

        public override string ToString()
        {
            return $"ID: {id}\nNome: {nome}\n";
        }

    }
}

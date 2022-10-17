using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFormula1.Models
{
    internal class Car
    {
        [Key()]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]        
        public int Unidade { get; set; }
        [ForeignKey("Equipe")]
        public int Id_Equipe { get; set; }
        public virtual Team Equipe { get; set; }

        public override string ToString()
        {
            return $"Modelo: {Modelo}\nAno: {Ano}\nUnidade: {Unidade}\nEquipe ID: {Id_Equipe}";
        }
    }
}

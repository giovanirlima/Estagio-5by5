using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda.Models
{
    internal class Person
    {
        [Key]
        public string Name { get; set; }
        public string Email { get; set; }
        [ForeignKey("TelephoneBook")]
        public int TelephoneBookId { get; set; }
        public TelephoneBook TelephoneBook { get; set; }
        
        public override string ToString()
        {
            return $"Nome: {Name}\nEmail: {Email}\nCelular: {TelephoneBook.Cel}\nTelefone: {TelephoneBook.Phone}\n";
        }
    }
}

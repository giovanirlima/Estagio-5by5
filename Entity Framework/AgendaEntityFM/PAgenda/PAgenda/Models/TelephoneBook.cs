using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda.Models
{
    internal class TelephoneBook
    {
        [Key()]
        public int Id { get; set; }
        public string Cel { get; set; }
        public string Phone { get; set; }        
       
    }
}

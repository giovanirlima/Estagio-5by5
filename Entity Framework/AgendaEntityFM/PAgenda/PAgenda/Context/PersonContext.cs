using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAgenda.Models;

namespace PAgenda.Context
{
    internal class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<TelephoneBook> Phones { get; set; }
    }
}

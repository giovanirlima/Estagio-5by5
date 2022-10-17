using System.Data.Entity;
using FrameWorkCF.Models;

namespace FrameWorkCF.Context
{
    internal class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

    }
}

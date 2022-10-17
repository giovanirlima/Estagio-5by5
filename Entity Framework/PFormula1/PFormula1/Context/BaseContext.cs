using PFormula1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFormula1.Context
{
    internal class BaseContext : DbContext
    {
        public BaseContext() : base("Formula10") { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
    }
}

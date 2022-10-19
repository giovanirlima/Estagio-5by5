using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExemploWebAPI.Models;

namespace ExemploWebAPI.Data
{
    public class ExemploWebAPIContext : DbContext
    {
        public ExemploWebAPIContext (DbContextOptions<ExemploWebAPIContext> options) : base(options)
        {
        }
        public DbSet<ExemploWebAPI.Models.Person> Person { get; set; }

        public DbSet<ExemploWebAPI.Models.Address> Address { get; set; }
    }
}

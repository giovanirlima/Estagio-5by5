using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ModelDB();

            Teams e = new Teams() { nome = "Ferrari1" };

            context.Teams.Add(e);
            context.SaveChanges();

            Console.WriteLine(e.ToString());


        }
    }
}

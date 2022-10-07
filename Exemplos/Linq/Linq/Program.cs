using System;
using Linq;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aeronave> listaAeronave = new();
            List<Companhia> listaCompanhia = new();

            listaAeronave.Add(new Aeronave(1, "PT-LSD", 10));
            listaAeronave.Add(new Aeronave(2, "PT-BRA", 20));

            listaCompanhia.Add(new Companhia(1, "Airlanes company"));
            listaCompanhia.Add(new Companhia(2, "Company Aerea"));

            listaAeronave.Take(3);

            foreach (var item in listaAeronave)
            {
                Console.WriteLine(item);
            }

            listaAeronave.Skip(3);

            foreach (var item in listaAeronave)
            {
                Console.WriteLine(item);
            }


            #region Foreach normal!
            /*
            Console.WriteLine("Aeronaves: \n");
            foreach (var aeronave in listaAeronave)
            {
                Console.WriteLine(aeronave.ToString());
            }

            Console.WriteLine("Companhias: ");
            foreach (var companhia in listaCompanhia)
            {
                Console.WriteLine(companhia.ToString());
            }
            */
            #endregion

            #region Foreach Linq!
            /*
            listaAeronave.ForEach(item => Console.WriteLine(item.ToString()));
            listaCompanhia.ForEach(item => Console.WriteLine(item.ToString()));
            */
            #endregion

            #region Select e Where
            /*
            var item = from aeronave in listaAeronave select new 
                       { aeronave.Inscricao, aeronave.Capacidade };

            foreach (var i in item)
            {
                Console.WriteLine(i.ToString());
            }

            var newItem = from aeronave in listaAeronave where aeronave.Capacidade > 10 select new
                       { aeronave.Inscricao, aeronave.Capacidade };

            foreach (var i in item)
            {
                Console.WriteLine(i.ToString());
            }
            */
            #endregion
        }
    }
}

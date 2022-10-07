using System;
using PDapper.Model;
using PDapper.Services;

namespace PDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente()
            {
                Nome = "Teste",
                Telefone = "16 992804976"
            };

            new ClienteServices().Add(cliente);

            new ClienteServices().GetAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Ufa!");

            Console.Read();
        }
    }
}

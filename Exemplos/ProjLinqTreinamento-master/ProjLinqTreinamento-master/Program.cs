using System;
using System.Linq;

namespace ProjLinqTreinamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();

            /*foreach (var c in cliente.Cadastros())
            {
                Console.WriteLine(c);
            }*/
            Console.WriteLine("=-=-=-= Usando Linq =-=-=-=");
            Console.WriteLine("Lista de Solteiros:");
            var solteiros = 
                from c in cliente.Cadastros()
                where c.EstadoCivil == "Solteiro"
                where c.Divida > 0
                select c;
            
            foreach (var s in solteiros)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Lista de Casados:");
            var casados =
                from c in cliente.Cadastros()
                where c.EstadoCivil == "Casado"
                where c.Divida > 0
                select c;

            foreach (var c in casados)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("=-=-=-= Usando Lamba =-=-=-=");
            Console.WriteLine("Casados:");
            cliente.Cadastros().Where(c => c.EstadoCivil == "Casado").Where(c => c.Divida > 0).ToList().ForEach(c => Console.WriteLine(c));

            Console.WriteLine("Solteiros:");
            cliente.Cadastros().Where(s => s.EstadoCivil == "Solteiro").Where(s => s.Divida > 0).ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}
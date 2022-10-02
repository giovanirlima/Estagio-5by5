using System;
using Controllers;
using Models;

namespace PAgendaMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agenda Telefonica");
            Contato c = new()
            {
                Nome = "Giovani Rocha Lima",
                Telefone = "16992804976"
            };


            new ContatoController().InserirContato(c);
            

        }
    }
}

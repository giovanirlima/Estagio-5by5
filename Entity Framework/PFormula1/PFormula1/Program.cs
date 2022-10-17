using PFormula1.Context;
using PFormula1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFormula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseContext context = new BaseContext();

           /* #region INSERIR EQUIPES
            Team equipe = new Team()
            {
                nome = "Ferrari"
            };

            Team equipe1 = new Team()
            {
                nome = "RedBull"
            };

            context.Teams.Add(equipe);
            context.Teams.Add(equipe1);
            context.SaveChanges();
            #endregion
            #region LISTAR EQUIPES
            var equipes = context.Teams.ToList();
            equipes.ForEach(e => Console.WriteLine(e.ToString()));
            Console.Write("Informe o nome da equipe que deseja localizar: ");
            string nome = Console.ReadLine();

            Team find = context.Teams.FirstOrDefault(f => f.nome == nome);
            if (find != null)
            {
                Console.WriteLine(find.ToString());
            }
            else
            {
                Console.WriteLine("\nEquipe não localizada!");
            }
            #endregion
            #region EDITAR EQUIPES
            Console.WriteLine("Informe o novo nome da Equipe: ");
            find.nome = Console.ReadLine();
            context.Entry(find).State = EntityState.Modified;
            context.SaveChanges();
            equipes.ForEach(e => Console.WriteLine(e.ToString()));
            #endregion
            #region EXCLUIR EQUIPES
            Console.WriteLine("Deseja excluir a equipe: s/n");
            string resp = Console.ReadLine().ToLower();

            if (resp == "s" )
            {
                context.Entry(find).State = EntityState.Deleted;
                context.Teams.Remove(find);
                context.SaveChanges();
            }
            equipes = context.Teams.ToList();
            equipes.ForEach(e => Console.WriteLine(e.ToString()));
            #endregion/*
            */
            #region INSERIR PILOTO
            Pilot pilot = new Pilot()
            {
                nome = "Alonso"
            };

            Pilot pilot1 = new Pilot()
            {
                nome = "Maverik"
            };

            context.Pilots.Add(pilot);
            context.Pilots.Add(pilot1);
            context.SaveChanges();
            #endregion
            #region LISTAR PILOTOS
            var equipes = context.Pilots.ToList();
            equipes.ForEach(e => Console.WriteLine(e.ToString()));
            Console.Write("Informe o nome do piloto que deseja localizar: ");
            string nome = Console.ReadLine();

            Pilot find = context.Pilots.FirstOrDefault(f => f.nome == nome);
            if (find != null)
            {
                Console.WriteLine(find.ToString());
            }
            else
            {
                Console.WriteLine("\nPiloto não localizada!");
            }
            #endregion
            #region EDITAR EQUIPES
            Console.WriteLine("Informe o novo nome do Piloto: ");
            find.nome = Console.ReadLine();
            context.Entry(find).State = EntityState.Modified;
            context.SaveChanges();
            equipes.ForEach(e => Console.WriteLine(e.ToString()));
            #endregion
            #region EXCLUIR EQUIPES
            Console.WriteLine("Deseja excluir a equipe: s/n");
            string resp = Console.ReadLine().ToLower();

            if (resp == "s")
            {
                context.Entry(find).State = EntityState.Deleted;
                context.Pilots.Remove(find);
                context.SaveChanges();
            }
            equipes = context.Pilots.ToList();
            equipes.ForEach(e => Console.WriteLine(e.ToString()));
            #endregion


            Console.Read();

        }
    }
}

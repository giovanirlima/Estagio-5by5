using PAgenda.Context;
using PAgenda.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                #region INSERE DADOS
                context.Persons.Add(new Person()
                {
                    Name = "Felipe",
                    Email = "Juvenal@gmail.com",
                    TelephoneBook = new TelephoneBook { Cel = "16999999998", Phone = "1633333223" }
                });

                Person p = new Person();

                p.Name = "Baratao";
                p.Email = "baratox@raid.com.br";
                p.TelephoneBook = new TelephoneBook { Phone = "1533311331", Cel = "15999999959" };

                context.Persons.Add(p);
                context.SaveChanges();
                #endregion
                #region LISTA TODOS
                var persons = new PersonContext().Persons.Include(x => x.TelephoneBook).ToList();
                foreach (var item in persons)
                {
                    Console.WriteLine(item.ToString());
                }
                #endregion
                #region LISTA UNICO
                string n = Console.ReadLine();
                Person find = new PersonContext().Persons.Include(x => x.TelephoneBook).FirstOrDefault(f => f.Name == n);
                if (find != null)
                    Console.WriteLine(find.ToString());
                else
                    Console.WriteLine("Registro não encontrado");
                #endregion
                #region REMOVE                              
                context.Entry(find).State = EntityState.Deleted;
                context.Persons.Remove(find);
                context.SaveChanges();
                #endregion
                #region UPDATE
                find.Email = "Jorginho123@gmail.com";
                context.Entry(find).State = EntityState.Modified;
                context.Persons.AddOrUpdate(find);
                context.SaveChanges();
                #endregion
                #region UPDATE 2
                find.Name = "Juvenal Pedroso";
                context.Entry(find).State = EntityState.Modified;
                context.SaveChanges();

                Console.WriteLine(find.ToString());
                #endregion

                Console.ReadKey();
            }
        }
    }
}

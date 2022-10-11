using System;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Linq;
using FrameWorkCF.Context;
using FrameWorkCF.Models;

namespace FrameWorkCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                #region INSERE DADOS
                context.Persons.Add(new Person() { Name = "Felipe", Phone = "123" });

                Person p = new Person();

                p.Name = "Baratao";
                p.Mail = "baratox@raid.com.br";
                p.Phone = "321";


                context.Persons.Add(p);
                context.SaveChanges();
                #endregion
                #region LISTA TODOS
                var persons = new PersonContext().Persons.ToList();
                foreach (var item in persons)
                {
                    Console.WriteLine(item.ToString());
                }
                #endregion
                #region LISTA UNICO
                string n = Console.ReadLine();
                //Person xpto = new PersonContext().Persons.Find(args[0]);
                Person find = new PersonContext().Persons.FirstOrDefault(f => f.Name == n);
                if (find != null)
                    Console.WriteLine(find.ToString());
                else
                    Console.WriteLine("Registro não encontrado");
                #endregion
                #region REMOVE
                /* context.Entry(find).State = EntityState.Deleted;
                 context.Persons.Remove(find);
                 context.SaveChanges(); */
                #endregion
                #region UPDATE
                find.Mail = "987";
                context.Entry(find).State = EntityState.Modified;
                context.Persons.AddOrUpdate(find);
                context.SaveChanges();
                #endregion
                #region UPDATE 2
                find.Name = "Marco";
                context.Entry(find).State = EntityState.Modified;
                context.SaveChanges();

                Console.WriteLine(find.ToString());
                #endregion

                Console.ReadKey();
            }
        }
    }
}

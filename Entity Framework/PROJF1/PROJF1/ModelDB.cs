using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PROJF1
{
    public partial class ModelDB : DbContext
    {
        public ModelDB() : base("name=Formula10")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Pilots> Pilots { get; set; }
        public virtual DbSet<PilotsCars> PilotsCars { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Cars>()
                .HasMany(e => e.PilotsCars)
                .WithRequired(e => e.Cars)
                .HasForeignKey(e => e.id_carro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pilots>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pilots>()
                .HasMany(e => e.PilotsCars)
                .WithRequired(e => e.Pilots)
                .HasForeignKey(e => e.id_piloto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teams>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Teams>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => e.id_equipe)
                .WillCascadeOnDelete(false);
        }
    }
}

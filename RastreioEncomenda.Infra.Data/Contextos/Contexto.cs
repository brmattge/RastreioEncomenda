using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Infra.Data.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Contextos
{
    public class Contexto : DbContext
    {
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Pessoas> Pessoas { get; set; }

        public IDbContextTransaction Transaction { get; private set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
            if (Database.GetPendingMigrations().Count() > 0)
                Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public IDbContextTransaction InitTransacao()
        {
            if (Transaction == null) Transaction = this.Database.BeginTransaction();
            return Transaction;
        }


        private void RollBack()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void SendChanges()
        {
            Salvar();
            Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LocalidadesMap());
            modelBuilder.ApplyConfiguration(new PessoasMap());

        }
    }
}

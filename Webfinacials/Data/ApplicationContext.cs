using System;
using Microsoft.EntityFrameworkCore;
using Webfinacials.Models;

namespace Webfinacials.Data
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions  options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);

            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

            modelBuilder.Entity<Credor>().HasKey(c => c.Id);

            modelBuilder.Entity<CadContas>().HasKey(c => c.Id);
            modelBuilder.Entity<CadContas>().HasOne(t => t.Credor);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CadContas>()
                .Property(p => p.Valor)
                .HasColumnType("decimal (18,4)");

            modelBuilder.Entity<LancamentoDeContas>().HasKey(l => l.Id);
            modelBuilder.Entity<LancamentoDeContas>().HasOne(l => l.CadContas);
            modelBuilder.Entity<LancamentoDeContas>().HasOne(l => l.Cliente);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LancamentoDeContas>()
                .Property(p => p.Desconto)
                .HasColumnType("decimal (18,4)");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LancamentoDeContas>()
                .Property(p => p.Acrescimo)
                .HasColumnType("decimal (18,4)");

        }

    }
}

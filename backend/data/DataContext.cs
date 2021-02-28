using System;
using System.Collections.Generic;
using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<SalaTreinamento> SalaTreinamento { get; set; }
        public DbSet<SalaCafe> SalaCafe { get; set; }
        public DbSet<Etapa> Etapa { get; set; }
        public DbSet<HorarioCafe> HorarioCafe { get; set; }
        public DbSet<PessoaSalaTreinamento> PessoaSalaTreinamento { get; set; }

        //public DbSet<PessoaSalaCafe> PessoaSalaCafe { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
          {
               builder.Entity<Pessoa>()
                   .HasData(new List<Pessoa>(){
                   new Pessoa(1, "Darlan","Poffo"),
                   new Pessoa(2, "Vanessa","Tanaka"),
                   new Pessoa(3, "Nicolas","Poffo"),
                   new Pessoa(4, "Gabriel","Poffo"),
                   new Pessoa(5, "Gengis","khan"),
                   });

               builder.Entity<SalaTreinamento>()
                   .HasData(new List<SalaTreinamento>(){
                   new SalaTreinamento(1, "Sala 1",10),
                   new SalaTreinamento(2, "Sala 2",12),
                   new SalaTreinamento(3, "Sala 3",9),
                   new SalaTreinamento(4, "Sala 4",11),
                   });

                builder.Entity<SalaCafe>()
                   .HasData(new List<SalaCafe>(){
                   new SalaCafe(1, "Café 1"),
                   new SalaCafe(2, "Café 2"),
                   });
               
               builder.Entity<Etapa>()
               .HasData(new List<Etapa>(){
                   new Etapa(1, DateTime.Now.AddDays(30), DateTime.Now.AddDays(30).AddHours(4)),
                   new Etapa(2, DateTime.Now.AddDays(31), DateTime.Now.AddDays(31).AddHours(4)),
               });

               builder.Entity<HorarioCafe>()
               .HasData(new List<HorarioCafe>(){
                   new HorarioCafe(1, DateTime.Now.AddDays(30).AddHours(2), DateTime.Now.AddDays(30).AddMinutes(15)),
                   new HorarioCafe(2, DateTime.Now.AddDays(31).AddHours(2), DateTime.Now.AddDays(30).AddMinutes(15)),
               });

               builder.Entity<PessoaSalaTreinamento>()
               .HasData(new List<PessoaSalaTreinamento>(){
                   new PessoaSalaTreinamento(1,1,1,1,2,1),
                   new PessoaSalaTreinamento(2,1,2,1,2,1),
                   new PessoaSalaTreinamento(3,1,3,1,2,1),
                   new PessoaSalaTreinamento(4,1,4,1,2,1),
                   new PessoaSalaTreinamento(5,1,5,1,2,1),
                   new PessoaSalaTreinamento(6,2,1,2,1,2),
                   new PessoaSalaTreinamento(7,2,2,2,1,2),
                   new PessoaSalaTreinamento(8,2,3,2,1,2),
                   new PessoaSalaTreinamento(9,2,4,2,1,2),
               });
          }
    }
}
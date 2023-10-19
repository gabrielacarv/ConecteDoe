using ConecteDoe.Dados.EntityFramework.Configuration;
using ConecteDoe.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConecteDoe.Dados
{
    public class Contexto : DbContext
    {
        public DbSet<DadosInstituicao> DadosInstituicaos { get; set; }

        public Contexto() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93:1434; 
                                    Database = DB044323; 
                                    User ID = RA044323; 
                                    Password = 044323");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DadosInstituicaoConfiguration());
        }
    }
}

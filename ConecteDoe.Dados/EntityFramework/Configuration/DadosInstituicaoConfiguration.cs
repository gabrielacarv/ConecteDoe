using ConecteDoe.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConecteDoe.Dados.EntityFramework.Configuration
{
    public class DadosInstituicaoConfiguration : IEntityTypeConfiguration<DadosInstituicao>
    {
        public void Configure(EntityTypeBuilder<DadosInstituicao> builder)
        {
            builder.ToTable("DadoInstituicao");

            builder.HasKey(d => d.InstituicaoID);

            builder.Property(d => d.InstituicaoID)
                .HasColumnName("InstituicaoID")
                .HasColumnType("int");

            builder.Property(d => d.Coordenador)
                .HasColumnName("Coordenador")
                .HasColumnType("string");

            builder.Property(d => d.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("Date");

            builder.Property(d => d.QuantidadeCarentes)
                .HasColumnName("QuantidadeCarentes")
                .HasColumnType("int");

            builder.Property(d => d.Causa)
                .HasColumnName("Causa")
                .HasColumnType("string");

        }
    }
}

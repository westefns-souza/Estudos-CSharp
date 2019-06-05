using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class SistemaMap : IEntityTypeConfiguration<Sistema>
    {
        public void Configure(EntityTypeBuilder<Sistema> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .IsRequired()
                .HasColumnName("idavaliacao_sistema");

            builder.Property(s => s.Titulo)
                .IsRequired()
                .HasColumnName("titulo");

            builder.Property(s => s.NomeSistema)
                .IsRequired()
                .HasColumnName("nm_sistema");

            builder.Property(s => s.Situacao)
                .IsRequired()
                .HasColumnName("situacao");

            builder.Property(s => s.DataAvaliacaoInicio)
                .IsRequired()
                .HasColumnName("dt_avaliacao_inicio");

            builder.Property(s => s.DataAvaliacaoFim)
                .IsRequired()
                .HasColumnName("dt_avaliacao_fim");

            builder.HasMany(a => a.Avaliacoes)
                .WithOne(s => s.Sistema)
                .HasForeignKey(s => s.IdSistema);

            builder.ToTable("avaliacao_sistema");
        }
    }
}

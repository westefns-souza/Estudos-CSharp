using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .IsRequired()
                .HasColumnName("idavaliacao_sistema_usuario");

            builder.Property(a => a.IdSistema)
                .IsRequired()
                .HasColumnName("idavaliacao_sistema");

            builder.Property(a => a.IdUsuario)
                .HasColumnName("idusuario");

            builder.Property(a => a.NumeroTelefone)
                .HasColumnName("nr_telefone");

            builder.Property(a => a.Nota)
                .IsRequired()
                .HasColumnName("nota");

            builder.Property(a => a.Sugestao)
                .HasColumnName("sugestoes");

            builder.Property(a => a.Localizacao)
                .HasColumnName("localizacao");

            builder.Property(a => a.DataAvaliacao)
                .IsRequired()
                .HasColumnName("dt_avaliacao");

            builder.ToTable("avaliacao_sistema_usuario");
        }
    }
}

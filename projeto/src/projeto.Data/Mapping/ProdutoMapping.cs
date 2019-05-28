using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projeto.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projeto.Data.Mapping
{
    class ProdutoMapping : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.DataAvaliacao)
                .IsRequired()
                .HasColumnType("datetime");

        }
    }
}

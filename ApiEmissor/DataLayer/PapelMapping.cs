using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class PapelMapping : IEntityTypeConfiguration<Papel>, IMapping
    {

        public void Configure(EntityTypeBuilder<Papel> builder)
        {
            builder.ToTable("Papel");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}

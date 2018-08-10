using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class AcessoMapping : IEntityTypeConfiguration<Acesso>, IMapping
    {

        public void Configure(EntityTypeBuilder<Acesso> builder)
        {
            builder.ToTable("Acesso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(14);
        }
    }
}

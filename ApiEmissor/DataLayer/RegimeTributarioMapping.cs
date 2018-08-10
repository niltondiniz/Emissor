using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class RegimeTributarioMapping : IEntityTypeConfiguration<RegimeTributario>, IMapping
    {

        public void Configure(EntityTypeBuilder<RegimeTributario> builder)
        {
            builder.ToTable("RegimeTributario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CRT).IsRequired();
            builder.HasMany(x => x.EmpresasEmitentes).WithOne(e => e.CRT);
        }
    }
}

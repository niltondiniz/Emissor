using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class EmpresaConfigNFMapping : IEntityTypeConfiguration<EmpresaConfigNF>, IMapping
    {

        public void Configure(EntityTypeBuilder<EmpresaConfigNF> builder)
        {
            builder.ToTable("EmpresaConfigNF");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.TipoEmissao).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Ambiente).IsRequired().HasMaxLength(10);
            builder.Property(x => x.FormaEmissao).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Modelo).IsRequired().HasMaxLength(2);
            builder.Property(x => x.Serie).IsRequired().HasMaxLength(1);
            builder.Property(x => x.SerieCertificado).IsRequired().HasMaxLength(100);   
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>, IMapping
    {

        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Logo).HasMaxLength(500);
            builder.HasOne(x => x.EmpresaConfigNF).WithOne(e => e.Empresa);
            builder.HasOne(x => x.EmpresaEmitente).WithOne(e => e.Empresa);
        }
    }
}

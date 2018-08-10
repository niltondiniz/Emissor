using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class EmpresaEmitenteMapping : IEntityTypeConfiguration<EmpresaEmitente>, IMapping
    {

        public void Configure(EntityTypeBuilder<EmpresaEmitente> builder)
        {
            builder.ToTable("EmpresaEmitente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.CNAE).IsRequired().HasMaxLength(10);
            builder.Property(x => x.AliquotaCofins).IsRequired();
            builder.Property(x => x.AliquotaPis).IsRequired();
            builder.Property(x => x.CpfCnpjContador).IsRequired().HasMaxLength(14);

        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace ApiEmissor.DataLayer
{
    public class PapeisPessoaMapping : IEntityTypeConfiguration<PapeisPessoa>, IMapping
    {
        public void Configure(EntityTypeBuilder<PapeisPessoa> builder)
        {
            builder.ToTable("PapeisPessoa");

            builder.HasKey(pp => new { pp.PapelId, pp.PessoaId });
        }
    }
}

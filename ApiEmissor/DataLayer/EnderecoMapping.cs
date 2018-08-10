using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ApiEmissor.DataLayer
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>, IMapping
    {

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Complemento).HasMaxLength(50);
            builder.Property(x => x.Descricao).HasMaxLength(50);
            builder.Property(x => x.IBGE).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Observacao).HasMaxLength(300);
            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.UF).IsRequired().HasMaxLength(2);
            builder.HasOne(x => x.Pessoa).WithMany(e => e.PessoaEnderecos);
        }
    }
}

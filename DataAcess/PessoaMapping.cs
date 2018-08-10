using System;
namespace Models
{
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>, IMapping
    {
        public PessoaMapping()
        {
        }
    }
}

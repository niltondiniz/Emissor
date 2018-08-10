using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public ICollection<Endereco> PessoaEnderecos { get; set; }
        public ICollection<PapeisPessoa> PapeisPessoa { get; set; }

        public virtual Acesso PessoaAcesso { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual PessoaFiscal PessoaFiscal { get; set; }

        public Pessoa()
        {
            PessoaEnderecos = new Collection<Endereco>();
            PapeisPessoa = new Collection<PapeisPessoa>();
        }
    }
}

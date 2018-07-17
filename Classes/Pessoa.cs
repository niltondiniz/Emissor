using System;
using System.Collections.Generic;

namespace Classes
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<PessoaEndereco> PessoaEnderecos { get; set; }
        public List<PessoaFiscal> PessoaFiscal { get; set; }
        public List<PessoaPapel> PessoaPapeis { get; set; }
        public PessoaAcesso PessoaAcesso { get; set; }
        public Pessoa()
        {
        }
    }
}

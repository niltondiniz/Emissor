using System;
namespace Classes
{
    public class PessoaEndereco
    {
        public int Seq { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public string IBGE { get; set; }
        public int Tipo { get; set; }
        public PessoaEndereco()
        {
        }
    }
}

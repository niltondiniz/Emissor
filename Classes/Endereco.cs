using System;
namespace Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public string IBGE { get; set; }
        public int Tipo { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Endereco()
        {
        }
    }
}

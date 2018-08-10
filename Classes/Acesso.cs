using System;
namespace Models
{
    public class Acesso
    {
        public int Id { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}

using System;
namespace Models
{
    public class PessoaAcesso
    {
        public int Id { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int PessoaId { get; set; }
        public PessoaAcesso()
        {
        }
    }
}

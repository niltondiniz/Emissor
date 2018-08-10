using System;
namespace Models
{
    public class PapeisPessoa
    {
        //Chaves
        public int PessoaId { get; set; }
        public int PapelId { get; set; }

        //Propriedades de Navegacao
        public Pessoa Pessoa { get; set; }
        public Papel Papel { get; set; }

        public PapeisPessoa()
        {
            
        }
    }
}

using System;
namespace Models
{
    public class PessoaFiscal
    {
        public int Id { get; set; }
        public int IsentoIe { get; set; }
        public string IE { get; set; }
        public string Suframa { get; set; }
        public string Razao { get; set; }
        public string ConsumidorFinal { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public PessoaFiscal()
        {
        }
    }
}

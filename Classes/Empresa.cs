using System;
namespace Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual EmpresaEmitente EmpresaEmitente { get; set; }
        public virtual EmpresaConfigNF EmpresaConfigNF { get; set; }
        public Empresa()
        {
        }
    }
}

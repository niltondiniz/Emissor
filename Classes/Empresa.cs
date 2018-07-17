using System;
namespace Classes
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public Pessoa Pessoa { get; set; }
        public EmpresaEmitente EmpresaEmitente { get; set; }
        public EmpresaConfigNF EmpresaConfigNF { get; set; }
        public Empresa()
        {
        }
    }
}

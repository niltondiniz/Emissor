using System;
namespace Models
{
    public class EmpresaConfigNF
    {
        public int Id { get; set; }
        public string TipoEmissao { get; set; }
        public string SerieCertificado { get; set; }
        public int Ambiente { get; set; }
        public int FormaEmissao { get; set; }
        public int Modelo { get; set; }
        public string Serie { get; set; }
        public int UltimaNfe { get; set; }
        public int UltimaNfce { get; set; }
        public int EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }

        public EmpresaConfigNF()
        {
        }
    }
}

using System;
namespace Models
{
    public class EmpresaEmitente
    {
        public int Id { get; set; }
        public string CNAE { get; set; }
        public string CpfCnpjContador { get; set; }
        public int RegimePisCofins { get; set; }
        public bool PisCofinsMonofasico { get; set; }
        public double AliquotaPis { get; set; }
        public double AliquotaCofins { get; set; }
        public double CreditoSN { get; set; }
        public int EmpresaId { get; set; }
        public int RegimeTributarioId { get; set; }

        public virtual RegimeTributario CRT { get; set; }
        public virtual Empresa Empresa { get; set; }

        public EmpresaEmitente()
        {
        }
    }
}

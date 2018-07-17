using System;
namespace Classes
{
    public class EmpresaEmitente
    {
        public string CNAE { get; set; }
        public RegimeTributario CRT { get; set; }
        public string CpfCnpjContador { get; set; }
        public int RegimePisCofins { get; set; }
        public bool PisCofinsMonofasico { get; set; }
        public double AliquotaPis { get; set; }
        public double AliquotaCofins { get; set; }
        public double CreditoSN { get; set; }
        public EmpresaEmitente()
        {
        }
    }
}

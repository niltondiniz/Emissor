using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
    public class RegimeTributario
    {
        public int Id { get; set; }
        public int CRT { get; set; }
        public string Descricao { get; set; }

        public ICollection<EmpresaEmitente> EmpresasEmitentes { get; set; }

        public RegimeTributario()
        {
            EmpresasEmitentes = new Collection<EmpresaEmitente>();
        }
    }
}

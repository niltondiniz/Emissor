using System;
namespace Models
{
    public class Papeis
    {
        public Guid Id { get; set; }
        public string Papel { get; set; }
        public bool Ativo { get; set; }

        public Papeis()
        {
        }
    }
}

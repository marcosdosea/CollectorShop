using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Envio
    {
        public Envio()
        {
            Compra = new HashSet<Compra>();
            Troca = new HashSet<Troca>();
        }

        public int CodEnvio { get; set; }
        public float Preco { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Troca> Troca { get; set; }
    }
}

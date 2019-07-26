using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbenvio
    {
        public Tbenvio()
        {
            Tbcompra = new HashSet<Tbcompra>();
            Tbtroca = new HashSet<Tbtroca>();
        }

        public int CodEnvio { get; set; }
        public float Preco { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Tbcompra> Tbcompra { get; set; }
        public virtual ICollection<Tbtroca> Tbtroca { get; set; }
    }
}

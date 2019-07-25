using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBEnvio
    {
        public TBEnvio()
        {
            Compra = new HashSet<TBCompra>();
            Troca = new HashSet<TBTroca>();
        }

        public int CodEnvio { get; set; }
        public float Preco { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<TBCompra> Compra { get; set; }
        public virtual ICollection<TBTroca> Troca { get; set; }
    }
}

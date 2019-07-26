using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbBEnvio
    {
        public TbBEnvio()
        {
            Compra = new HashSet<TbCompra>();
            Troca = new HashSet<TbTroca>();
        }

        public int CodEnvio { get; set; }
        public float Preco { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<TbCompra> Compra { get; set; }
        public virtual ICollection<TbTroca> Troca { get; set; }
    }
}

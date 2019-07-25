using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBPagamento
    {
        public TBPagamento()
        {
            Compra = new HashSet<TBCompra>();
            Troca = new HashSet<TBTroca>();
        }

        public int CodPagamento { get; set; }
        public string Opcao { get; set; }
        public float Valor { get; set; }

        public virtual ICollection<TBCompra> Compra { get; set; }
        public virtual ICollection<TBTroca> Troca { get; set; }
    }
}

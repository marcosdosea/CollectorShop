using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbPagamento
    {
        public TbPagamento()
        {
            Compra = new HashSet<TbCompra>();
            Troca = new HashSet<TbTroca>();
        }

        public int CodPagamento { get; set; }
        public string Opcao { get; set; }
        public float Valor { get; set; }

        public virtual ICollection<TbCompra> Compra { get; set; }
        public virtual ICollection<TbTroca> Troca { get; set; }
    }
}

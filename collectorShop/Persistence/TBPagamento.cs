using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbpagamento
    {
        public Tbpagamento()
        {
            Tbcompra = new HashSet<Tbcompra>();
            Tbtroca = new HashSet<Tbtroca>();
        }

        public int CodPagamento { get; set; }
        public string Opcao { get; set; }
        public float Valor { get; set; }

        public virtual ICollection<Tbcompra> Tbcompra { get; set; }
        public virtual ICollection<Tbtroca> Tbtroca { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbpagamento
    {
        public Tbpagamento()
        {
            Negociacaopagamento = new HashSet<Negociacaopagamento>();
        }

        public int CodPagamento { get; set; }
        public float Valor { get; set; }
        public string Opcao { get; set; }

        public virtual ICollection<Negociacaopagamento> Negociacaopagamento { get; set; }
    }
}

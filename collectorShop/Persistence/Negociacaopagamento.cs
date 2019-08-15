using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Negociacaopagamento
    {
        public int CodNegociacao { get; set; }
        public int CodPagamento { get; set; }

        public virtual Tbnegociacao CodNegociacaoNavigation { get; set; }
        public virtual Tbpagamento CodPagamentoNavigation { get; set; }
    }
}

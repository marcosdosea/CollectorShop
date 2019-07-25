using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBTroca
    {
        public int CodTroca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }

        public virtual TBEnvio CodEnvioNavigation { get; set; }
        public virtual TBPagamento CodPagamentoNavigation { get; set; }
        public virtual TBUsuario CodUsuarioNavigation { get; set; }
    }
}

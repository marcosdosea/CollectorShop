using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Troca
    {
        public int CodTroca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }

        public virtual Envio CodEnvioNavigation { get; set; }
        public virtual Pagamento CodPagamentoNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}

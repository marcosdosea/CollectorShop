using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbTroca
    {
        public int CodTroca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }

        public virtual TbBEnvio CodEnvioNavigation { get; set; }
        public virtual TbPagamento CodPagamentoNavigation { get; set; }
        public virtual TbUsuario CodUsuarioNavigation { get; set; }
    }
}

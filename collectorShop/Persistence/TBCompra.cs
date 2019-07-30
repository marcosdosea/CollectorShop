using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbcompra
    {
        public int CodCompra { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }
        public float ValorUnitario { get; set; }
        public int CodModelo { get; set; }

        public virtual Tbenvio CodEnvioNavigation { get; set; }
        public virtual Tbmodelo CodModeloNavigation { get; set; }
        public virtual Tbpagamento CodPagamentoNavigation { get; set; }
        public virtual Tbusuario CodUsuarioNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBCompra
    {
        public int CodCompra { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int? CodUsuario { get; set; }
        public float? ValorUnitario { get; set; }
        public int CodModelo { get; set; }

        public virtual TBEnvio CodEnvioNavigation { get; set; }
        public virtual TBModelo CodModeloNavigation { get; set; }
        public virtual TBPagamento CodPagamentoNavigation { get; set; }
        public virtual TBUsuario CodUsuarioNavigation { get; set; }
        public object CodAnuncio { get; internal set; }
    }
}

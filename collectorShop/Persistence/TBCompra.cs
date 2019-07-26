using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbCompra
    {
        public int CodCompra { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int? CodUsuario { get; set; }
        public float? ValorUnitario { get; set; }
        public int CodModelo { get; set; }

        public int CodAnuncio { get; set; }

        public virtual TbBEnvio CodEnvioNavigation { get; set; }
        public virtual TbModelo CodModeloNavigation { get; set; }
        public virtual TbPagamento CodPagamentoNavigation { get; set; }
        public virtual TbUsuario CodUsuarioNavigation { get; set; }
        public virtual TbAnuncio CodAnuncioNavigation { get; set; }
        //  public object CodAnuncio { get; internal set; }
    }
}

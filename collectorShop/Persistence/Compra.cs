using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Compra
    {
        public int CodCompra { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int? CodUsuario { get; set; }
        public float? ValorUnitario { get; set; }
        public int CodModelo { get; set; }

        public virtual Envio CodEnvioNavigation { get; set; }
        public virtual Modelo CodModeloNavigation { get; set; }
        public virtual Pagamento CodPagamentoNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbtroca
    {
        public Tbtroca()
        {
            Tbtrocaanuncio = new HashSet<Tbtrocaanuncio>();
            Tbtrocamodelo = new HashSet<Tbtrocamodelo>();
        }

        public int CodTroca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }

        public virtual Tbenvio CodEnvioNavigation { get; set; }
        public virtual Tbpagamento CodPagamentoNavigation { get; set; }
        public virtual Tbusuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<Tbtrocaanuncio> Tbtrocaanuncio { get; set; }
        public virtual ICollection<Tbtrocamodelo> Tbtrocamodelo { get; set; }
    }
}

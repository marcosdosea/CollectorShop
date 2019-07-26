using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Troca
    {
        public Troca()
        {
            Trocaanuncio = new HashSet<Trocaanuncio>();
            Trocamodelo = new HashSet<Trocamodelo>();
        }

        public int CodTroca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }

        public Envio CodEnvioNavigation { get; set; }
        public Pagamento CodPagamentoNavigation { get; set; }
        public Usuario CodUsuarioNavigation { get; set; }
        public ICollection<Trocaanuncio> Trocaanuncio { get; set; }
        public ICollection<Trocamodelo> Trocamodelo { get; set; }
    }
}

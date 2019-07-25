using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBAnuncio
    {
        public TBAnuncio()
        {
            Anunciomodelo = new HashSet<TBAnunciomodelo>();
            Trocaanuncio = new HashSet<TBTrocaanuncio>();
        }

        public int CodAnuncio { get; set; }
        public string Status { get; set; }
        public int QuantAnunciada { get; set; }
        public int? QuantDisponivel { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public float? Valor { get; set; }
        public int CodUsuario { get; set; }
        public string Msg { get; set; }

        public virtual TBUsuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<TBAnunciomodelo> Anunciomodelo { get; set; }
        public virtual ICollection<TBTrocaanuncio> Trocaanuncio { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbAnuncio
    {
        public TbAnuncio()
        {
            Anunciomodelo = new HashSet<TbAnunciomodelo>();
            Trocaanuncio = new HashSet<TbTrocaanuncio>();
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

        public virtual TbUsuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<TbAnunciomodelo> Anunciomodelo { get; set; }
        public virtual ICollection<TbTrocaanuncio> Trocaanuncio { get; set; }
    }
}

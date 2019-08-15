using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbanuncio
    {
        public Tbanuncio()
        {
            Anunciomodelo = new HashSet<Anunciomodelo>();
            Negociacaoanuncio = new HashSet<Negociacaoanuncio>();
        }

        public int CodAnuncio { get; set; }
        public string Status { get; set; }
        public int QuantAnunciada { get; set; }
        public int QuantDisponivel { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public int CodUsuario { get; set; }

        public virtual Tbusuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<Anunciomodelo> Anunciomodelo { get; set; }
        public virtual ICollection<Negociacaoanuncio> Negociacaoanuncio { get; set; }
    }
}

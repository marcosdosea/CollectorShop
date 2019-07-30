using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbanuncio
    {
        public Tbanuncio()
        {
            Tbanunciomodelo = new HashSet<Tbanunciomodelo>();
            Tbtrocaanuncio = new HashSet<Tbtrocaanuncio>();
        }

        public int CodAnuncio { get; set; }
        public string Status { get; set; }
        public int QuantAnunciada { get; set; }
        public int QuantDisponivel { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public int CodUsuario { get; set; }
        public string Msg { get; set; }

        public virtual Tbusuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<Tbanunciomodelo> Tbanunciomodelo { get; set; }
        public virtual ICollection<Tbtrocaanuncio> Tbtrocaanuncio { get; set; }
    }
}

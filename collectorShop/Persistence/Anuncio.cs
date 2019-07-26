using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Anuncio
    {
        public Anuncio()
        {
            Anunciomodelo = new HashSet<Anunciomodelo>();
            Trocaanuncio = new HashSet<Trocaanuncio>();
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

        public Usuario CodUsuarioNavigation { get; set; }
        public ICollection<Anunciomodelo> Anunciomodelo { get; set; }
        public ICollection<Trocaanuncio> Trocaanuncio { get; set; }
    }
}

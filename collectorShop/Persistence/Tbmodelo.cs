using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbmodelo
    {
        public Tbmodelo()
        {
            Anunciomodelo = new HashSet<Anunciomodelo>();
            Negociacaomodelo = new HashSet<Negociacaomodelo>();
        }

        public int CodModelo { get; set; }
        public string Nome { get; set; }
        public string QuantTiragem { get; set; }
        public string Colecao { get; set; }
        public string Label { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Edicao { get; set; }
        public string Roteirista { get; set; }
        public string Desenhista { get; set; }
        public string Isbn { get; set; }
        public string Autor { get; set; }
        public int CodSubcategoria { get; set; }
        public int TbUsuarioCodUsuario { get; set; }

        public virtual Tbsubcategoria CodSubcategoriaNavigation { get; set; }
        public virtual Tbusuario TbUsuarioCodUsuarioNavigation { get; set; }
        public virtual ICollection<Anunciomodelo> Anunciomodelo { get; set; }
        public virtual ICollection<Negociacaomodelo> Negociacaomodelo { get; set; }
    }
}

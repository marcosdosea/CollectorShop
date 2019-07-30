using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbmodelo
    {
        public Tbmodelo()
        {
            Tbanunciomodelo = new HashSet<Tbanunciomodelo>();
            Tbcompra = new HashSet<Tbcompra>();
            Tbtrocamodelo = new HashSet<Tbtrocamodelo>();
        }

        public int CodModelo { get; set; }
        public string Nome { get; set; }
        public string QuantTiragem { get; set; }
        public string Colecao { get; set; }
        public string Label { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public int CodUsuario { get; set; }
        public int CodSubcategoria { get; set; }

        public virtual Tbsubcategoria CodSubcategoriaNavigation { get; set; }
        public virtual Tbusuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<Tbanunciomodelo> Tbanunciomodelo { get; set; }
        public virtual ICollection<Tbcompra> Tbcompra { get; set; }
        public virtual ICollection<Tbtrocamodelo> Tbtrocamodelo { get; set; }
    }
}

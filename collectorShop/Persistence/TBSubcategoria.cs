using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbsubcategoria
    {
        public Tbsubcategoria()
        {
            Tbmodelo = new HashSet<Tbmodelo>();
            Tbusuariosubcategoria = new HashSet<Tbusuariosubcategoria>();
        }

        public int CodSubcategoria { get; set; }
        public string Nome { get; set; }
        public int CodCategoria { get; set; }

        public virtual TbCategoria CodCategoriaNavigation { get; set; }
        public virtual ICollection<Tbmodelo> Tbmodelo { get; set; }
        public virtual ICollection<Tbusuariosubcategoria> Tbusuariosubcategoria { get; set; }
    }
}

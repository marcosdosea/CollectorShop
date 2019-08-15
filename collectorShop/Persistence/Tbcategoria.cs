using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbcategoria
    {
        public Tbcategoria()
        {
            Tbsubcategoria = new HashSet<Tbsubcategoria>();
        }

        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Tbsubcategoria> Tbsubcategoria { get; set; }
    }
}

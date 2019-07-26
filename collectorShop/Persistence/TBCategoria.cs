using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbCategoria
    {
        public TbCategoria()
        {
            Tbsubcategoria = new HashSet<Tbsubcategoria>();
            Tbusuariocategoria = new HashSet<Tbusuariocategoria>();
        }

        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Tbsubcategoria> Tbsubcategoria { get; set; }
        public virtual ICollection<Tbusuariocategoria> Tbusuariocategoria { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbCategoria
    {
        public TbCategoria()
        {
            Tbsubcategoria = new HashSet<Tbsubcategoria>();
        }

        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public ICollection<Tbsubcategoria> Tbsubcategoria { get; set; }
    }
}

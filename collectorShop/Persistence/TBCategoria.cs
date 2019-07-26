using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbCategoria
    {
        public TbCategoria()
        {
            Usuariocategoria = new HashSet<TbUsuariocategoria>();
        }

        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TbUsuariocategoria> Usuariocategoria { get; set; }
        public IEnumerable<TbSubcategoria> Subcategoria { get; internal set; }
    }
}

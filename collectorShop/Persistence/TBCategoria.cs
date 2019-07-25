using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBCategoria
    {
        public TBCategoria()
        {
            Usuariocategoria = new HashSet<TBUsuariocategoria>();
        }

        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TBUsuariocategoria> Usuariocategoria { get; set; }
        public IEnumerable<TBSubcategoria> Subcategoria { get; internal set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Categoria
    {
        public Categoria()
        {
            Usuariocategoria = new HashSet<Usuariocategoria>();
        }

        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Usuariocategoria> Usuariocategoria { get; set; }
    }
}

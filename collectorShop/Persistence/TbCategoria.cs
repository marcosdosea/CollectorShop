using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Persistence
{
    public partial class TbCategoria
    {
        public TbCategoria()
        {
            Usuariocategoria = new HashSet<Usuariocategoria>();
        }

        [Key]
        public int CodCategoria { get; set; }
        public string Nome { get; set; }

        public ICollection<Usuariocategoria> Usuariocategoria { get; set; }
    }
}

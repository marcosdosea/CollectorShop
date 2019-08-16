using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Subcategoria
    {
        public int CodSubcategoria { get; set; }
        public string Nome { get; set; }
        public int CodCategoria { get; set; }

        public string NomeCategoria { get; set; }
    }
}

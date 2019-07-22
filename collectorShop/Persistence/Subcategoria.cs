using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Subcategoria
    {
        public int CodSubcategoria { get; set; }
        public string Nome { get; set; }
        public int CodCategoria { get; set; }

        public virtual Categoria CodCategoriaNavigation { get; set; }
    }
}

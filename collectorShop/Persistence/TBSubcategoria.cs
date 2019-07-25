using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBSubcategoria
    {
        public int CodSubcategoria { get; set; }
        public string Nome { get; set; }
        public int CodCategoria { get; set; }

        public virtual TBCategoria CodCategoriaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBUsuariocategoria
    {
        public int CodUsuario { get; set; }
        public int CodCategoria { get; set; }

        public virtual TBCategoria CodCategoriaNavigation { get; set; }
        public virtual TBUsuario CodUsuarioNavigation { get; set; }
    }
}

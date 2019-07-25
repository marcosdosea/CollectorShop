using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBUsuariosubcategoria
    {
        public int CodUsuario { get; set; }
        public int CodSubcategoria { get; set; }

        public virtual TBUsuario CodUsuarioNavigation { get; set; }
    }
}

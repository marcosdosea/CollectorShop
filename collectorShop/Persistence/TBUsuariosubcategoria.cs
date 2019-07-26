using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbusuariosubcategoria
    {
        public int CodUsuario { get; set; }
        public int CodSubcategoria { get; set; }

        public virtual Tbsubcategoria CodSubcategoriaNavigation { get; set; }
        public virtual Tbusuario CodUsuarioNavigation { get; set; }
    }
}

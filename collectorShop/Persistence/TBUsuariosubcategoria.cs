using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbUsuariosubcategoria
    {
        public int CodUsuario { get; set; }
        public int CodSubcategoria { get; set; }

        public virtual TbUsuario CodUsuarioNavigation { get; set; }
    }
}

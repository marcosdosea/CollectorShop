using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbUsuariocategoria
    {
        public int CodUsuario { get; set; }
        public int CodCategoria { get; set; }

        public virtual TbCategoria CodCategoriaNavigation { get; set; }
        public virtual TbUsuario CodUsuarioNavigation { get; set; }
    }
}

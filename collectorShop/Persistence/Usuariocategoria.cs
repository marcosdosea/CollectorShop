using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Usuariocategoria
    {
        public int CodUsuario { get; set; }
        public int CodCategoria { get; set; }

        public TbCategoria CodCategoriaNavigation { get; set; }
        public Usuario CodUsuarioNavigation { get; set; }
    }
}

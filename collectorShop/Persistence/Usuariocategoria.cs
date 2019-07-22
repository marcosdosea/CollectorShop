using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Usuariocategoria
    {
        public int CodCategoria { get; set; }
        public int CodUsuario { get; set; }

        public virtual Categoria CodCategoriaNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}

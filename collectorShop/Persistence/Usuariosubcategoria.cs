﻿using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Usuariosubcategoria
    {
        public int CodUsuario { get; set; }
        public int CodSubcategoria { get; set; }

        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
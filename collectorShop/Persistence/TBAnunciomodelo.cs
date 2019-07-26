using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbAnunciomodelo
    {
        public int CodAnuncio { get; set; }
        public int CodModelo { get; set; }

        public virtual TbAnuncio CodAnuncioNavigation { get; set; }
        public virtual TbModelo CodModeloNavigation { get; set; }
    }
}

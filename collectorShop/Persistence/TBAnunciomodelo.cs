using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBAnunciomodelo
    {
        public int CodAnuncio { get; set; }
        public int CodModelo { get; set; }

        public virtual TBAnuncio CodAnuncioNavigation { get; set; }
        public virtual TBModelo CodModeloNavigation { get; set; }
    }
}

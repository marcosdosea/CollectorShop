using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBTrocaanuncio
    {
        public int CodTroca { get; set; }
        public int CodAnuncio { get; set; }

        public virtual TBAnuncio CodAnuncioNavigation { get; set; }
    }
}

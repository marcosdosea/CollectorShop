using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbtrocaanuncio
    {
        public int CodTroca { get; set; }
        public int CodAnuncio { get; set; }

        public virtual Tbanuncio CodAnuncioNavigation { get; set; }
        public virtual Tbtroca CodTrocaNavigation { get; set; }
    }
}

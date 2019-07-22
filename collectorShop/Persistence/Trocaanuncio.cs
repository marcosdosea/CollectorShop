using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Trocaanuncio
    {
        public int CodTroca { get; set; }
        public int CodAnuncio { get; set; }

        public virtual Anuncio CodAnuncioNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Trocaanuncio
    {
        public int CodTroca { get; set; }
        public int CodAnuncio { get; set; }

        public Anuncio CodAnuncioNavigation { get; set; }
        public Troca CodTrocaNavigation { get; set; }
    }
}

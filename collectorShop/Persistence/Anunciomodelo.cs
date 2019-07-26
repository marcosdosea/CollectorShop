using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Anunciomodelo
    {
        public int CodAnuncio { get; set; }
        public int CodModelo { get; set; }

        public Anuncio CodAnuncioNavigation { get; set; }
        public Modelo CodModeloNavigation { get; set; }
    }
}

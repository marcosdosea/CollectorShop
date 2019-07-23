using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Anunciomodelo
    {
        public int CodAnuncio { get; set; }
        public int CodModelo { get; set; }

        public virtual Anuncio CodAnuncioNavigation { get; set; }
        public virtual Modelo CodModeloNavigation { get; set; }
    }
}

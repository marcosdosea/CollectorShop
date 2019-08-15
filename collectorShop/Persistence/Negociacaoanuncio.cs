using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Negociacaoanuncio
    {
        public int CodNegociacao { get; set; }
        public int CodAnuncio { get; set; }

        public virtual Tbanuncio CodAnuncioNavigation { get; set; }
        public virtual Tbnegociacao CodNegociacaoNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Trocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int ModeloCodModelo { get; set; }

        public virtual Modelo ModeloCodModeloNavigation { get; set; }
    }
}

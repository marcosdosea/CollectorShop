using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Trocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int CodModelo { get; set; }

        public virtual Modelo CodModeloNavigation { get; set; }
    }
}

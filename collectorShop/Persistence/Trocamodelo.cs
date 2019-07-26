using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Trocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int ModeloCodModelo { get; set; }

        public Modelo ModeloCodModeloNavigation { get; set; }
        public Troca TrocaCodTrocaNavigation { get; set; }
    }
}

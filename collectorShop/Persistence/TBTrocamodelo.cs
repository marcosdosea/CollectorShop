using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbtrocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int ModeloCodModelo { get; set; }

        public virtual Tbmodelo ModeloCodModeloNavigation { get; set; }
        public virtual Tbtroca TrocaCodTrocaNavigation { get; set; }
    }
}

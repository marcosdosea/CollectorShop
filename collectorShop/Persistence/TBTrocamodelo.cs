using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBTrocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int ModeloCodModelo { get; set; }

        public virtual TBModelo ModeloCodModeloNavigation { get; set; }
        public object CodModelo { get; internal set; }
        public object CodModeloNavigation { get; internal set; }
    }
}

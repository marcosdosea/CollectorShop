using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBTrocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int ModeloCodModelo { get; set; }

        public virtual TBModelo ModeloCodModeloNavigation { get; set; }

        public virtual TBTroca TrocaCodModeloNavigation { get; set; }
     //   public int CodModelo { get; set; }
     //   public object CodModeloNavigation { get; internal set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbTrocamodelo
    {
        public int TrocaCodTroca { get; set; }
        public int ModeloCodModelo { get; set; }

        public virtual TbModelo ModeloCodModeloNavigation { get; set; }

        public virtual TbTroca TrocaCodModeloNavigation { get; set; }
     //   public int CodModelo { get; set; }
     //   public object CodModeloNavigation { get; internal set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Negociacaomodelo
    {
        public int CodNegociacao { get; set; }
        public int CodModelo { get; set; }

        public virtual Tbmodelo CodModeloNavigation { get; set; }
        public virtual Tbnegociacao CodNegociacaoNavigation { get; set; }
    }
}

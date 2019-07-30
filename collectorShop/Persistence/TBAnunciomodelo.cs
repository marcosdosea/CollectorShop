using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbanunciomodelo
    {
        public int CodAnuncio { get; set; }
        public int CodModelo { get; set; }

        public virtual Tbanuncio CodAnuncioNavigation { get; set; }
        public virtual Tbmodelo CodModeloNavigation { get; set; }
    }
}

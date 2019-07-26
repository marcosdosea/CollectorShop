using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbTrocaanuncio
    {
        public int CodTroca { get; set; }
        public int CodAnuncio { get; set; }

        public virtual TbAnuncio CodAnuncioNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Troca
    {
        public int CodTroca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int CodEnvio { get; set; }
        public int CodPagamento { get; set; }
        public int CodUsuario { get; set; }

    }
}

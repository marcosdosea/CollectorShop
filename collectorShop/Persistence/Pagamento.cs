﻿using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Pagamento
    {
        public Pagamento()
        {
            Compra = new HashSet<Compra>();
            Troca = new HashSet<Troca>();
        }

        public int CodPagamento { get; set; }
        public string Opcao { get; set; }
        public float Valor { get; set; }

        public ICollection<Compra> Compra { get; set; }
        public ICollection<Troca> Troca { get; set; }
    }
}

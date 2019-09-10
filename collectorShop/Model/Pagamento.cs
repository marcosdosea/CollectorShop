using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Pagamento
    {

        public int CodPagamento { get; set; }
        public string Opcao { get; set; }
        public float Valor { get; set; }
        public int CodNegociação { get; set;}
       
    }
}

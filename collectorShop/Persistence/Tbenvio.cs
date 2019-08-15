using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbenvio
    {
        public int CodEnvio { get; set; }
        public float Valor { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Complemento { get; set; }
        public int CodNegociacao { get; set; }

        public virtual Tbnegociacao CodNegociacaoNavigation { get; set; }
    }
}

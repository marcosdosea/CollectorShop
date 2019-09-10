using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbnegociacao
    {
        public Tbnegociacao()
        {
            Negociacaoanuncio = new HashSet<Negociacaoanuncio>();
            Negociacaomodelo = new HashSet<Negociacaomodelo>();
            Negociacaopagamento = new HashSet<Negociacaopagamento>();
            Tbenvio = new HashSet<Tbenvio>();
        }

        public int CodNegociacao { get; set; }
        public DateTime Data { get; set; }
        public float ValorProposto { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
        public int CodUsuario { get; set; }
        

        public virtual Tbusuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<Negociacaoanuncio> Negociacaoanuncio { get; set; }
        public virtual ICollection<Negociacaomodelo> Negociacaomodelo { get; set; }
        public virtual ICollection<Negociacaopagamento> Negociacaopagamento { get; set; }
        public virtual ICollection<Tbenvio> Tbenvio { get; set; }
    }
}

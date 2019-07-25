using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBModelo
    {
        public TBModelo()
        {
            Anunciomodelo = new HashSet<TBAnunciomodelo>();
            Compra = new HashSet<TBCompra>();
            Trocamodelo = new HashSet<TBTrocamodelo>();
        }

        public int CodModelo { get; set; }
        public string Nome { get; set; }
        public string QuantTiragem { get; set; }
        public string Colecao { get; set; }
        public string Label { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public int CodSubcategoria { get; set; }
        public int CodUsuario { get; set; }

        public virtual TBUsuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<TBAnunciomodelo> Anunciomodelo { get; set; }
        public virtual ICollection<TBCompra> Compra { get; set; }
        public virtual ICollection<TBTrocamodelo> Trocamodelo { get; set; }
    }
}

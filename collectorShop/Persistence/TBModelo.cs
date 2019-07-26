using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbModelo
    {
        public TbModelo()
        {
            Anunciomodelo = new HashSet<TbAnunciomodelo>();
            Compra = new HashSet<TbCompra>();
            Trocamodelo = new HashSet<TbTrocamodelo>();
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

        public virtual TbUsuario CodUsuarioNavigation { get; set; }
        public virtual ICollection<TbAnunciomodelo> Anunciomodelo { get; set; }
        public virtual ICollection<TbCompra> Compra { get; set; }
        public virtual ICollection<TbTrocamodelo> Trocamodelo { get; set; }
    }
}

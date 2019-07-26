using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Modelo
    {
        public Modelo()
        {
            Anunciomodelo = new HashSet<Anunciomodelo>();
            Compra = new HashSet<Compra>();
            Trocamodelo = new HashSet<Trocamodelo>();
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

        public Usuario CodUsuarioNavigation { get; set; }
        public ICollection<Anunciomodelo> Anunciomodelo { get; set; }
        public ICollection<Compra> Compra { get; set; }
        public ICollection<Trocamodelo> Trocamodelo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TBUsuario
    {
        public TBUsuario()
        {
            Anuncio = new HashSet<TBAnuncio>();
            Compra = new HashSet<TBCompra>();
            Modelo = new HashSet<TBModelo>();
            Troca = new HashSet<TBTroca>();
            Usuariocategoria = new HashSet<TBUsuariocategoria>();
            Usuariosubcategoria = new HashSet<TBUsuariosubcategoria>();
        }

        public int CodUsuario { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public byte Administrador { get; set; }

        public virtual ICollection<TBAnuncio> Anuncio { get; set; }
        public virtual ICollection<TBCompra> Compra { get; set; }
        public virtual ICollection<TBModelo> Modelo { get; set; }
        public virtual ICollection<TBTroca> Troca { get; set; }
        public virtual ICollection<TBUsuariocategoria> Usuariocategoria { get; set; }
        public virtual ICollection<TBUsuariosubcategoria> Usuariosubcategoria { get; set; }
    }
}

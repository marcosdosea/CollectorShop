using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class TbUsuario
    {
        public TbUsuario()
        {
            Anuncio = new HashSet<TbAnuncio>();
            Compra = new HashSet<TbCompra>();
            Modelo = new HashSet<TbModelo>();
            Troca = new HashSet<TbTroca>();
            Usuariocategoria = new HashSet<TbUsuariocategoria>();
            Usuariosubcategoria = new HashSet<TbUsuariosubcategoria>();
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

        public virtual ICollection<TbAnuncio> Anuncio { get; set; }
        public virtual ICollection<TbCompra> Compra { get; set; }
        public virtual ICollection<TbModelo> Modelo { get; set; }
        public virtual ICollection<TbTroca> Troca { get; set; }
        public virtual ICollection<TbUsuariocategoria> Usuariocategoria { get; set; }
        public virtual ICollection<TbUsuariosubcategoria> Usuariosubcategoria { get; set; }
    }
}

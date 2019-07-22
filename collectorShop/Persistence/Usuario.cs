using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Usuario
    {
        public Usuario()
        {
            Anuncio = new HashSet<Anuncio>();
            Compra = new HashSet<Compra>();
            Troca = new HashSet<Troca>();
            Usuariocategoria = new HashSet<Usuariocategoria>();
            Usuariosubcategoria = new HashSet<Usuariosubcategoria>();
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

        public virtual ICollection<Anuncio> Anuncio { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Troca> Troca { get; set; }
        public virtual ICollection<Usuariocategoria> Usuariocategoria { get; set; }
        public virtual ICollection<Usuariosubcategoria> Usuariosubcategoria { get; set; }
    }
}

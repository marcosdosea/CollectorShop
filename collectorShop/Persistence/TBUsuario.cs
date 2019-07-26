using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbusuario
    {
        public Tbusuario()
        {
            Tbanuncio = new HashSet<Tbanuncio>();
            Tbcompra = new HashSet<Tbcompra>();
            Tbmodelo = new HashSet<Tbmodelo>();
            Tbtroca = new HashSet<Tbtroca>();
            Tbusuariocategoria = new HashSet<Tbusuariocategoria>();
            Tbusuariosubcategoria = new HashSet<Tbusuariosubcategoria>();
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

        public virtual ICollection<Tbanuncio> Tbanuncio { get; set; }
        public virtual ICollection<Tbcompra> Tbcompra { get; set; }
        public virtual ICollection<Tbmodelo> Tbmodelo { get; set; }
        public virtual ICollection<Tbtroca> Tbtroca { get; set; }
        public virtual ICollection<Tbusuariocategoria> Tbusuariocategoria { get; set; }
        public virtual ICollection<Tbusuariosubcategoria> Tbusuariosubcategoria { get; set; }
    }
}

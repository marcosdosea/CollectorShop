using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Tbusuario
    {
        public Tbusuario()
        {
            Tbanuncio = new HashSet<Tbanuncio>();
            Tbmodelo = new HashSet<Tbmodelo>();
            Tbnegociacao = new HashSet<Tbnegociacao>();
        }

        public int CodUsuario { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Administrador { get; set; }

        public virtual ICollection<Tbanuncio> Tbanuncio { get; set; }
        public virtual ICollection<Tbmodelo> Tbmodelo { get; set; }
        public virtual ICollection<Tbnegociacao> Tbnegociacao { get; set; }
    }
}

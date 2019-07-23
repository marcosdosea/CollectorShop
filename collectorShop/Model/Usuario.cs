using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Usuario
    {
        public int CodUsuario { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public byte Administrador { get; set; }

    }
}

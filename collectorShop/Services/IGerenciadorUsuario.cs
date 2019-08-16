using Model;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface IGerenciadorUsuario
    {
        void Editar(Usuario usuarioModel);
        void Inserir(Usuario usuarioModel);
        Usuario Obter(int idUsuario);
        IEnumerable<Usuario> ObterPorNome(string nome);
        IEnumerable<Usuario> ObterTodos();
        void Remover(int idUsuario);
    }
}


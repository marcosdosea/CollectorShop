using System;
using System.Collections.Generic;
using Model;

namespace Services
{
    public interface IGerenciadorAnuncio
    {
        void Editar(Anuncio anuncioModel);
        int Inserir(Anuncio anuncioModel);
        Anuncio Obter(int codAnuncio);
        IEnumerable<Anuncio> ObterPorNome(String nome);
        IEnumerable<Anuncio> ObterTodos();
        void Remover(int codAnuncio);
    }
}

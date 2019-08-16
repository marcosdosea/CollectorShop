using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IGerenciadorSubcategoria
    {
        void Editar(Subcategoria subcategoriaModel);
        int Inserir(Subcategoria subcategoriaModel);
        Subcategoria Obter(int idSubcategoria);
        IEnumerable<Subcategoria> ObterPorNome(string nome);
        IEnumerable<Subcategoria> ObterTodos();
        void Remover(int idSubcategoria);
    }
}

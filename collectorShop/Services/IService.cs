using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IService<T> where T : class
    {
        void Editar(T entidade);
        int Adicionar(T entidade);
        // Categoria Obter(int idEntidade);
        T Obter(int idEntidade);
        void Remover(int codCategoria);
        //IEnumerable<Categoria> ObterTodos();
        //IEnumerable<Categoria> ObterPorNomeDestinario(string nome);
        IEnumerable<T> ObterTodos();
        IEnumerable<Categoria> ObterPorNome(string nome);
    }
}

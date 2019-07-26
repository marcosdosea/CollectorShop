using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IService<T> where T : class
    {
        void Editar(T entidade);
        int Adicionar(T entidade);
        T Obter(int idEntidade);
        void Remover(T entidade);
        IEnumerable<T> ObterTodos();
    }
}

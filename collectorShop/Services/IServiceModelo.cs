using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IServiceModelo
    {
        void Editar(Modelo modeloModel);
        int Inserir(Modelo modeloModel);
        Modelo Obter(int codModelo);
        IEnumerable<Modelo> ObterPorNome(String nome);
        IEnumerable<Modelo> ObterTodos();
        void Remover(int codModelo);
    }
}

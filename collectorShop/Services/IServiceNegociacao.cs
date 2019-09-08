using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public  interface IServiceNegociacao
    {
        void Editar(Negociacao NegociacaoModel);
        int Inserir(Negociacao negociacaoModel);
        Negociacao Obter(int codNegociacao);
        IEnumerable<Negociacao> ObterTodos();
        void Remover(int codNegociacao);
    }
}

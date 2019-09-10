using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Persistence;

namespace Services
{
   public  interface IServiceNegociacaoAnuncio
    {
        void Editar(NegociacaoAnuncio NegociacaoAnuncio);
        (int,int) Inserir(NegociacaoAnuncio NegociacaoAnuncio);
        NegociacaoAnuncio Obter(int codNegociacao, int codAnuncio);
        IEnumerable<NegociacaoAnuncio> ObterTodos();
        void Remover(int codNegociacao, int codAnuncio);
    }
}

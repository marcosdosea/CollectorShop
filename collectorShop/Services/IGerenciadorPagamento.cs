using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IGerenciadorPagamento
    {
        void Editar(Pagamento pagamentoModel);
        int Inserir(Pagamento pagamentoModel);
        Pagamento Obter(int negociacao);
       // IEnumerable<Pagamento> ObterPorNome(string nome);
        IEnumerable<Pagamento> ObterTodos();
        void Remover(int idPagamento);
    }
}

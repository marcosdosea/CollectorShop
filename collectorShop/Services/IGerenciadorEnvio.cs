using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IGerenciadorEnvio
    {
        void Editar(Envio envioModel);
        int Inserir(Envio envioModel);
        Envio Obter(int idEnvio);
        IEnumerable<Envio> ObterPorNomeDestinario(string nome);
        IEnumerable<Envio> ObterTodos();
        void Remover(int idEnvio);
    }
}

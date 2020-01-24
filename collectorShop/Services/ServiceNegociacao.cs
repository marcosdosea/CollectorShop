using System;
using Model;
using System.Collections.Generic;
using Persistence;
using System.Linq;

namespace Services
{
    public class ServiceNegociacao : IServiceNegociacao

    {
        public bancocollectorContext _Contexto { get; private set; }
        public ServiceNegociacao (bancocollectorContext _contexto)
        {
            _Contexto = _contexto;
        }

        public void Editar(Negociacao negociacaoModel)
        {
            var entidadeParaTabela = new Tbnegociacao();
            Transferir(negociacaoModel, entidadeParaTabela);
            _Contexto.Entry(entidadeParaTabela);
            _Contexto.Entry(entidadeParaTabela).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possivel alterar a negociacao do usuario {entidadeParaTabela.CodUsuarioNavigation.Nome} com a seguinte exceção {e.Message}");

            }

        }

        public int Inserir(Negociacao negociacaoModel)
        {
            var entidadeParaTabela = new Tbnegociacao();
            Transferir(negociacaoModel, entidadeParaTabela);
            _Contexto.Tbnegociacao.Add(entidadeParaTabela);
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
               // throw new Exception($"Não foi possivel inserir a negociacao {entidadeParaTabela.CodNegociacao} do usuario  {entidadeParaTabela.CodUsuarioNavigation.Nome} com a seguinte exceção {e.Message}");

            }
            return negociacaoModel.CodNegociacao;

        }

       
            public Negociacao Obter(int codNegociacao)
        {

            return _Contexto.Tbnegociacao
                .Where(x => x.CodNegociacao == codNegociacao)
                .Select(x => new Negociacao {
                    CodNegociacao = x.CodNegociacao,
                    CodUsuario = x.CodUsuario,
                    Data = x.Data,
                    Status = x.Status,
                    Tipo = x.Tipo,
                    ValorProposto = x.ValorProposto,
                    nomeUsuario = x.CodUsuarioNavigation.Nome
       
                })
                .SingleOrDefault();
        }

        public IEnumerable<Negociacao> ObterTodos()
       => _Contexto.Tbnegociacao.Select(x => new Negociacao
       {

           CodNegociacao = x.CodNegociacao,
           CodUsuario = x.CodUsuario,
           Data = x.Data,
           Status = x.Status,
           Tipo = x.Tipo,
           ValorProposto = x.ValorProposto,
           nomeUsuario = x.CodUsuarioNavigation.Nome

       }).ToList();


        public void Remover(int codNegociacao)
        {
            var tbnegociacao = _Contexto.Tbnegociacao.Find(codNegociacao);
            _Contexto.Tbnegociacao.Remove(tbnegociacao);
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception k)
            {
                throw new Exception($"Não foi possivel remover a negociacao {tbnegociacao.CodNegociacao} do usuario {tbnegociacao.CodUsuarioNavigation.Nome} com a seguinte exceção {k.Message}");

            }
        }
        private void Transferir(Negociacao x, Tbnegociacao y)
        {
            y.CodNegociacao = x.CodNegociacao;
            y.Data = x.Data;
            y.ValorProposto = x.ValorProposto;
            y.Status = x.Status;
            y.Tipo = x.Tipo;
            y.CodUsuario = x.CodUsuario;
            
          
        }
    }
}

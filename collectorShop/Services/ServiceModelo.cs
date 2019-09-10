using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;

namespace Services
{
    public class ServiceModelo : IServiceModelo
    {
        public bancocollectorContext _Contexto { get; private set; }
        public ServiceModelo(bancocollectorContext context)
        {
            _Contexto = context;
        }

        public void Editar(Modelo modeloModel)
        {
            var entidadeParaTabela = new Tbmodelo();
            Transferir(modeloModel, entidadeParaTabela);
            _Contexto.Entry(entidadeParaTabela).State = EntityState.Modified;
            // throw new NotImplementedException();
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possivel alterar a categoria {entidadeParaTabela.Nome} com a seguinte exceção {e.Message}");
            }
        }

        public int Inserir(Modelo modeloModel)
        {
            var entidadeParaTabela = new Tbmodelo();
            Transferir(modeloModel, entidadeParaTabela);
            _Contexto.Tbmodelo.Add(entidadeParaTabela);
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possivel inserir a categoria {entidadeParaTabela.Nome} com a seguinte exceção {e.Message}");
            }
            return modeloModel.CodModelo;
        }

        public Modelo Obter(int codModelo)
        {
            return _Contexto.Tbmodelo.Where(x => x.CodModelo == codModelo).Select(x => new Modelo
            {
                Nome = x.Nome,
                CodModelo = x.CodModelo,
                Ano = x.Ano,
                CodSubcategoria = x.CodSubcategoria,
                CodUsuario = x.TbUsuarioCodUsuario,
                Colecao = x.Colecao,
                Label = x.Label,
                Marca = x.Marca,
                QuantTiragem = x.QuantTiragem,
                nomeSubCategoria = x.CodSubcategoriaNavigation.Nome
            }).SingleOrDefault();
            
        }

        public IEnumerable<Modelo> ObterPorNome(string nome) => _Contexto.Tbmodelo
            .Where(m => m.Nome.Equals(nome))
           .Select(x => new Modelo
           {
               Nome = x.Nome,
               CodModelo = x.CodModelo,
               Ano = x.Ano,
               CodSubcategoria = x.CodSubcategoria,
               CodUsuario = x.TbUsuarioCodUsuario,
               Colecao = x.Colecao,
               Label = x.Label,
               Marca = x.Marca,
               QuantTiragem = x.QuantTiragem,
               nomeSubCategoria = x.CodSubcategoriaNavigation.Nome,
               nomeUsuario = x.TbUsuarioCodUsuarioNavigation.Nome
           }).ToList();


        public IEnumerable<Modelo> ObterTodos() => _Contexto.Tbmodelo.Select(x => new Modelo
        {
            Nome = x.Nome,
            CodModelo = x.CodModelo,
            Ano = x.Ano,
            CodSubcategoria = x.CodSubcategoria,
            CodUsuario = x.TbUsuarioCodUsuario,
            Colecao = x.Colecao,
            Label = x.Label,
            Marca = x.Marca,
            QuantTiragem = x.QuantTiragem,
            nomeSubCategoria = x.CodSubcategoriaNavigation.Nome,
            nomeUsuario = x.TbUsuarioCodUsuarioNavigation.Nome
        }).ToList();



        public void Remover(int codModelo)
        {
            var tbmodelo = _Contexto.Tbmodelo.Find(codModelo);
            _Contexto.Tbmodelo.Remove(tbmodelo);
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception k)
            {
                throw new Exception($"Não foi possivel remover a categoria {tbmodelo.Nome} com a seguinte exceção {k.Message}");

            }
        }
        public void Transferir(Modelo modelo, Tbmodelo tbmodelo)
        {
            tbmodelo.CodModelo = modelo.CodModelo;
            tbmodelo.Nome = modelo.Nome;
            tbmodelo.QuantTiragem = modelo.QuantTiragem;
            tbmodelo.Colecao = modelo.Colecao;
            tbmodelo.Label = modelo.Label;
            tbmodelo.Marca = modelo.Marca;
            tbmodelo.Ano = modelo.Ano;
            tbmodelo.TbUsuarioCodUsuario = modelo.CodUsuario;
            tbmodelo.CodSubcategoria = modelo.CodSubcategoria;


        }
    }
}

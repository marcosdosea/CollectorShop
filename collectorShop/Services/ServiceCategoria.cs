using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ServiceCategoria : IService<Categoria>
    {
        public bancocollectorContext _Contexto { get; private set; }

        public ServiceCategoria(bancocollectorContext _contexto)
        {
            _Contexto = _contexto;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public int Adicionar(Categoria categoria)
        {
            var entidadeParaTabela = new TbCategoria();
            Transferir(categoria, entidadeParaTabela);

            // chamar regra de negocio
            // invalido retutn -999999;
            _Contexto.TbCategoria.Add(entidadeParaTabela);
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possivel inserir a categoria {entidadeParaTabela.Nome} com a seguinte exceção {e.Message}");
            }

            return categoria.CodCategoria;
        }

        private void Transferir(Categoria x, TbCategoria y)
        {
            y.CodCategoria = x.CodCategoria;
            y.Nome = x.Nome;
        }

        public void Editar(Categoria entidade)
        {
            var entidadeParaTabela = new TbCategoria();
            Transferir(entidade, entidadeParaTabela);

            _Contexto.Entry(entidadeParaTabela).State = EntityState.Modified;

            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possivel alterar a categoria {entidadeParaTabela.Nome} com a seguinte exceção {e.Message}");
            }

        }

        public Categoria Obter(int idEntidade)
        {
            //var categoria = new Categoria();

            return _Contexto.TbCategoria
                .Where(x => x.CodCategoria == idEntidade)
                .Select(x => new Categoria { Nome = x.Nome, CodCategoria = x.CodCategoria })
                .SingleOrDefault();

            //return categoria;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public IEnumerable<Categoria> ObterPorNome(string nome)
            => _Contexto.TbCategoria
            .Where(x => x.Nome.Equals(nome))
            .Select(x => new Categoria { Nome = x.Nome, CodCategoria = x.CodCategoria })
            .ToList();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Categoria> ObterTodos()
            => _Contexto.TbCategoria.Select(x => new Categoria { Nome = x.Nome, CodCategoria = x.CodCategoria }).ToList();

        /*public void Remover(Categoria entidade)
        {
            var entidadeParaTabela = new TbCategoria();
            Transferir(entidade, entidadeParaTabela);
            _Contexto.TbCategoria.Remove(entidade);
            
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possivel remover a categoria {entidadeParaTabela.Nome} com a seguinte exceção {e.Message}");
            }
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codCategoria"></param>
        public void Remover(int codCategoria)
        {
            var tbcat = _Contexto.TbCategoria.Find(codCategoria);
            _Contexto.TbCategoria.Remove(tbcat);
            try
            {
                _Contexto.SaveChanges();
            }
            catch (Exception k)
            {
                throw new Exception($"Não foi possivel remover a categoria {tbcat.Nome} com a seguinte exceção {k.Message}");

            }

        }

    }
}

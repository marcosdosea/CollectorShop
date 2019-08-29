using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Persistence;

namespace Services
{
    public class GerenciadorSubcategoria : IGerenciadorSubcategoria
    {
        private readonly bancocollectorContext _context;
        public GerenciadorSubcategoria(bancocollectorContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Atualiza/Edita uma categoria na base de dados
        /// </summary>
        /// <param name="subcategoriaModel"></param>
        public void Editar(Subcategoria subcategoriaModel)
        {
            try
            {
                Tbsubcategoria tbsubcategoria = new Tbsubcategoria();
                Atribuir(subcategoriaModel, tbsubcategoria);
                _context.Update(tbsubcategoria);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Subcategoria não atualizada. Erro de {e.Message}");
            }

        }
        /// <summary>
        /// Insere uma nova subcategoria na base de dados
        /// </summary>
        /// <param name="subcategoriaModel">Dados de Subcategoria</param>
        /// <returns></returns>
        //olhar dependência de subcategoria de categoria
        public int Inserir(Subcategoria subcategoriaModel)
        {

            Tbsubcategoria _subcategoria = new Tbsubcategoria();
            _subcategoria.CodSubcategoria = subcategoriaModel.CodSubcategoria;
            _subcategoria.Nome = subcategoriaModel.Nome;
            _subcategoria.CodCategoria = subcategoriaModel.CodCategoria;
            _context.Add(_subcategoria);
            _context.SaveChanges();
            return _subcategoria.CodSubcategoria;
        }
        /// <summary>
        /// Obtem a subcategoria pelo nome
        /// </summary>
        /// <param name="nome">Nome da subcategoria a ser buscada</param>
        /// <returns></returns>
        public IEnumerable<Subcategoria> ObterPorNome(string nome)
        {
            IEnumerable<Subcategoria> subcategorias = GetQuery().Where(subcategoriasModel => subcategoriasModel.Nome.StartsWith(nome));
            return subcategorias;
        }
        /// <summary>
        /// Obtem todas as subcategorias
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Subcategoria> ObterTodos()
        {
            return GetQuery();
        }
        /// <summary>
        /// Remove uma subcategoria da base de dados
        /// </summary>
        /// <param name="codAnuncio">Identificador da subcategoria</param>
        public void Remover(int codSubcategoria)
        {

            var tbSubcategoria = _context.Tbsubcategoria.Find(codSubcategoria);
            _context.Tbsubcategoria.Remove(tbSubcategoria);
            _context.SaveChanges();
        }
        /// <summary>
        /// Exibe uma subcategoria pelo identificador dela
        /// </summary>
        /// <param name="codAnuncio">Identificador da subcategoria</param>
        /// <returns></returns>
        public Subcategoria Obter(int codAnuncio)
        {
            IEnumerable<Subcategoria> subcategorias = GetQuery().Where(subcategoriaModel => subcategoriaModel.CodSubcategoria.Equals(codAnuncio));
            return subcategorias.ElementAtOrDefault(0);
        }

        private IQueryable<Subcategoria> GetQuery()
        {

            IQueryable<Tbsubcategoria> Tbsubcategoria = _context.Tbsubcategoria;
            var query = from subcategoria in Tbsubcategoria
                        select new Subcategoria
                        {
                            CodSubcategoria = subcategoria.CodSubcategoria,
                            Nome = subcategoria.Nome,
                            CodCategoria = subcategoria.CodCategoria,
                            NomeCategoria = subcategoria.CodCategoriaNavigation.Nome
                        };
            return query;
        }

        public IEnumerable<Subcategoria> ObterPorNomeCategoria(String nomeCategoria)
        {
            IQueryable<Tbsubcategoria> tb_subcategoria = _context.Tbsubcategoria;
            var query = from subcategoria in tb_subcategoria
                        where subcategoria.CodCategoriaNavigation.Nome.Equals(nomeCategoria)
                        select new Subcategoria
                        {
                            CodSubcategoria = subcategoria.CodSubcategoria,
                            Nome = subcategoria.Nome,
                            CodCategoria = subcategoria.CodCategoria,
                            NomeCategoria = subcategoria.CodCategoriaNavigation.Nome
                        };
            return query;
        }

        public void Atribuir(Subcategoria subcategoriaModel, Tbsubcategoria subcategoria)
        {
            try
            {
                subcategoria.CodSubcategoria = subcategoriaModel.CodSubcategoria;
                subcategoria.Nome = subcategoria.Nome;
                subcategoria.CodCategoria = subcategoria.CodCategoria;

            }
            catch (Exception e)
            {
                throw new Exception($"Dados não atribuidos. Erro {e.Message}");
            }

        }

    }
}


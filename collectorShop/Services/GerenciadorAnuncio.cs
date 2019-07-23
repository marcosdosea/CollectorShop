using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Persistence;

namespace Services
{
    public class GerenciadorAnuncio : IGerenciadorAnuncio
    {
        private readonly collectorShopContext _context;
        public GerenciadorAnuncio(collectorShopContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Atualiza/Edita um anúncio na base de dados
        /// </summary>
        /// <param name="anuncioModel">Dados do anúncio</param>
        public void Editar(Model.Anuncio anuncioModel)
        {
            Persistence.Anuncio anuncio = new Persistence.Anuncio();
            Atribuir(anuncioModel, anuncio);
            _context.Update(anuncio);
            _context.SaveChanges();
        }
        /// <summary>
        /// Insere um novo anúncio na base de dados
        /// </summary>
        /// <param name="anuncioModel">Dados do anúncio</param>
        /// <returns></returns>

        public int Inserir(Model.Anuncio anuncioModel)
        {
            Persistence.Anuncio _anuncio = new Persistence.Anuncio();
            _anuncio.CodAnuncio = anuncioModel.CodAnuncio;
            _anuncio.CodUsuario = anuncioModel.CodUsuario;
            _anuncio.Descricao = anuncioModel.Descricao;
            _anuncio.Msg = anuncioModel.Msg;
            _anuncio.QuantAnunciada = anuncioModel.QuantAnunciada;
            _anuncio.QuantDisponivel = anuncioModel.QuantDisponivel;
            _anuncio.Status = anuncioModel.Status;
            _anuncio.Titulo = anuncioModel.Titulo;
            _anuncio.Valor = anuncioModel.Valor;
            return _anuncio.CodAnuncio;
        }
        /// <summary>
        /// Obtem o anúncio pelo título
        /// </summary>
        /// <param name="nome">Nome do anúncio a ser buscado</param>
        /// <returns></returns>
        public IEnumerable<Model.Anuncio> ObterPorNome(string nome)
        {
            IEnumerable<Model.Anuncio> anuncios = GetQuery().Where(anuncioModel => anuncioModel.Titulo.StartsWith(nome));
            return anuncios;
        }
        /// <summary>
        /// Obtem todos os anúncios 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Model.Anuncio> ObterTodos()
        {
            return GetQuery();
        }
        /// <summary>
        /// Remove um anúncio da base de dados
        /// </summary>
        /// <param name="codAnuncio">Identificador do Anúncio</param>
        public void Remover(int codAnuncio)
        {
            var tbAnuncio = _context.Anuncio.Find(codAnuncio);
            _context.Anuncio.Remove(tbAnuncio);
            _context.SaveChanges();
        }
        /// <summary>
        /// Exibe um anúncio pelo identificador dele
        /// </summary>
        /// <param name="codAnuncio">Identificador do anúncio</param>
        /// <returns></returns>
        public Model.Anuncio Visualizar(int codAnuncio)
        {
            IEnumerable<Model.Anuncio> anuncios = GetQuery().Where(anuncioModel => anuncioModel.CodAnuncio.Equals(codAnuncio));
            return anuncios.ElementAtOrDefault(0);
        }

        private IQueryable<Model.Anuncio> GetQuery()
        {
           
            IQueryable<Persistence.Anuncio> TBanuncio = _context.Anuncio;
            var query = from anuncio in TBanuncio
                        select new Model.Anuncio
                        {
                            CodAnuncio = anuncio.CodAnuncio,
                            Titulo = anuncio.Titulo
                        };
            return query;
        }

        public void Atribuir(Model.Anuncio anuncioModel, Persistence.Anuncio anuncio)
        {
            anuncio.CodAnuncio = anuncioModel.CodAnuncio;
            anuncio.CodUsuario = anuncioModel.CodUsuario;
            anuncio.Descricao = anuncioModel.Descricao;
            anuncio.Msg = anuncioModel.Msg;
            anuncio.QuantAnunciada = anuncioModel.QuantAnunciada;
            anuncio.QuantDisponivel = anuncioModel.QuantDisponivel;
            anuncio.Status = anuncioModel.Status;
            anuncio.Titulo = anuncioModel.Titulo;
            anuncio.Valor = anuncioModel.Valor;
            
        }

    }
}

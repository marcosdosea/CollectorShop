using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class GerenciadorUsuario : IGerenciadorUsuario
    {
        private readonly bancocollectorContext _context;

        public GerenciadorUsuario(bancocollectorContext context)
        {
            _context = context;
        }

        public void Inserir(Usuario usuarioModel)
        {
            Tbusuario _tbUsuario = new Tbusuario();
            _tbUsuario.CodUsuario = usuarioModel.CodUsuario;
            _tbUsuario.Cpf = usuarioModel.Cpf;
            _tbUsuario.Senha = usuarioModel.Senha;
            _tbUsuario.Cidade = usuarioModel.Cidade;
            _tbUsuario.Estado = usuarioModel.Estado;
            _tbUsuario.Email = usuarioModel.Email;
            _tbUsuario.Nome = usuarioModel.Nome;
            _tbUsuario.Cep = usuarioModel.Cep;
            _tbUsuario.Administrador = usuarioModel.Administrador;

            _context.Add(_tbUsuario);
            _context.SaveChanges();
        }
        public void Editar(Usuario usuarioModel)
        {
            try
            {
                Tbusuario tbusuario = new Tbusuario();
                Atribuir(usuarioModel, tbusuario);
                _context.Update(tbusuario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Usuário não atualizado. Erro de {e.Message}");
            }

        }
        public IEnumerable<Usuario> ObterPorNome(string nome)
        {
            IEnumerable<Usuario> usuarios = GetQuery().Where(usuarioModel => usuarioModel.Nome.StartsWith(nome));
            return usuarios;
        }
        public IEnumerable<Usuario> ObterTodos()
        {
            return GetQuery();
        }
        public void Remover(int codUsuario)
        {
            var tbUsuario = _context.Tbusuario.Find(codUsuario);
            _context.Tbusuario.Remove(tbUsuario);
            _context.SaveChanges();
        }
        public Usuario Obter(int codUsuario)
        {
            IEnumerable<Usuario> usuarios = GetQuery().Where(usuarioModel => usuarioModel.CodUsuario.Equals(codUsuario));
            return usuarios.ElementAtOrDefault(0);
        }
        private IQueryable<Usuario> GetQuery()
        {

            IQueryable<Tbusuario> TBusuario = _context.Tbusuario;
            var query = from usuarioModel in TBusuario
                        select new Usuario
                        {

                            CodUsuario = usuarioModel.CodUsuario,
                            Cpf = usuarioModel.Cpf,
                            Senha = usuarioModel.Senha,
                            Cidade = usuarioModel.Cidade,
                            Estado = usuarioModel.Estado,
                            Email = usuarioModel.Email,
                            Nome = usuarioModel.Nome,
                            Cep = usuarioModel.Cep,
                            Administrador = usuarioModel.Administrador,

                        };
            return query;
        }


        public void Atribuir(Usuario usuarioModel, Tbusuario usuario)
        {
            try
            {
                usuario.CodUsuario = usuarioModel.CodUsuario;
                usuario.Cpf = usuarioModel.Cpf;
                usuario.Senha = usuarioModel.Senha;
                usuario.Cidade = usuarioModel.Cidade;
                usuario.Estado = usuarioModel.Estado;
                usuario.Email = usuarioModel.Email;
                usuario.Nome = usuarioModel.Nome;
                usuario.Cep = usuarioModel.Cep;
                usuario.Administrador = usuarioModel.Administrador;

            }
            catch (Exception e)
            {
                throw new Exception($"Dados não atribuidos. Erro {e.Message}");
            }

        }
    }
}



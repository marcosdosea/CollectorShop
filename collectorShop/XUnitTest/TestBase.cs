using System;

using Microsoft.EntityFrameworkCore;

using Persistence;



namespace XUnitTest

{

    public abstract class TestBase



    {



        protected bancocollectorContext GetDbContext()



        {



            var options = new DbContextOptionsBuilder<bancocollectorContext>()

                                   .UseInMemoryDatabase(Guid.NewGuid().ToString())

                                   .Options;

            var context = new bancocollectorContext(options);



            var novoUsuario = new Tbusuario { CodUsuario = 1, Administrador = "Nao", Cpf = "07115678996", Nome = "Luiz Rocha", Email = "biorede2000@hotmail.com", Cidade = "Itabaiana", Estado = "Sergipe", Cep = "495000000", Senha = "M@caco82" };

            var novoUsuario2 = new Tbusuario { CodUsuario = 2, Administrador = "Sim", Cpf = "07115678996", Nome = "Luiz Rocha", Email = "biorede2000@hotmail.com", Cidade = "Itabaiana", Estado = "Sergipe", Cep = "495000000", Senha = "M@caco82" };

            context.Tbusuario.Add(novoUsuario);

            context.Tbusuario.Add(novoUsuario2);

            var BrinquedoCategoria = new Tbcategoria { CodCategoria = 1, Nome = "Brinquedo" };

            var LivroCategoria = new Tbcategoria { CodCategoria = 2, Nome = "Livro" };



            context.Tbcategoria.Add(BrinquedoCategoria);

            context.Tbcategoria.Add(LivroCategoria);

            context.SaveChanges();



            return context;

        }

    }

}

using Xunit;

using Services;

using System.Linq;



namespace XUnitTest.ServiceTest

{

    public class IGerenciadorUsuarioTest : TestBase

    {

        [Fact]

        public void Lista_deve_returnar_lista_de_Usuarios()

        {

            using (var context = GetDbContext())

            //  using (var controller = new UsuarioController()) 

            {

                var service = new GerenciadorUsuario(context);

                var result = service.ObterTodos();



                Assert.NotNull(result);



            }

        }

        [Fact]

        public void ObterTodos_deve_returnar_lista_com_todos_usuarios()

        {

            var dbContext = GetDbContext();

            dbContext.Tbusuario.Add(new Persistence.Tbusuario { CodUsuario = 3, Administrador = "Sim", Cpf = "54715678996", Nome = "Felipe Almeida", Email = "biorede@hotmail.com", Cidade = "Itabaiana", Estado = "Sergipe", Cep = "495000000", Senha = "M@caco82" });

            dbContext.SaveChanges();



            var service = new GerenciadorUsuario(dbContext);

            var result = service.ObterTodos();



            var model = result.ToList();



            Assert.NotNull(model);

            Assert.Equal(1, model.Count());

            Assert.NotNull(result);

        }

        [Fact]

        public void ObterUsuarioExistente_Pelo_Codigo()

        {

            var id = 1;

            var dbContext = GetDbContext();

            dbContext.Tbusuario.Add(new Persistence.Tbusuario { CodUsuario = 1, Administrador = "Sim", Cpf = "09635678996", Nome = "Luiz Marcos Rocha", Email = "biorede2000@hotmail.com", Cidade = "Itabaiana", Estado = "Sergipe", Cep = "495000000", Senha = "M@caco82" });

            dbContext.SaveChanges();



            var service = new GerenciadorUsuario(dbContext);

            var result = service.Obter(id);



            Assert.NotNull(result);

            Assert.Equal(id, result.CodUsuario);

        }



    }

}

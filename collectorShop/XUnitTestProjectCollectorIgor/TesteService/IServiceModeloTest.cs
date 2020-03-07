using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Services;
using System.Linq;

namespace XUnitTestProjectCollectorIgor.TesteService
{
    public class IServiceModeloTest : TesteBase
    {
        [Fact]
        public void Lista_deve_returnar_lista_de_Modelos()
        {
            using (var context = GetBancocollectorContext())
            //  using (var controller = new UsuarioController()) 
            {
                var service = new ServiceModelo(context);
                var result = service.ObterTodos();

                Assert.NotNull(result);

            }
        }

        [Fact]
        public void ObterModeloExistente_Pelo_Codigo()
        {
            var id = 1;
            var dbContext = GetBancocollectorContext();
            dbContext.Tbmodelo.Add(new Persistence.Tbmodelo
            {
                Ano = "2010",
                Autor = "Igor",
                CodModelo = 2,
                CodSubcategoria = 2,
                Colecao = "Chique",
                Desenhista = "Carlos",
                Edicao = "premium",
                Isbn = "0123487489123",
                Label = "tipico",
                Marca = "Charman",
                Nome = "Barbie",
                QuantTiragem = "Raro",
                Roteirista = "Alemberg",
                TbUsuarioCodUsuario = 1
            });
            dbContext.SaveChanges();

            var service = new ServiceModelo(dbContext);
            var result = service.Obter(id);

            Assert.NotNull(result);
            Assert.Equal(id, result.CodModelo);
        }
    }
}

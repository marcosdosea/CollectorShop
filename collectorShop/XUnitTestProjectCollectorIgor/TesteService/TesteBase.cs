using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace XUnitTestProjectCollectorIgor.TesteService
{
    public abstract class TesteBase
    {
        protected bancocollectorContext GetBancocollectorContext()
        {
            var options = new DbContextOptionsBuilder<bancocollectorContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var context = new bancocollectorContext(options);
            var novoModelo = new Tbmodelo
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
                TbUsuarioCodUsuario = 1,
                //CodSubcategoriaNavigation = Su
            };
            context.Tbmodelo.Add(novoModelo);
            context.SaveChanges();
            return context;
        }

    }
}

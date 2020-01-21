/*using System;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace UnidadeTeste
{
    public abstract class TestBase

    {

        protected bancocollectorContext GetDbContext()

        {

            var options = new DbContextOptionsBuilder<bancocollectorContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            return new bancocollectorContext(options);

        }

    }
}
*/
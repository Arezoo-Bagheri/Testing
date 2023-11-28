using Microsoft.EntityFrameworkCore;
using Testing.Core.Domain.Repositories;
using Testing.Infra.Data.Command.Sql;
using Testing.Infra.Data.Command.Sql.People;

namespace Testing.IntegrationTests.ApplicationService.People
{
    public class PersonCommandRepositoryFixture : IDisposable
    {
        public IPersonCommandRepository PersonCommandRepository { get; }
        public TestingDbContext DbContext { get; }

        public PersonCommandRepositoryFixture()
        {
            DbContextOptionsBuilder<TestingDbContext> builder = new DbContextOptionsBuilder<TestingDbContext>();
            builder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PeopleIntegrationTest;User Id=ar; Password=1qaz!QAZ;MultipleActive=true;");
            DbContext = new TestingDbContext(builder.Options);
            DbContext.Database.EnsureCreated();
            PersonCommandRepository = new PersonCommandRepository(DbContext);
        }

        public void Dispose()
        {
            DbContext.Database.EnsureDeleted();
         }
    }
}

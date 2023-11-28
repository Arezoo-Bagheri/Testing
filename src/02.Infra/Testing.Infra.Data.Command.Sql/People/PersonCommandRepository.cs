using Testing.Core.Domain.People.Entity;
using Testing.Core.Domain.Repositories;

namespace Testing.Infra.Data.Command.Sql.People
{
    public class PersonCommandRepository : IPersonCommandRepository
    {
        private readonly TestingDbContext _context;

        public PersonCommandRepository(TestingDbContext context)
        {
            _context = context;
        }

        public void Add(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }
    }
}

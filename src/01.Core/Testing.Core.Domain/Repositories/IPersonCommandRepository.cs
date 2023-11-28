using Testing.Core.Domain.People.Entity;

namespace Testing.Core.Domain.Repositories
{
    public interface IPersonCommandRepository
    {
        void Add(Person person);
    }
}
